using System;
using System.Collections.Generic;

namespace OrderPayment.Models;

public partial class Payment
{
    public int IdPayment { get; set; }

    public int OrderId { get; set; }

    public int MoneyArrivalId { get; set; }

    public decimal Sum { get; set; }
}
