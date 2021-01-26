using System;
using System.Collections.Generic;
using System.Text;

namespace OyunDemo
{
    class KampanyaManager : IKampanyaService
    {
        public void ekle()
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void guncelle()
        {
            Console.WriteLine("Kampanya güncellendi");
        }        

        public void sil()
        {
            Console.WriteLine("Kampanya silindi");
        }
    }
}
