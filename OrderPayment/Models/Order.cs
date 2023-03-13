using System;
using System.Collections.Generic;

namespace OrderPayment.Models;

public partial class Order
{
    public int IdOrder { get; set; }

    public DateTime Date { get; set; }

    public decimal Sum { get; set; }

    public decimal SumPaid { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;

        if (ReferenceEquals(this, obj))
            return true;

        if (this.GetType() != obj.GetType())
            return false;

        if (IdOrder == (obj as Order).IdOrder &&
            Date.Ticks == (obj as Order).Date.Ticks &&
            Sum == (obj as Order).Sum &&
            SumPaid == (obj as Order).SumPaid)
            return true;
        else
            return false;
    }
}
