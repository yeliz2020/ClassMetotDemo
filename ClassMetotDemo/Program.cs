using System;
using System.Collections;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Gülşen";
            musteri1.Surname = "Katık";
            musteri1.City = "Ankara";
            musteri1.Type = "Bireysel";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Ahmet";
            musteri2.Surname = "Çamlı";
            musteri2.City = "Denizli";
            musteri2.Type = "Kurumsal";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Name = "Yeliz";
            musteri3.Surname = "İşler";
            musteri3.City = "Kırşehir";
            musteri3.Type = "Bireysel";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Name = "Gülcan";
            musteri4.Surname = "Akdeniz";
            musteri4.City = "Ordu";
            musteri4.Type = "Kurumsal";


            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3, musteri4 };

            int a =musteriler.Length;
            Console.WriteLine("Mevcut Müşteri Sayısı: {0}",a);
          

            MusteriManager musteriManager = new MusteriManager();
            
            musteriManager.Add(musteri4);
            musteriManager.Show(musteriler);
            musteriManager.Del(musteri3);

            
            
        }

        
    }
}
