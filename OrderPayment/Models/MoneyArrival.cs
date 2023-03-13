using System;
using System.Collections.Generic;
using System.Windows.Forms.Design.Behavior;

namespace OrderPayment.Models;

public partial class MoneyArrival
{
    public int IdMoneyArrival { get; set; }

    public DateTime Date { get; set; }

    public decimal Sum { get; set; }

    public decimal SumRemaining { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;

        if (ReferenceEquals(this, obj))
            return true;

        if (this.GetType() != obj.GetType())
            return false;

        if (IdMoneyArrival == (obj as MoneyArrival).IdMoneyArrival &&
            Date.Ticks == (obj as MoneyArrival).Date.Ticks &&
            Sum == (obj as MoneyArrival).Sum &&
            SumRemaining == (obj as MoneyArrival).SumRemaining)
            return true;
        else
            return false;
    }
}
