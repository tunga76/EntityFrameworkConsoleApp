// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations.Schema;
using EntityFrameworkConsoleApp.DataBaseEntity;
using EntityFrameworkConsoleApp.DataContext;
using EntityFrameworkConsoleApp.Entities;
using EntityFrameworkConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


NorthWindContext context = new();


// var musteriler = await context.Musteriler.ToListAsync();

// var datas = from personel in context.Personellers
//             join satis in context.Satislars
//                 on personel.PersonelId equals satis.PersonelId into personelSatislari

//             select new {
//                 personel.Adi,
//                 satisAdedi = personelSatislari.Where(w=> w.SevkSehri.Contains("Resende")).Count()
//             };
// var query  = (from personel in context.Personellers
//              join satis in context.Satislars
//                 on personel.PersonelId equals satis.PersonelId into personelSatislari
//                 select new {
//                     personel.Adi,
//                     sayi = personelSatislari.Count(),
//                     personelSatislari
//                 }).ToList();

// var leftJoin  = from personel in context.Personellers
//              join satis in context.Satislars
//                 on personel.PersonelId equals satis.PersonelId into personelSatislari
//                 from satis in personelSatislari.DefaultIfEmpty()
//                 select new {
//                     personel.Adi,
//                     satis.OdemeTarihi
//                 };

// var rightJoin  = from satis in context.Satislars
//              join personel in context.Personellers
//                 on satis.PersonelId equals personel.PersonelId into personelSatislari
//                 from personel in personelSatislari.DefaultIfEmpty()
//                 select new {
//                     personel.Adi,
//                     satis.OdemeTarihi
//                 };

// var unionJoin = leftJoin.Union(rightJoin).ToList();

// var query = from musteri in context.Musterilers
//             from satislar in context.Satislars.Where(w=> w.MusteriId == musteri.MusteriId)
//             select new {
//                 musteri,
//                 satislar
//             };

// var query = from personel in context.Personellers
//             from satis in context.Satislars.Select(w=> w.SatisDetaylaris)
//             select new {
//                 personel,
//                 satis
//             };

// var query = context.Personellers.Select(s=> s.Satislars.Where(w=> w.SatisTarihi <= DateTime.Now).FirstOrDefault());

// var list    = await query.ToListAsync();

// foreach(var data in list)

// System.Console.WriteLine($"{data.SatisTarihi}");

while(true)
{
    await Task.Delay(2000);
var musterilist = context.Musterilers.Take(5).ToList();
foreach(Musteriler musteri in musterilist)
{
Console.WriteLine(musteri.MusteriAdi);

}
System.Console.WriteLine("*************************");
}