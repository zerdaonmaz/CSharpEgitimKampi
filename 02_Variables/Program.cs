﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.OutputEncoding = Encoding.Unicode;



            //Console.WriteLine("*****Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, patotaPrice, tomatoPrice;


            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //patotaPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice+"₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice+"₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice + "₺");
            //Console.WriteLine("---- Patates Birim Fiyatı:" + patotaPrice+"₺");
            //Console.WriteLine("---- Tomates Birim Fiyatı:" + tomatoPrice + "₺");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram,   patotaGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //patotaGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strberryTotalPrice = strawberryGram * strawberryPrice;
            //double patotaTotalPrice = patotaGram * patotaPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;



            //Console.WriteLine("Alınan Ürün: Elma -- " + "Birim Fiyatı: " + applePrice + " -Gramaj: " + appleGram + " --Toplam Tutar: " + appleTotalPrice + "₺"); 
            //Console.WriteLine("Alınan Ürün: Portakal -- " + "Birim Fiyatı: " + orangePrice + " -Gramaj: " + orangeGram + " --Toplam Tutar: " + orangeTotalPrice + "₺");
            //Console.WriteLine("Alınan Ürün: Çilek -- " + "Birim Fiyatı: " + strawberryPrice + " -Gramaj: " + strawberryGram + " --Toplam Tutar: " + strberryTotalPrice + "₺");
            //Console.WriteLine("Alınan Ürün: Patates -- " + "Birim Fiyatı: " + patotaPrice + " -Gramaj: " + patotaGram + " --Toplam Tutar: " + patotaTotalPrice + "₺");
            //Console.WriteLine("Alınan Ürün: Domates -- " + "Birim Fiyatı: " + tomatoPrice + " -Gramaj: " + tomatoGram + " --Toplam Tutar: " + tomatoTotalPrice + "₺");

            //double shoppingTotalPrice = appleTotalPrice+ orangeTotalPrice + strberryTotalPrice + patotaTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutarı:" + shoppingTotalPrice + "₺");




            #endregion

            #region Char Değişkenler


            //char symbol;
            //symbol ='a';
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Grişleri String Değişkenler

            //Console.WriteLine(" **** CSharp Hava Yolları Yolcu Bilgisi **** ");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentyNumber;

            //Console.Write(" Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write(" Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi:");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş:");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No:");
            //passengerIdentyNumber = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("-----------------");
            //Console.WriteLine( " Yolcu TC Kimlik No: " + passengerIdentyNumber + " " +  " -Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge + " ");












            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümleri

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoesCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız TV Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;

            //Console.WriteLine();


            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);











            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1= double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2= double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam3= double.Parse(Console.ReadLine());

            //result=(exam1 + exam2 +  exam3) / 3 ;

            //Console.WriteLine();
            //Console.Write("Sınav ortalamanız:" + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz:");
            //gender= char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet:"+ gender);  

            #endregion





















            Console.Read();







        }
    }
}
