using System;
using System.Collections;
using System.Collections.Generic;

namespace calisma5
{
    public class Sayilar
    {
        bool ciftMi;
        public List<bool> sayilarCiftMi = new List<bool>();
        public List<int> sayilar = new List<int>();
        public List<string> sayiMetinleri = new List<string>();

        public void SayiEkle(int sayi, string sayiMetini)
        {
            sayilar.Add(sayi);
            sayiMetinleri.Add(sayiMetini);
            tekCiftKontrol(sayi);//bool listesine ekleme yapıyor
        }
        public void tekCiftKontrol(int sayi)
        {
            if (sayi % 2 == 0)
                sayilarCiftMi.Add(true);
            else
                sayilarCiftMi.Add(false);
        }
        public void Yazdir()
        {

            System.Console.WriteLine("Sayilar:");
            for (int i = 0; i < sayilar.Count; i++)
            {
                System.Console.WriteLine((i + 1) + ".sayi:" + sayilar[i] + "   ");
                if (sayilarCiftMi[i] == true)
                    System.Console.WriteLine((i + 1) + ".sayi:" + "çift   ");
                else
                    System.Console.WriteLine((i + 1) + ".sayi:" + "tek   ");
            }
        }
        public void TekleriYazdir()
        {
            for (int i = 0; i < sayilar.Count; i++)
            {
                if (sayilarCiftMi[i] == false)
                    System.Console.WriteLine(sayilar[i] + "   ");
            }
        }
        public void CiftleriYazdir()
        {
            for (int i = 0; i < sayilar.Count; i++)
            {
                if (sayilarCiftMi[i] == true)
                    System.Console.WriteLine(sayilar[i] + "   ");
            }
        }
    }
}