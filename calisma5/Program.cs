using System;

namespace calisma5
{
    class Program
    {
        static void Main(string[] args)
        {
            string giris;
            Sayilar sayilar=new Sayilar();
            Metinler metinler=new Metinler();
            do
            {

                giris = Console.ReadLine();
                int sayi;
                if (int.TryParse(giris, out sayi))
                {
                    sayilar.SayiEkle(sayi,giris);
                }
                else
                {
                    metinler.MetinEkle(giris);
                    System.Console.WriteLine("bu bir metin");
                }
            } while (giris != "");
            string secenek;
            System.Console.WriteLine("(a) girişlerimdeki tek sayıları listele");
            System.Console.WriteLine("(b) girişlerimdeki çift sayıları listele");
            System.Console.WriteLine("(c) girişlerimdeki metinlerde kullanılan toplam sesli harf sayısı?");
            System.Console.WriteLine("(d) girişlerimdeki metinlerde kullanılan toplam sessiz harf sayısı?");
            System.Console.WriteLine("(e) girişlerimdeki sayıları listele");
            System.Console.WriteLine("(f) girişlerimdeki metinleri listele");
            System.Console.WriteLine("(g) tüm girişlerimi listele");
            secenek=Console.ReadLine();
            if(secenek=="a"){
                sayilar.TekleriYazdir();
            }
            else if(secenek=="b"){
                sayilar.CiftleriYazdir();
            }
            else if(secenek=="b"){
                sayilar.CiftleriYazdir();
            }
            else if(secenek=="c"){
                metinler.SesliHarfleriBul();
            }
            else if(secenek=="d"){
                metinler.SessizHarfleriBul();
            }
            else if(secenek=="e"){
                sayilar.Yazdir();
            }
            else if(secenek=="f"){
                metinler.MetinleriYazdir();
            }
            else if(secenek=="g"){
                sayilar.Yazdir();
                metinler.MetinleriYazdir();
            }
        }
    }
}
