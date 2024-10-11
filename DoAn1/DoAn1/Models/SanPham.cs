using System;
using System.Collections.Generic;

namespace DoAn1.Models;

public partial class SanPham
{
    public string ProductsId { get; set; } = null!;

    public string NameId { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public int? SpTonKho { get; set; }

    public string? CategoryId { get; set; }

    public string? BrandId { get; set; }

    public string? ImageUrl { get; set; }

    public DateOnly? DateAdded { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
