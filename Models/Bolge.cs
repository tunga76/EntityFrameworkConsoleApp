using System;
using System.Collections.Generic;

namespace EntityFrameworkConsoleApp.Models;

public partial class Bolge
{
    public int BolgeId { get; set; }

    public string BolgeTanimi { get; set; } = null!;

    public virtual ICollection<Bolgeler> Bolgelers { get; } = new List<Bolgeler>();
}
