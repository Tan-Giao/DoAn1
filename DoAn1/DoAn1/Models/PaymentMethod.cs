using System;
using System.Collections.Generic;

namespace DoAn1.Models;

public partial class PaymentMethod
{
    public string PaymentMethodId { get; set; } = null!;

    public string MethodName { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
