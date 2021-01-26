using System;

namespace OyunDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Oyuncu oyuncu1 = new Oyuncu { Id = 1, Ad = "Zekeriya", Soyad = "Demir", TcNo="12345678910", DogumTarihi = new DateTime(1980,1,26) };
            Oyuncu oyuncu2 = new Oyuncu { Id = 1, Ad = "Ömer", Soyad = "Türk", TcNo="12395678914", DogumTarihi = new DateTime(1990, 3, 6) };
            Kampanya kampanya1 = new Kampanya();
            kampanya1.KampanyaAdi = "% 20 İndirim";

            IOyucuDogrulamaService oyucuDogrulamaService = new OyuncuDogrulaManager();
            oyucuDogrulamaService.OyucuDogrula(oyuncu2);

            OyuncuManager oyuncuManager = new OyuncuManager(oyucuDogrulamaService);
            oyuncuManager.ekle(oyuncu1);
            oyuncuManager.ekle(oyuncu2);
            oyuncuManager.sil(oyuncu2);

            Oyun oyun1 = new Oyun();
            oyun1.Id = 1;
            oyun1.OyunAdi = "Araba Yarışı";

            OyunManager oyunManager = new OyunManager();
            oyunManager.SatisYap(oyuncu1);
            oyunManager.KampanyaliSatisYap(oyuncu2, kampanya1,oyun1);

        }
    }
}
