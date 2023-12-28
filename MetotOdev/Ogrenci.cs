using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MetotOdev
{
    public class Ogrenci
    {
       
            public void PuanHesapla(string ogrenciAd, string ogrenciSoyad, decimal not1, decimal not2, decimal not3)
            {
            Console.WriteLine("ad: {0}, soyad: {1}", ogrenciAd, ogrenciSoyad);
            decimal ortalama = (not1 + not2 + not3)/3;
            if (ortalama<45)
            {
                Console.WriteLine("ortalama degeriniz: {0} - Kaldınız", ortalama);

            }
            else
            {
                Console.WriteLine("ortalama degeriniz : {0} - Gectiniz!",ortalama);
            }
            Console.ReadLine();
        }
    }
}
