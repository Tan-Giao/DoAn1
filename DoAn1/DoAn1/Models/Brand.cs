using System;
using System.Collections.Generic;

namespace DoAn1.Models;

public partial class Brand
{

    public string BrandId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
