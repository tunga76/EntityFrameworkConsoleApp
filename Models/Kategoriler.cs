using System;
using System.Collections.Generic;

namespace EntityFrameworkConsoleApp.Models;

public partial class Kategoriler
{
    public int KategoriId { get; set; }

    public string KategoriAdi { get; set; } = null!;

    public string? Tanimi { get; set; }

    public byte[]? Resim { get; set; }

    public virtual ICollection<Urunler> Urunlers { get; } = new List<Urunler>();
}
