using System;
using System.Collections.Generic;
using Patikaflix;
class Program
{
    static void Main()
    {
        List<Dizi> diziler = new List<Dizi>();  // Tüm dizileri saklamak için bir liste oluşturuluyor

        while (true) // Kullanıcıdan dizi bilgilerini almak için sonsuz döngü
        {
            Dizi dizi = new Dizi(); // Yeni bir dizi nesnesi oluşturuluyor

            //Kullanıcıdan bilgiler alınıyor

            Console.WriteLine("Dizi adı giriniz.");
            dizi.Ad = Console.ReadLine();

            Console.WriteLine("Yapım yılını giriniz.");
            dizi.YapımYılı = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dizi türünü giriniz");
            dizi.Tur = Console.ReadLine();

            Console.WriteLine("Yayınlanmaya başladığı yılı giriniz.");
            dizi.YayınYılı = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yönetmenleri giriniz.");
            dizi.Yonetmen = Console.ReadLine();

            Console.WriteLine("Yayınlandığı ilk platformu giriniz");
            dizi.Platform = Console.ReadLine();

            diziler.Add(dizi);  // Alınan bilgiler listeye ekleniyor

            Console.WriteLine("Yeni bir dizi girmek ister misiniz?");   // Kullanıcıya yeni bir dizi eklemek isteyip istemediği soruluyor

            string cevap = Console.ReadLine().ToLower();

            if (cevap != "e" && cevap != "evet")   // Eğer kullanıcı 'e' veya 'evet' dışında bir şey yazarsa döngüden çıkılıyor
            {
                break;
            }
        }
            List<Komedi> komediDizisi = new List<Komedi>();  // Komedi dizilerini saklamak için bir liste oluşturuluyor

            Komedi komediDizileri = new Komedi();

        foreach (var dizi in diziler)   // Tüm diziler üzerinden dolaşılarak komedi türünde olanlar seçiliyor
        {
                if (dizi.Tur.ToLower() == "komedi") // Türü 'komedi' olanlar kontrol ediliyor
            {
                    komediDizisi.Add(new Komedi   // Komedi dizisi oluşturulup listeye ekleniyor
                    {
                        Ad = dizi.Ad,
                        Tur = dizi.Tur,
                        Yonetmen = dizi.Yonetmen
                    });
                }
            }

            Console.WriteLine("\nKomedi Dizileri:"); 
            foreach (var komedi in komediDizisi)      // Komedi dizileri ekrana yazdırılıyor
        {
                Console.WriteLine($"Dizi Adı: {komedi.Ad}, Yönetmen: {komedi.Yonetmen} ,Tür: {komedi.Tur} ");
            }
        }

    
}

