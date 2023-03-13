using Microsoft.EntityFrameworkCore;
using OrderPayment.Context;
using OrderPayment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderPayment.Forms
{
    public partial class FormPay : Form
    {
        private OrderPaymentDbContext _dbContext;

        private Order _order;
        private MoneyArrival _moneyArrival;

        public FormPay(Order order, MoneyArrival moneyArrival)
        {
            InitializeComponent();

            _order = order;
            _moneyArrival = moneyArrival;

            Text += _order.IdOrder.ToString();
            descriptionLabel.Text = $"Оплата заказа №{_order.IdOrder} из прихода денег №{_moneyArrival.IdMoneyArrival}";

            decimal maxPay = Math.Min(_order.Sum - _order.SumPaid, _moneyArrival.SumRemaining);
            payBox.Maximum = maxPay;
        }

        private async void payButton_Click(object sender, EventArgs e)
        {
            _dbContext = new();

            var orderCheck = await _dbContext.Orders.FirstOrDefaultAsync(o => o.IdOrder == _order.IdOrder);
            var moneyArrivalCheck = await _dbContext.MoneyArrivals.FirstOrDefaultAsync(m => m.IdMoneyArrival == _moneyArrival.IdMoneyArrival);

            if (!_order.Equals(orderCheck))
            {
                MessageBox.Show("Ваши данные о заказе или о приходе денег устарели, обновление списков", "Данные устарели");
                (Owner as FormMain).RefreshLists();
                Close();
                return;
            }

            if (!_moneyArrival.Equals(moneyArrivalCheck))
            {
                MessageBox.Show("Ваши данные о заказе или о приходе денег устарели, обновление списков", "Данные устарели");
                (Owner as FormMain).RefreshLists();
                Close();
                return;
            }

            Payment newPayment = new()
            {
                OrderId = _order.IdOrder,
                MoneyArrivalId = _moneyArrival.IdMoneyArrival,
                Sum = payBox.Value
            };

            _dbContext.Payments.Add(newPayment);
            await _dbContext.SaveChangesAsync();

            (Owner as FormMain).RefreshLists();
            Close();
        }
    }
}
