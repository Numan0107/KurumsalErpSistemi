using System;

public class StokHareket
{
    public int Id { get; set; }
    public int UrunId { get; set; } 
    public int SubeId { get; set; } 
    public int AdetDeğisimi { get; set; } 
    
   
    public string HareketTuru { get; set; } = "Giriş"; 
    public DateTime IslemTarihi { get; set; } = DateTime.Now;
}
