using System;
using System.Collections.Generic;

namespace EntityFrameworkConsoleApp.Models;

public partial class MusteriDemographic
{
    public string MusteriTypeId { get; set; } = null!;

    public string? MusteriDesc { get; set; }

    public virtual ICollection<Musteriler> Musteris { get; } = new List<Musteriler>();
}
