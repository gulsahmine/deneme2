using System;

namespace calisma4
{
    class Program
    {
        static void Main(string[] args)
        {               
                // dikdörtgen alan
            // System.Console.WriteLine("Kısa kenarı giriniz: ");
            // int kısaKenar = int.Parse(Console.ReadLine());
            // System.Console.WriteLine("Uzun kenarı giriniz: ");
            // int uzunKenar = int.Parse(Console.ReadLine());
            // int alan = kısaKenar*uzunKenar;
            // System.Console.WriteLine("Dikdörtgenin Alanı : "+ alan ) ;

                 // 2 sayı arasındaki asal sayıları yazdırma

            //  System.Console.WriteLine("ilk sayıyı giriniz:");
            //  int ilkSayi =int.Parse(Console.ReadLine());
            //  System.Console.WriteLine("Son sayıyı giriniz:");
            //  int sonSayi =int.Parse(Console.ReadLine());

            //  for (int i =ilkSayi; i <= sonSayi; i++)
            //  {
            //      bool asalmi = true;
            //     for(int j = 2 ; j<=i; j++)
            //     {
                   
            //     }
            //  }
                
            //Console Application ile yapılmış olan, bir tamsayı dizisinde 50 den küçük sayıların adetini bulan ve ekrana yazdıran örnek uygulama

             int[] sayilar = {15,28,59,78,2,46,99};
              int sayac = 0;
             System.Console.Write("Dizideki Sayılar : ");
             for(int i =0 ; i<sayilar.Length; i++)
             {
               System.Console.Write(sayilar[i] + " - " );
                if (sayilar [i]<50)
                {
                   sayac++;
                }
            }
                   System.Console.Write("50 den küçük sayılar" + sayilar[i]);
             
             System.Console.WriteLine("dizi içindeki 50 den küçük sayı adedi : " + sayac );
       
       
       
       
        }
   
   
   
   
   
    }




}
                


            

