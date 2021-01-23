using System;
using System.Collections.Generic;

namespace ClassMethotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MusteriClass musteri1 = new MusteriClass();
            musteri1.isim = "Çağdaş";
            musteri1.soyisim = "Dinçer";
            musteri1.TCno = 15895547851;
            musteri1.yas = 21;


            MusteriClass musteri2 = new MusteriClass() { isim = "Ahmet", soyisim = "Sezgin", TCno = 25874458741, yas = 55 };
            MusteriClass musteri3 = new MusteriClass() { isim = "Ayşe", soyisim = "Gök", TCno = 15874458741, yas = 37 };
            MusteriClass musteri4 = new MusteriClass() { isim = "Hasan", soyisim = "Taş", TCno = 45874458741, yas = 25 };



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Cikar(musteri2);
            musteriManager.Cizgi();

            MusteriClass[] musterilist = new MusteriClass[] { musteri1, musteri2, musteri3, musteri4 };

            List<string> İsimler = new List<string> { musteri1.isim, musteri2.isim, musteri3.isim, musteri4.isim };



            musteriManager.Listele(musteri4);





        }





    }
}
