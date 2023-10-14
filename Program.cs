// See https://aka.ms/new-console-template for more information

List<Product> list = new List<Product>{
    new Product{
        Id = 1,
        Ad = "Lenova",
        Fiyat = 500
    },
    new Product{
        Id = 1,
        Ad = "HP",
        Fiyat = 500
    },
    new Product{
        Id = 1,
        Ad = "DELL",
        Fiyat = 500
    },
    new Product{
        Id = 1,
        Ad = "Casper",
        Fiyat = 500
    },
    new Product{
        Id = 1,
        Ad = "Lenova",
        Fiyat = 500
    },
    new Product{
        Id = 1,
        Ad = "Lenova",
        Fiyat = 500
    }
};


var result = (from p in list
             group p by p.Ad
             into g
             select new {
                Sayi = g.Count(),
                Ad = g.Key
             }).ToList();


result.ForEach(s=> {

Console.WriteLine($"{s.Ad} - {s.Sayi}");

});

class Product{
    public int Id { get; set; } 
    public string Ad { get; set; }
    public int Fiyat { get; set; }

}