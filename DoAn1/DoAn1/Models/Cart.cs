using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.Design.Serialization;

namespace DoAn1.Models;

[Serializable]
public partial class Cart
{
    public string CartId { get; set; } = null!;

    public string? UserId { get; set; }

    public string? ProductId { get; set; }

    public int? Quantity { get; set; }

    public DateOnly? AddedDate { get; set; }

    public virtual SanPham? Product { get; set; }

    public virtual User? User { get; set; }
}


