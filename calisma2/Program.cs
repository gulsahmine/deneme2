using System;

namespace calisma2
{
    class Program
    {
        static void Main(string[] args)
        {
            // // 2 sayının toplamı
            // //uzun yol
            // int sayi1=12;
            // int sayi2=24;
            // int sonuc=sayi1+sayi2;
            // System.Console.WriteLine(sonuc);
            // //kısa yol
            // int sayi1=12,sayi2=24;
            // System.Console.WriteLine(sayi1 + sayi2);

        //     //kullanıcının girdiği 2 sayının karelerinin toplamı

        //     System.Console.WriteLine("Lütfen 1. sayı değerini giriniz");
        //     int sayi1 = Convert.ToInt16(Console.ReadLine());
        //     System.Console.WriteLine("Lütfen 2. sayı değerini giriniz");
        //     int sayi2 = Convert.ToInt16(Console.ReadLine());

        //     //Math.Pow (2,3); //2 nin 3 üncü kuvvetini alıyor.
        //    double sonuc = Math.Pow (sayi1,2) + Math.Pow (sayi2,2); //double döndürdüğü için double dedik
        //      System.Console.WriteLine(sonuc);;
                      
            //           //1 den 10 a kadar olan sayıların küplerinin toplamı
            //  double toplamsonucu = 0;
            //  for (int i = 1; i <=10; i++)
            //  {
            //      //toplamsonucu = i*i*i;
            //      toplamsonucu = Math.Pow(i,3);
            //  }
            //   System.Console.WriteLine(toplamsonucu);

            // double toplamsonucu=0;
            // int sayac =1;
            // do
            // {
            //     toplamsonucu = Math.Pow (sayac,3);
            //     sayac++;
            // }
            //    while(sayac<=10);
            //    System.Console.WriteLine(toplamsonucu);

            //Doğum Tarihi girilen kişinin yaşını hesaplama

            System.Console.WriteLine("doğum tarihinizi giriniz: ");
            DateTime dogumtarihi = Convert.ToDateTime(Console.ReadLine());
            int gun = (DateTime.Now - dogumtarihi).Days;
            int yas = gun /365;
            System.Console.WriteLine(yas);
        }
    }
}
