using System;
using System.Collections.Generic;
using System.Text;

namespace OyunDemo
{
    class OyunManager : IOyunSevice
    {
        public void KampanyaliSatisYap( Oyuncu oyuncu, Kampanya kampanya, Oyun oyun)
        {
            Console.WriteLine(oyuncu.Ad + " "+oyun.OyunAdi+" oyunu "+ kampanya.KampanyaAdi+" kampanyası ile sattı.");
        }

        public void SatisYap(Oyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Ad+" oyunu sattı.");
        }

        public void sil()
        {
            throw new NotImplementedException();
        }
    }
}
