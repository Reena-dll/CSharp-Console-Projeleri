using System;

namespace Matematik_Menüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            int islem;

            Console.Title = "Matematik Menüsü";
            Console.WriteLine("***************************************");
            Console.WriteLine();
            Console.WriteLine("Aritmetik İşlemler Menüsüne HoşGeldiniz!!!");
            Console.WriteLine();
            Console.WriteLine("********* Menü *********\n");

            Console.WriteLine("1- Aritmetik Dört İşlem");
            Console.WriteLine("2- Üs Alma");
            Console.WriteLine("3- Kök Alma");
            Console.WriteLine("4- Kare Alan ve Çevre Hesabı");
            Console.WriteLine("5- Dikdörtgen Alan ve Çevre Hesabı");
            Console.WriteLine("6- Eşkenar Üçgende Çevre Hesabı\n");

            Console.WriteLine("***************************************\n");

            Console.Write("İşlem Yapmak İstediğiniz Alan: ");
            islem = Convert.ToInt16(Console.ReadLine());

            if (islem == 1)
            {
                int  toplam, fark, carpim;
                double bolum;
                toplam = 0;
                carpim = 1;
                bolum = 1;
                fark = 0;
                int toplamsayi;
                Console.Write("Kaç Sayı Üzerinde Çalışacaksınız: ");
                toplamsayi = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                int[] sayilar = new int[toplamsayi];
                for (int i = 0; i < toplamsayi; i++)
                {
                    Console.Write((i + 1).ToString() + ". Sayıyı Giriniz: ");
                    sayilar[i] = Convert.ToInt16(Console.ReadLine());
                    toplam = toplam + sayilar[i];
                    fark = sayilar[i] - fark;
                    carpim = carpim * sayilar[i];
                    bolum = sayilar[i] / bolum;

                    
                }
                Console.WriteLine();
                Console.WriteLine("Sayılarınızın Toplamı: " + toplam);
                Console.WriteLine("Sayılarınızın Farkı: " + fark);
                Console.WriteLine("Sayılarınızın Çarpımı: " + carpim);
                Console.WriteLine("Sayılarınızın Bölümü: " + bolum);

                
            }
            else if(islem==2)
            {
                double us, sayi, sonuc;
                Console.Write("Sayıyı Giriniz: ");
                sayi = Convert.ToDouble(Console.ReadLine());
                Console.Write("Üssü Giriniz: ");
                us = Convert.ToInt32(Console.ReadLine());
                sonuc = Math.Pow(sayi, us);    // ÜS ALMA FORMÜLÜ
                Console.WriteLine();
                Console.WriteLine("Sonuç: " + sonuc);

               
                
            }

            else if(islem==3)
            {
                double kok, sonuc;
                Console.Write("Kök'ü alınacak olan sayıyı giriniz: ");
                kok = Convert.ToDouble(Console.ReadLine());
                sonuc = Math.Sqrt(kok);         // Kök alma formülü
                Console.WriteLine();
                Console.Write("Sonuç: " + sonuc);
            }

            else if (islem == 4)
            {
                int kenar, alan, cevre ;
                Console.Write("Karenizin bir kenar uzunluğunu giriniz: ");
                kenar = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                alan = kenar * kenar;
                cevre = kenar * 4;
                Console.WriteLine("Karenizin Çevresi: " + cevre);
                Console.WriteLine("Karenizin Alanı: " + alan);
            }


            else if(islem==5)
            {
                int uzunkenar, kısakenar, alan2, cevre2;
                Console.Write("Dikdörtgenin kısakenarını giriniz: ");
                kısakenar = Convert.ToInt32(Console.ReadLine());
                Console.Write("Dikdörtgenin uzunkenarını giriniz: ");
                uzunkenar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                cevre2 = (kısakenar * 2) + (uzunkenar * 2);
                alan2 = kısakenar * uzunkenar;

                Console.WriteLine("Dikdörtgeninizin Alanı: " + alan2);
                Console.WriteLine("Dikdörtgeninizin Çevresi: " + cevre2);


            }
            

            else if(islem==6)
            {
               int kenaruzun, cevre3;
                Console.Write("Eşkenar Üçgeninizin bir kenar uzunluğunu giriniz: ");
                kenaruzun = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                cevre3 = kenaruzun * 3;
                Console.Write("Eşkenar Üçgeninizin Çevresi: " + cevre3);

            }


            else
            {
                Console.Write("Girmiş olduğunuz değer aralığında bir işlem bulunmamaktadır.");
            }
            

            Console.Read();
        }
    }
}
