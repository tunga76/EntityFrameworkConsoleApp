using System;
using System.Collections.Generic;

namespace EntityFrameworkConsoleApp.Models;

public partial class OzetCeyrekSatislar
{
    public DateTime? SevkTarihi { get; set; }

    public int SatisId { get; set; }

    public decimal? Subtotal { get; set; }
}
