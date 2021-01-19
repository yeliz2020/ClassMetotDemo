using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " Müşteri Listesine Eklendi");
        }

        public void Del(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " Müşteri Listesinden Çıkarıldı");
        }


        public void Show(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Id: {0} ",musteri.Id);
                Console.WriteLine("Müşteri Adı: {0} {1} ", musteri.Name, musteri.Surname);
                Console.WriteLine("Şehir: {0} ", musteri.City);
                Console.WriteLine("Müşteri Tipi: {0} ", musteri.Type + " \n");
            }



        }
    }
}
