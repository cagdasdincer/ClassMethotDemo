using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethotDemo
{
    class MusteriManager
    {
        public void Ekle(MusteriClass musteri)
        {

            Console.WriteLine("Müşteri İsmi: " + musteri.isim + " " + "Müşteri TC: " + musteri.TCno + " " + "Müşteri Eklendi");



        }

        public void Cikar(MusteriClass musteri)
        {

            Console.WriteLine("Müşteri İsmi: " + musteri.isim + " " + "Müşteri TC: " + musteri.TCno + " " + "Müşteri Çıkarıldı");



        }

        public void Sil(MusteriClass musteri)
        {


            Console.WriteLine("Müşteri İsmi: " + musteri.isim + " " + "Müşteri TC: " + musteri.TCno + " " + "Müşteri Silindi");


        }

        public void Listele(MusteriClass musteri)
        {

            Console.WriteLine("Müşteri İsmi: " + musteri.isim + " " + "Müşteri TC: " + musteri.TCno + " " + "Müşteri Listelendi");






        }




        public void Cizgi()
        {

            Console.WriteLine("--------------------------");


        }




    }
}
