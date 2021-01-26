using System;
using System.Collections.Generic;
using System.Text;

namespace OyunDemo
{
    class OyuncuManager : IOyuncuService
    {
        private IOyucuDogrulamaService _oyucuDogrulamaService;

        public OyuncuManager(IOyucuDogrulamaService oyucuDogrulamaService)
        {
            _oyucuDogrulamaService = oyucuDogrulamaService;
        }       
        public void ekle(Oyuncu oyuncu)
        {
            if (_oyucuDogrulamaService.OyucuDogrula(oyuncu))
            {
                Console.WriteLine(oyuncu.Ad + " eklendi");
            }
            else
            {
                throw new Exception("kayıt yapılamadı");
            }
            
        }

        public void guncelle(Oyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Ad + " güncellendi");
        }

        public void sil(Oyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Ad + " silindi");
        }
    }
}
