﻿using System;
using System.Collections.Generic;

namespace EntityFrameworkConsoleApp.Models;

public partial class OrtalamaMaliyetinUzerindekiUrunler
{
    public string UrunAdi { get; set; } = null!;

    public decimal? BirimFiyati { get; set; }
}
