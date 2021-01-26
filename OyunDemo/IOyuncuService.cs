using System;
using System.Collections.Generic;
using System.Text;

namespace OyunDemo
{
    interface IOyuncuService
    {
        void ekle(Oyuncu oyuncu);
        void guncelle(Oyuncu oyuncu);
        void sil(Oyuncu oyuncu);

    }
}
