using System;

public class Urun
{
    public int Id { get; set; }
    public string Barkod { get; set; } = string.Empty;
    public string UrunAdi { get; set; } = string.Empty;
    public string Kategori { get; set; } = "Genel";
    public decimal SatisFiyati { get; set; }
}
