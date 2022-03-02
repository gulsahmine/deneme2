using System;
using System.Collections;
using System.Collections.Generic;

namespace calisma5
{
    class Metinler
    {
        List<string> metinler = new List<string>();
        public void MetinleriYazdir(){
            for (int i = 0; i < metinler.Count-1; i++)
            {
                System.Console.WriteLine(i+".metin:"+metinler[i]);
            }
        }
        public void MetinEkle(string metin)
        {
            metinler.Add(metin);
        }
        public void SesliHarfleriBul()
        {
            int sesliSayac = 0;
            int sessizSayac = 0;
            char[] sesliKontrol;
            for (int i = 0; i < metinler.Count; i++)
            {
                sesliKontrol = metinler[i].ToCharArray();
                for (int j = 0; j < sesliKontrol.Length; j++)
                {
                    if (sesliKontrol[j] == 'a' || sesliKontrol[j] == 'e' || sesliKontrol[j] == 'ı' || sesliKontrol[j] == 'i' ||
                    sesliKontrol[j] == 'o' || sesliKontrol[j] == 'ö' || sesliKontrol[j] == 'u' || sesliKontrol[j] == 'ü')
                    {
                        sesliSayac++;
                    }
                    else
                    {
                        sessizSayac++;
                    }
                }
            }
            System.Console.WriteLine("Sesli harf sayısı:"+sesliSayac);
        }
        public void SessizHarfleriBul()
        {
            int sesliSayac = 0;
            int sessizSayac = 0;
            char[] sesliKontrol;
            for (int i = 0; i < metinler.Count; i++)
            {
                sesliKontrol = metinler[i].ToCharArray();
                for (int j = 0; j < sesliKontrol.Length; j++)
                {
                    if(sesliKontrol[j] == 'a' || sesliKontrol[j] == 'e' || sesliKontrol[j] == 'ı' || sesliKontrol[j] == 'i' ||
                    sesliKontrol[j] == 'o' || sesliKontrol[j] == 'ö' || sesliKontrol[j] == 'u' || sesliKontrol[j] == 'ü')
                    {
                        sesliSayac++;
                    }
                    else
                    {
                        sessizSayac++;
                    }
                }
            }
            System.Console.WriteLine("Sessiz harf sayısı:"+sessizSayac);
        }
    }
}
