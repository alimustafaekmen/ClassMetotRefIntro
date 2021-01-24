using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotIntro
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri, ref List<Musteri> musteriler)
        {
            musteriler.Add(musteri);
            Console.WriteLine("Tebrikler Müşteri Eklendi : " + musteri.MusteriAdi);
        }


        public void MusteriListele(List<Musteri> musteriler)
        {
            string mesaj = "Müşteriler: ";

            foreach (Musteri musteri in musteriler)
            {
                string yeniMesaj = mesaj + " " + musteri.MusteriAdi;
                mesaj = yeniMesaj;
                
            }

            Console.WriteLine(mesaj);
            
        }

        public void MusteriSil(Musteri musteri, ref List<Musteri> musteriler)
        {
            musteriler.Remove(musteri);
            Console.WriteLine("Musteri silindi : " + musteri.MusteriAdi);
        }
    }
}
