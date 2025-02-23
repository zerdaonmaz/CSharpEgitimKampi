using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Hello word");
            //Console.Write("Hello");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region StringDeğişkenler



            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name ="Zerda";
            //Console.Write(name);


            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail;
            //string customerDistrict;
            //string customerCity;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 536 360 1574";
            //customerEmail = "aliç@gmail.com";
            //customerDistrict = "Kadıköy";
            //customerCity = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + customerDistrict + "/" + customerCity);
            //Console.WriteLine("----------------------------------------------------");

            //customerName = "ayşe";
            //customerSurname = "kaya";
            //customerPhone = "+90 544 789 15 74";
            //customerEmail = "ayşek@gmail.com";
            //customerDistrict = "Sapanca";
            //customerCity = "Sakarya";


            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + customerDistrict + "/" + customerCity);
            //Console.WriteLine("----------------------------------------------------");



            #endregion

            #region Int Değişkenler


            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL ");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL ");
            Console.WriteLine("-----Kola: " + cokePrice + " TL ");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL ");
            Console.WriteLine("-----Kızartma: " + friesPrice + " TL ");
            Console.WriteLine("-----Su: " + waterPrice + " TL ");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 4;
            cokeCount = 4;
            waterCount = 4;
            friesCount = 2;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Hamburger Tutarı:" + totalHamburgerPrice + "TL");
            Console.WriteLine("Kola Tutarı:" + totalCokePrice + "TL");
            Console.WriteLine("Su Tutarı:" + totalWaterPrice + "TL");
            Console.WriteLine("Kızartma Tutarı:" + totalFriesPrice + "TL");
            Console.WriteLine("Limonata Tutarı:" + totalLemonadePrice + "TL");
            Console.WriteLine("Pizza Tutarı:" + totalPizzaPrice + "TL");
            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalFriesPrice + totalLemonadePrice + totalCokePrice + totalWaterPrice + totalPizzaPrice;


            Console.WriteLine("Toplam Ödenecek Tutar:" + totalPrice + "TL");




            #endregion

            Console.Read();

        }
    }
}
