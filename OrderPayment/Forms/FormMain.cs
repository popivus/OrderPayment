using Microsoft.EntityFrameworkCore;
using OrderPayment.Context;
using OrderPayment.Forms;
using OrderPayment.Models;

namespace OrderPayment
{
    public partial class FormMain : Form
    {
        private OrderPaymentDbContext _dbContext;

        private List<MoneyArrival> _moneyArrivals;
        private List<Order> _orders;
        private List<Payment> _payments;

        public FormMain()
        {
            InitializeComponent();
            FillDataGridViews();
        }

        private async void FillDataGridViews()
        {
            await RefreshLists();

            moneyArrivalGridView.Columns["IdMoneyArrival"].HeaderText = "�����";
            moneyArrivalGridView.Columns["Date"].HeaderText = "����";
            moneyArrivalGridView.Columns["Sum"].HeaderText = "�����";
            moneyArrivalGridView.Columns["SumRemaining"].HeaderText = "�������";

            ordersGridView.Columns["IdOrder"].HeaderText = "�����";
            ordersGridView.Columns["Date"].HeaderText = "����";
            ordersGridView.Columns["Sum"].HeaderText = "�����";
            ordersGridView.Columns["SumPaid"].HeaderText = "����� ������";

            paymentsGridView.Columns["IdPayment"].Visible = false;
            paymentsGridView.Columns["OrderId"].HeaderText = "����� ������";
            paymentsGridView.Columns["MoneyArrivalId"].HeaderText = "����� ������� �����";
            paymentsGridView.Columns["Sum"].HeaderText = "����� �������";
        }

        public async Task RefreshLists()
        {
            _dbContext = new();

            _moneyArrivals = new();
            _orders = new();
            _payments = new();

            _moneyArrivals = await _dbContext.MoneyArrivals.ToListAsync();
            _orders = await _dbContext.Orders.ToListAsync();
            _payments = await _dbContext.Payments.ToListAsync();

            moneyArrivalGridView.DataSource = _moneyArrivals;
            ordersGridView.DataSource = _orders;
            paymentsGridView.DataSource = _payments;
        }

        private async void refreshDataButton_Click(object sender, EventArgs e)
        {
            await RefreshLists();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (ordersGridView.SelectedRows.Count == 0 || moneyArrivalGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("�������� ������ ����� � ������ ����� ��� ������", "������ �� �������");
                return;
            }

            var selectedOrderId = int.Parse(ordersGridView.SelectedRows[0].Cells[0].Value.ToString());
            Order order = _orders.FirstOrDefault(o => o.IdOrder == selectedOrderId);

            var selectedMoneyArrivalId = int.Parse(moneyArrivalGridView.SelectedRows[0].Cells[0].Value.ToString());
            MoneyArrival moneyArrival = _moneyArrivals.FirstOrDefault(m => m.IdMoneyArrival == selectedMoneyArrivalId);

            if (moneyArrival.SumRemaining == 0)
            {
                MessageBox.Show("� ������ ������� ����� ��� �������", "������ ����� ����");
                return;
            }

            if (order.SumPaid == order.Sum)
            {
                MessageBox.Show("����� ��� ������� ���������", "����� �������");
                return;
            }

            FormPay formPay = new(order, moneyArrival);
            formPay.Owner = this;
            formPay.ShowDialog();
        }
    }
}