﻿using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayisi: {0}",Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayşe", "Yılmaz", "IK");
            Console.WriteLine("Çalışan Sayisi: {0}",Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Deniz", "Arda", "IK");
            Calisan calisan2 = new Calisan("Elif", "Şirin", "IT");
            Console.WriteLine("Çalışan Sayisi: {0}",Calisan.CalisanSayisi);

            //Static sınıflardaki fonksiyonlara nesne olmadan sınıfla erişilir.
            //Static sınıf içerisinde static olmayan herhangi bir property veya fonksiyon tanımlayamayız.
            //Static sınıflardan kalıtım işlemi uygulanamaz.
            Console.WriteLine("Toplama işlemi sonucu {0}", Islemler.Topla(300,100)); //400
            Console.WriteLine("Çıkarma işlemi sonucu {0}", Islemler.Cikar(300,100)); //200
   
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }
        public string Isim;
        public string Soyisim;
        public string Departman;

        static Calisan(){
            calisanSayisi = 0;

        }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi ++;
        }
    }

    static class Islemler
    {
        public static long Topla (int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }

        public static long Cikar (int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
    } 
}
