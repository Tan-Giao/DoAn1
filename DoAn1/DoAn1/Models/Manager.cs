using System;
using System.Collections.Generic;

namespace DoAn1.Models;

public partial class Manager
{
    public string ManagerId { get; set; } = null!;

    public string NameManager { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
