namespace EntityFrameworkConsoleApp.Entities
{
    public class SatisDetay
    {
        public int SatisId { get; set; }
        public int UrunId { get; set; }
        public decimal BirimFiyati { get; set; }    
        public byte Miktar { get; set; }

    }
}