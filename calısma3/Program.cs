using System;
using System.Collections.Generic;
using System.Collections;

namespace calısma3
{
    class Program
    {
        static void Main(string[] args)
        {
           
           System.Console.WriteLine("Girişlerinizi Yapınız : ");
           System.Console.WriteLine("Sonlandırmak için giriş yapmadan Enter Tuşuna basınız. ");
          List<int> sayi = new List<int>();
          List<string> metin = new List<string>();

           string giris;

           do
           {
                giris = Console.ReadLine();
                
           }
           while (Console.ReadKey(true).Key != ConsoleKey.Enter);
           System.Console.WriteLine("girişler tamamlandı");
           System.Console.WriteLine("Yapmak istediğiniz işlemi seçiniz : ");
           System.Console.WriteLine("A) Girişlerimdeki tek sayıları listele");
           System.Console.WriteLine("B) Girişlerimdeki çift sayıları listele");
           System.Console.WriteLine("C) Girişlerimdeki metinlerde kullanılan toplam sesli harf sayısı?");
           System.Console.WriteLine("D) Girişlerimdeki metinlerde kullanılan toplam sessiz harf sayısı?");
           System.Console.WriteLine("E) Girişlerimdeki sayıları listele");
           System.Console.WriteLine("F) Girişlerimdeki metinleri listele");
           System.Console.WriteLine("G) Girişlerimdeki tüm girişlerimi listele");
           System.Console.Write("seçtiğiniz işlem : ");
           string secenek =Console.ReadLine();
           
           
           if (secenek == "a" || secenek == "A")
           {
              
           }

           
        }

       

        
           
    }

}
