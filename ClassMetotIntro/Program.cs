using System;
using System.Collections.Generic;

namespace ClassMetotIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musterimanager = new MusteriManager();
            List<Musteri> musteriList = new List<Musteri>();

            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Mustafa Ekmen";
            musteri1.MusteriNo = 18;
            musteri1.MusteriYasi = 15;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Burak Ekmen";
            musteri2.MusteriNo = 20;
            musteri2.MusteriYasi = 25;

            musterimanager.MusteriListele(musteriList);
            musterimanager.MusteriEkle(musteri1, ref musteriList);
            musterimanager.MusteriEkle(musteri2, ref musteriList);
            musterimanager.MusteriListele(musteriList);
            musterimanager.MusteriSil(musteri1, ref musteriList);
            musterimanager.MusteriListele(musteriList);















            //Musteri[] Musteriler = new Musteri[] { musteri1, musteri2 };
            //foreach (Musteri musteri in Musteriler)
            //{
            //    Console.WriteLine("Musteri : " + musteri.MusteriAdi);
            //}

            //Console.WriteLine("----------Metotlar-----------");
            
            
            //musterimanager.MusteriEkle(musteri1);
            //musterimanager.MusteriListele(Musteriler);
            //musterimanager.MusteriSil(musteri2);
            
        }
    }
}
