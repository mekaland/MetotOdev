using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ogrenciAd = string.Empty;
            string ogrenciSoyad = string.Empty;
            decimal not1 = 0;
            decimal not2 = 0;
            decimal not3 = 0;
            decimal ortalama = 0;
            // main metodunda kullanıcıdan adını soyadını ve 3 farklı ders notunu alıcaksın almış
            // oldugunuz bu bilgileri  ogrencı sınıfı içerisinde ogrenci puanhesapla adında bir metoda
            // parametre olarak verip daha sonra bilgisini ekrana çıkarıcaksınız daha sonra ortalamasını bulucaksınız 
            // eger ort 45 ten buyuk ise geçti değil ise kaldı diceksiniz
            Console.WriteLine("Adınızı Giriniz: ");
            ogrenciAd = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz: ");
            ogrenciSoyad = Console.ReadLine();
            Console.WriteLine("1.notu giriniz: ");
             not1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("2.notu giriniz: ");
             not2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("3.notu giriniz: ");
             not3 = decimal.Parse(Console.ReadLine());

            Ogrenci O = new Ogrenci();
            O.PuanHesapla(ogrenciAd,ogrenciSoyad,not1,not2,not3);
            
        }
    }
}
