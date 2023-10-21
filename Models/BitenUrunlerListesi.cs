using System;
using System.Collections.Generic;

namespace EntityFrameworkConsoleApp.Models;

public partial class BitenUrunlerListesi
{
    public int UrunId { get; set; }

    public string UrunAdi { get; set; } = null!;
}
