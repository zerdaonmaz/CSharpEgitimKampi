using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 Tane Yıldız Oluşturma

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan Yana 10 Tane Yıldız Oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Yan Yana 10 Tane Yıldız Oluşturma ve Alt Alta 10 Tane Yıldız Oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("***********");
            //}

            #endregion

            #region Dik Üçgen

            //for (int i=1; i<=5; i++)
            //{
            //    for(int j=1; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Ters Dik Üçgen

            //for( int i=5; i>=1; i--)
            //{
            //    for(int j=1; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Ters ve Dik Üçgen Beraber

            //for (int i=1; i<=5; i++)
            //{
            //    for(int j=1; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int k=4; k>=1; k--)
            //{
            //   for(int m=1; m<=k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //   Console.WriteLine();
            //}


            #endregion

            #region homework

            //double VKI,ağırlık, boy;

            //Console.Write("Lütfen Ağırlığınızı (kg) Giriniz: ");
            //ağırlık = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen Boyunuzu (metre) Giriniz: ");
            //boy = double.Parse(Console.ReadLine());

            //VKI = ağırlık / (boy * boy);
            //Console.WriteLine("Vücut Kitle Endeksiniz: " + VKI);

            //if (VKI<18.5)
            //{
            //    Console.Write("Düşük Ağırlık ");
            //}
            //else if (VKI>18.5 & VKI<25)
            //{
            //    Console.Write("Normal Ağırlık ");
            //}
            //else if (VKI > 25 & VKI < 30)
            //{
            //    Console.Write("1. Derece Obesite ");
            //}
            //else if (VKI > 30 & VKI < 35)
            //{
            //    Console.Write("2. Derece Obesite");
            //}
            //else if (VKI > 35 & VKI < 40)
            //{
            //    Console.Write("3. Derece Obesite");
            //}
            //else
            //{
            //    Console.Write("4.Derece Obesite");
            //}





            //int ogrenciSayısı = 20;
            //string[] isimler = new string[ogrenciSayısı];
            //double[] notlar = new double[ogrenciSayısı];
            //double toplamNot = 0;

            //for(int i=0; i<ogrenciSayısı; i++)
            //{
            //    Console.Write("Öğrencinin İsmini Giriniz: ");
            //    isimler[i] = Console.ReadLine();

            //    Console.Write("Öğrencinin Notunu Giriniz: ");
            //    notlar[i] = double.Parse(Console.ReadLine());

            //    toplamNot += notlar[i];
            //}

            //double sinifOrtalamasi = toplamNot / ogrenciSayısı;
            //Console.WriteLine("\nSınıf Ortalaması: " + sinifOrtalamasi);

            //Console.WriteLine("\nÖğrenci Sonuçları: ");

            //for(int i =0; i<ogrenciSayısı ; i++)
            //{
            //    string durum = notlar[i] >= sinifOrtalamasi ? "Geçti" : "Kaldı";
            //    Console.WriteLine($"{isimler[i]} - Not: {notlar[i]} - {durum}");
            //}





            //Random random = new Random();
            //int oyuncu1Kazandi = 0;
            //int oyuncu2Kazandi = 0;
            //int berabereSayisi = 0;

            //for (int i=0; i<100; i++)
            //{
            //    int zar1 = random.Next(1, 7);
            //    int zar2 = random.Next(1,7);

            //    if (zar1 > zar2)
            //        oyuncu1Kazandi++;
            //   else if (zar1 < zar2)
            //        oyuncu2Kazandi++;
            //    else
            //        berabereSayisi++;
            //}

            //Console.WriteLine($"Oyuncu 1 Kazanma Sayısı: {oyuncu1Kazandi}");
            //Console.WriteLine($"Oyuncu 2 Kazanma Sayısı: {oyuncu2Kazandi}");
            //Console.WriteLine($"Beraberlik Sayısı: {berabereSayisi}");

            //if (oyuncu1Kazandi > oyuncu2Kazandi)
            //    Console.WriteLine("Kazanan: Oyuncu 1 ");
            //else if (oyuncu2Kazandi > oyuncu1Kazandi)
            //    Console.WriteLine("Kazanan: Oyuncu 2 ");
            //else Console.WriteLine("Durum: Berabere ");














            #endregion

            #region Yarım Baklava Dilimi

            //int n = 5;
            //for (int i=1; i<=n; i++)
            //{
            //    for ( int j = n-1; j>0;  j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(int k=1; k<=2*i-1;  k++)
            //    { 
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}







            #endregion

            #region Piramit

            //int n = 5;
            //for(int i = 1; i <= n; i++)
            //{
            //  for(int j = n-i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //  for(int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //  Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit

            //int n = 5;
            //for(int i=n; i>=1; i--)
            //{
            //    for(int j=n-i; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion





            Console.Read();

        }
    }
}
