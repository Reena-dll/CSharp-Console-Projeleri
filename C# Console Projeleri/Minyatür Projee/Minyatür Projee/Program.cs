using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Media;
using System.IO;


namespace Kullanıcılı_Proje
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Title = "Reena Program";
            Console.CursorVisible = false;

            string yol = @"C:\Users\Reena\source\repos\Minyatür Projee\Minyatür Projee\NewFolder1\Hacker.wav";
            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = yol;
            ses.Play();
            Console.SetWindowSize(100, 50);
            KullanıcıGirisi();

        }

        public static void OrtalamaMakinesi()
        {
        bas:
            Console.Clear();


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 35);
            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄   ▄         ▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄ ");
            Console.SetCursorPosition(2, 36);
            Console.WriteLine("▐░░░░░░░░░░▌ ▐░▌       ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌");
            Console.SetCursorPosition(2, 37);
            Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌     ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
            Console.SetCursorPosition(2, 38);
            Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌       ▐░▌▐░▌          ▐░▌          ▐░▌▐░▌    ▐░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 39);
            Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄█░▌");
            Console.SetCursorPosition(2, 40);
            Console.WriteLine("▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌");
            Console.SetCursorPosition(2, 41);
            Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀      ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌   ▐░▌ ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
            Console.SetCursorPosition(2, 42);
            Console.WriteLine("▐░▌       ▐░▌     ▐░▌          ▐░▌     ▐░▌  ▐░▌          ▐░▌          ▐░▌    ▐░▌▐░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 43);
            Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌     ▐░▌          ▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌     ▐░▐░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 44);
            Console.WriteLine("▐░░░░░░░░░░▌      ▐░▌          ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 45);
            Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀        ▀            ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀         ▀ ");


            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;

            int ihtimal, yuzde;
            Console.SetCursorPosition(28, 10);
            Console.WriteLine("Ortalama Hesaplama Menüsüne Hoş Geldiniz...");
            System.Threading.Thread.Sleep(2000);

            Console.SetCursorPosition(28, 11);
            Console.Write("Kaç Adet Vize Sınavına Girdiniz: ");
            ihtimal = Convert.ToInt16(Console.ReadLine());
            if (ihtimal > 2)
            {
                goto bas;
            }

            Console.SetCursorPosition(28, 12);
            Console.Write("Bir Vizenizin Dönem Notu Puanına Etkileyecek %'si Kaç: ");
            yuzde = Convert.ToInt16(Console.ReadLine());
            if (yuzde > 51)
            {
                goto bas;
            }

            if (ihtimal == 1)
            {

                int v1ze, f1nal, ortalama;
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(28, 13);
                Console.Write("Vize'den aldığınız notu giriniz: ");
                v1ze = Convert.ToInt16(Console.ReadLine());
                if (v1ze > 100)
                {
                    goto bas;
                }

            iht1mal:

                Console.SetCursorPosition(28, 14);
                Console.Write("Finalden Aldığınız Notu Giriniz: ");
                f1nal = Convert.ToInt16(Console.ReadLine());
                if (f1nal > 100)
                {
                    goto bas;
                }

                v1ze = (v1ze * yuzde) / 100;
                f1nal = (f1nal * (100 - yuzde) / 100);
                ortalama = v1ze + f1nal;
                if (ortalama > 100)
                {
                    Console.WriteLine("                ***** ");
                    Console.WriteLine("                ***** ");
                    Console.WriteLine("             ***********          ");
                    Console.WriteLine("              ********         ");
                    Console.WriteLine("                *****             ");
                    Console.WriteLine("                 ***");
                    Console.WriteLine("                  *");
                    Console.WriteLine("Yanlış puan girdiniz yeniden deneyiniz \n");
                    Console.ReadKey();

                    goto bas;
                }



                if (ortalama >= 90)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(28, 16);
                    Console.WriteLine("        Ortalama Değeriniz {0}", ortalama);
                    Console.SetCursorPosition(28, 17);
                    Console.WriteLine("        A Aldınız...");
                }

                else if (ortalama >= 80)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(28, 16);
                    Console.WriteLine("        Ortalama Değeriniz {0}", ortalama);
                    Console.SetCursorPosition(28, 17);
                    Console.WriteLine("        B Aldınız...");
                }

                else if (ortalama >= 70)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(28, 16);
                    Console.WriteLine("        Ortalama Değeriniz {0}", ortalama);
                    Console.SetCursorPosition(28, 17);
                    Console.WriteLine("        C Aldınız...");
                }

                else if (ortalama >= 60)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(28, 16);
                    Console.WriteLine("        Ortalama Değeriniz {0}", ortalama);
                    Console.SetCursorPosition(28, 17);
                    Console.WriteLine("        D Aldınız...");
                }


                else if (ortalama >= 50)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(28, 17);
                    Console.WriteLine("        Ortalama Değeriniz {0}", ortalama);
                    Console.SetCursorPosition(28, 18);
                    Console.WriteLine("        Şartlı Kaldınız...");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(28, 17);
                    Console.WriteLine("        Ortalama Değeriniz {0}", ortalama);
                    Console.SetCursorPosition(28, 18);
                    Console.WriteLine("        Kaldınız...");
                }
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(28, 25);
                Console.Write("10 Saniye Sonra Seçim Ekranına Aktarılacaksınız.");

            }

            else if (ihtimal == 2)
            {

                int v2ze, v2ze2, f2nal, ortalama2;

                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(28, 13);
                Console.Write("Birinci vizeden aldığınız notu giriniz: ");
                v2ze = Convert.ToInt16(Console.ReadLine());
                if (v2ze > 100)
                {
                    goto bas;
                }


                Console.SetCursorPosition(28, 14);
                Console.Write("İkinci vizeden aldığınız notu giriniz: ");
                v2ze2 = Convert.ToInt16(Console.ReadLine());
                if (v2ze2 > 100)
                {
                    goto bas;
                }

                Console.SetCursorPosition(28, 15);
                Console.Write("Finalden Aldığınız Notu Giriniz: ");
                f2nal = Convert.ToInt16(Console.ReadLine());
                if (f2nal > 100)
                {
                    goto bas;
                }

                v2ze = (v2ze * yuzde) / 100;
                v2ze2 = (v2ze2 * yuzde) / 100;
                f2nal = (f2nal * (100 - (yuzde * 2))) / 100;
                ortalama2 = v2ze + v2ze2 + f2nal;

                if (ortalama2 > 100)
                {
                    Console.WriteLine("               ***** ");
                    Console.WriteLine("               ***** ");
                    Console.WriteLine("             ***********          ");
                    Console.WriteLine("              ********         ");
                    Console.WriteLine("               *****             ");
                    Console.WriteLine("                ***");
                    Console.WriteLine("                 *");
                    Console.WriteLine("Yanlış puan girdiniz yeniden deneyiniz \n");
                    Console.ReadKey();

                    goto bas;
                }




                if (ortalama2 >= 90)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(28, 17);
                    Console.WriteLine("        Ortalama Değeriniz {0}", ortalama2);
                    Console.SetCursorPosition(28, 18);
                    Console.WriteLine("        A Aldınız...");
                }

                else if (ortalama2 >= 80)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(28, 17);
                    Console.WriteLine("        Ortalama Değeriniz {0}", ortalama2);
                    Console.SetCursorPosition(28, 18);
                    Console.WriteLine("        B Aldınız...");
                }

                else if (ortalama2 >= 70)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(28, 17);
                    Console.WriteLine("        Ortalama Değeriniz {0}", ortalama2);
                    Console.SetCursorPosition(28, 18);
                    Console.WriteLine("        C Aldınız...");
                }

                else if (ortalama2 >= 60)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(28, 17);
                    Console.WriteLine("        Ortalama Değeriniz {0}", ortalama2);
                    Console.SetCursorPosition(28, 18);
                    Console.WriteLine("        D Aldınız...");
                }



                else if (ortalama2 >= 50)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(28, 17);
                    Console.WriteLine("        Ortalama Değeriniz {0}", ortalama2);
                    Console.SetCursorPosition(28, 18);
                    Console.WriteLine("        Şartlı Kaldınız...");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(28, 17);
                    Console.WriteLine("        Ortalama Değeriniz {0}", ortalama2);
                    Console.SetCursorPosition(28, 18);
                    Console.WriteLine("        Kaldınız...");
                }
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(28, 25);
                Console.Write("10 Saniye Sonra Seçim Ekranına Aktarılacaksınız.");

            }




        }
        public static void HesapMakinesi()
        {
        enbas:

            Console.Clear();


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 35);
            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄   ▄         ▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄ ");
            Console.SetCursorPosition(2, 36);
            Console.WriteLine("▐░░░░░░░░░░▌ ▐░▌       ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌");
            Console.SetCursorPosition(2, 37);
            Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌     ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
            Console.SetCursorPosition(2, 38);
            Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌       ▐░▌▐░▌          ▐░▌          ▐░▌▐░▌    ▐░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 39);
            Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄█░▌");
            Console.SetCursorPosition(2, 40);
            Console.WriteLine("▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌");
            Console.SetCursorPosition(2, 41);
            Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀      ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌   ▐░▌ ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
            Console.SetCursorPosition(2, 42);
            Console.WriteLine("▐░▌       ▐░▌     ▐░▌          ▐░▌     ▐░▌  ▐░▌          ▐░▌          ▐░▌    ▐░▌▐░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 43);
            Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌     ▐░▌          ▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌     ▐░▐░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 44);
            Console.WriteLine("▐░░░░░░░░░░▌      ▐░▌          ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 45);
            Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀        ▀            ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀         ▀ ");


            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;


            int islem;

            Console.SetCursorPosition(28, 8);
            Console.WriteLine("Hesaplama Menüsüne Hoş Geldiniz...");
            System.Threading.Thread.Sleep(2000);

            Console.SetCursorPosition(28, 9);
            Console.WriteLine("1- Aritmetik Dört İşlem");
            Console.SetCursorPosition(28, 10);
            Console.WriteLine("2- Üs Alma");
            Console.SetCursorPosition(28, 11);
            Console.WriteLine("3- Kök Alma");
            Console.SetCursorPosition(28, 12);
            Console.WriteLine("4- Kare Alan ve Çevre Hesabı");
            Console.SetCursorPosition(28, 13);
            Console.WriteLine("5- Dikdörtgen Alan ve Çevre Hesabı");
            Console.SetCursorPosition(28, 14);
            Console.WriteLine("6- Eşkenar Üçgende Çevre Hesabı\n");
            Console.SetCursorPosition(28, 15);
            Console.WriteLine("7- Faktöriyel Hesabı");
            Console.SetCursorPosition(28, 16);
            Console.WriteLine("8- Bölünebilme İşlemi");
            Console.SetCursorPosition(28, 17);
            Console.WriteLine("9- Bir Önce Ki Menüye Dönmek İçin");


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("İşlem Yapmak İstediğiniz Alan: ");
            islem = Convert.ToInt16(Console.ReadLine());
            islem = Math.Abs(islem);
            Console.SetCursorPosition(45, 3);
            Console.WriteLine("Menüden Geri Çıkmak istiyorsanız G Tuşuna Basınız...");



            if (islem == 1)
            {
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(2, 35);
                Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄   ▄         ▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄ ");
                Console.SetCursorPosition(2, 36);
                Console.WriteLine("▐░░░░░░░░░░▌ ▐░▌       ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌");
                Console.SetCursorPosition(2, 37);
                Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌     ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
                Console.SetCursorPosition(2, 38);
                Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌       ▐░▌▐░▌          ▐░▌          ▐░▌▐░▌    ▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 39);
                Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄█░▌");
                Console.SetCursorPosition(2, 40);
                Console.WriteLine("▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌");
                Console.SetCursorPosition(2, 41);
                Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀      ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌   ▐░▌ ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
                Console.SetCursorPosition(2, 42);
                Console.WriteLine("▐░▌       ▐░▌     ▐░▌          ▐░▌     ▐░▌  ▐░▌          ▐░▌          ▐░▌    ▐░▌▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 43);
                Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌     ▐░▌          ▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌     ▐░▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 44);
                Console.WriteLine("▐░░░░░░░░░░▌      ▐░▌          ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 45);
                Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀        ▀            ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀         ▀ ");


                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;

                int toplam, fark, carpim;
                double bolum;
                toplam = 0;
                carpim = 1;
                bolum = 1;
                fark = 0;
                int toplamsayi;
                Console.SetCursorPosition(28, 9);
                Console.WriteLine("Aritmatik Dört İşlem Menümüze Hoş Geldiniz...");
                Console.SetCursorPosition(28, 10);
                Console.Write("Kaç Sayı Üzerinde Çalışacaksınız: ");
                toplamsayi = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                int[] sayilar = new int[toplamsayi];
                for (int i = 0; i < toplamsayi; i++)
                {
                    Console.SetCursorPosition(28, 11 + i);
                    Console.Write((i + 1).ToString() + ". Sayıyı Giriniz: ");
                    sayilar[i] = Convert.ToInt16(Console.ReadLine());
                    toplam = toplam + sayilar[i];
                    fark = Math.Abs(sayilar[i] - fark);
                    carpim = carpim * sayilar[i];
                    bolum = sayilar[i] / bolum;


                }
               ;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(28, 14);
                Console.WriteLine("Sayılarınızın Toplamı: " + toplam);
                Console.SetCursorPosition(28, 15);
                Console.WriteLine("Sayılarınızın Farkı: " + fark);
                Console.SetCursorPosition(28, 16);
                Console.WriteLine("Sayılarınızın Çarpımı: " + carpim);
                Console.SetCursorPosition(28, 17);
                Console.WriteLine("Sayılarınızın Bölümü: " + bolum);
                System.Threading.Thread.Sleep(5000);

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.SetCursorPosition(24, 20);
                Console.WriteLine("Beş Saniye Sonra Hesaplama Menüsüne Geri Döneceksiniz.");
                    Console.SetCursorPosition(47, 21);
                    Console.WriteLine("-5-");
                    System.Threading.Thread.Sleep(1000);
                    Console.SetCursorPosition(47, 22);
                    Console.WriteLine("-4-");
                    System.Threading.Thread.Sleep(1000);
                    Console.SetCursorPosition(47, 23);
                    Console.WriteLine("-3-");
                    System.Threading.Thread.Sleep(1000);
                    Console.SetCursorPosition(47, 24);
                    Console.WriteLine("-2-");
                    System.Threading.Thread.Sleep(1000);
                    Console.SetCursorPosition(47, 25);
                    Console.WriteLine("-1-");
                    System.Threading.Thread.Sleep(1000);
                    goto enbas;
              
            }

            else if (islem == 2)
            {

                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(2, 35);
                Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄   ▄         ▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄ ");
                Console.SetCursorPosition(2, 36);
                Console.WriteLine("▐░░░░░░░░░░▌ ▐░▌       ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌");
                Console.SetCursorPosition(2, 37);
                Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌     ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
                Console.SetCursorPosition(2, 38);
                Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌       ▐░▌▐░▌          ▐░▌          ▐░▌▐░▌    ▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 39);
                Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄█░▌");
                Console.SetCursorPosition(2, 40);
                Console.WriteLine("▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌");
                Console.SetCursorPosition(2, 41);
                Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀      ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌   ▐░▌ ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
                Console.SetCursorPosition(2, 42);
                Console.WriteLine("▐░▌       ▐░▌     ▐░▌          ▐░▌     ▐░▌  ▐░▌          ▐░▌          ▐░▌    ▐░▌▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 43);
                Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌     ▐░▌          ▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌     ▐░▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 44);
                Console.WriteLine("▐░░░░░░░░░░▌      ▐░▌          ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 45);
                Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀        ▀            ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀         ▀ ");


                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;

                double us, sayi, sonuc;
                Console.SetCursorPosition(28, 10);
                Console.Write("Üs Alma Menümüze Hoş Geldiniz...");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(28, 11);
                Console.Write("Sayıyı Giriniz: ");
                sayi = Convert.ToDouble(Console.ReadLine());
                Console.SetCursorPosition(28, 12);
                Console.Write("Üssü Giriniz: ");
                us = Convert.ToInt32(Console.ReadLine());
                sonuc = Math.Pow(sayi, us);    // ÜS ALMA FORMÜLÜ
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(28, 14);
                Console.WriteLine("Sonuç: " + sonuc);
                System.Threading.Thread.Sleep(2000);

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.SetCursorPosition(24, 20);
                Console.WriteLine("Beş Saniye Sonra Hesaplama Menüsüne Geri Döneceksiniz");
                Console.SetCursorPosition(47, 21);
                Console.WriteLine("-5-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 22);
                Console.WriteLine("-4-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 23);
                Console.WriteLine("-3-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 24);
                Console.WriteLine("-2-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 25);
                Console.WriteLine("-1-");
                System.Threading.Thread.Sleep(1000);
                goto enbas;

            }

            else if (islem == 3)
            {
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(2, 35);
                Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄   ▄         ▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄ ");
                Console.SetCursorPosition(2, 36);
                Console.WriteLine("▐░░░░░░░░░░▌ ▐░▌       ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌");
                Console.SetCursorPosition(2, 37);
                Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌     ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
                Console.SetCursorPosition(2, 38);
                Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌       ▐░▌▐░▌          ▐░▌          ▐░▌▐░▌    ▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 39);
                Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄█░▌");
                Console.SetCursorPosition(2, 40);
                Console.WriteLine("▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌");
                Console.SetCursorPosition(2, 41);
                Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀      ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌   ▐░▌ ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
                Console.SetCursorPosition(2, 42);
                Console.WriteLine("▐░▌       ▐░▌     ▐░▌          ▐░▌     ▐░▌  ▐░▌          ▐░▌          ▐░▌    ▐░▌▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 43);
                Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌     ▐░▌          ▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌     ▐░▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 44);
                Console.WriteLine("▐░░░░░░░░░░▌      ▐░▌          ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 45);
                Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀        ▀            ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀         ▀ ");


                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;

                double kok, sonuc;
                Console.SetCursorPosition(28, 10);
                Console.WriteLine("Kök Alma Menümüze Hoş Geldiniz...");
                System.Threading.Thread.Sleep(1000);

                Console.SetCursorPosition(28, 11);
                Console.Write("Kök'ü alınacak olan sayıyı giriniz: ");
                kok = Convert.ToDouble(Console.ReadLine());
                sonuc = Math.Sqrt(kok);         // Kök alma formülü
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(28, 13);
                Console.Write("Sonuç: " + sonuc);
                System.Threading.Thread.Sleep(2000);

                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(24, 20);
                Console.WriteLine("Beş Saniye Sonra Hesaplama Menüsüne Geri Döneceksiniz");
                Console.SetCursorPosition(47, 21);
                Console.WriteLine("-5-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 22);
                Console.WriteLine("-4-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 23);
                Console.WriteLine("-3-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 24);
                Console.WriteLine("-2-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 25);
                Console.WriteLine("-1-");
                System.Threading.Thread.Sleep(1000);
                goto enbas;
            }


            if (islem == 4)
            {
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(2, 35);
                Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄   ▄         ▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄ ");
                Console.SetCursorPosition(2, 36);
                Console.WriteLine("▐░░░░░░░░░░▌ ▐░▌       ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌");
                Console.SetCursorPosition(2, 37);
                Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌     ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
                Console.SetCursorPosition(2, 38);
                Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌       ▐░▌▐░▌          ▐░▌          ▐░▌▐░▌    ▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 39);
                Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄█░▌");
                Console.SetCursorPosition(2, 40);
                Console.WriteLine("▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌");
                Console.SetCursorPosition(2, 41);
                Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀      ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌   ▐░▌ ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
                Console.SetCursorPosition(2, 42);
                Console.WriteLine("▐░▌       ▐░▌     ▐░▌          ▐░▌     ▐░▌  ▐░▌          ▐░▌          ▐░▌    ▐░▌▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 43);
                Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌     ▐░▌          ▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌     ▐░▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 44);
                Console.WriteLine("▐░░░░░░░░░░▌      ▐░▌          ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 45);
                Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀        ▀            ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀         ▀ ");


                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;


                int kenar, alan, cevre;
                Console.SetCursorPosition(28, 10);
                Console.WriteLine("Kare Çevre Alan Hesabı Menümüze Hoş Geldiniz...");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(28, 11);
                Console.Write("Karenizin bir kenar uzunluğunu giriniz: ");
                kenar = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                alan = kenar * kenar;
                cevre = kenar * 4;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(28, 13);
                Console.WriteLine("Karenizin Çevresi: " + cevre);
                Console.SetCursorPosition(28, 14);
                Console.WriteLine("Karenizin Alanı: " + alan);
                System.Threading.Thread.Sleep(2000);


                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(24, 20);
                Console.WriteLine("Beş Saniye Sonra Hesaplama Menüsüne Geri Döneceksiniz");
                Console.SetCursorPosition(47, 21);
                Console.WriteLine("-5-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 22);
                Console.WriteLine("-4-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 23);
                Console.WriteLine("-3-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 24);
                Console.WriteLine("-2-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 25);
                Console.WriteLine("-1-");
                System.Threading.Thread.Sleep(1000);
                goto enbas;

            }

            if (islem == 5)
            {
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(2, 35);
                Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄   ▄         ▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄ ");
                Console.SetCursorPosition(2, 36);
                Console.WriteLine("▐░░░░░░░░░░▌ ▐░▌       ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌");
                Console.SetCursorPosition(2, 37);
                Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌     ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
                Console.SetCursorPosition(2, 38);
                Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌       ▐░▌▐░▌          ▐░▌          ▐░▌▐░▌    ▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 39);
                Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄█░▌");
                Console.SetCursorPosition(2, 40);
                Console.WriteLine("▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌");
                Console.SetCursorPosition(2, 41);
                Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀      ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌   ▐░▌ ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
                Console.SetCursorPosition(2, 42);
                Console.WriteLine("▐░▌       ▐░▌     ▐░▌          ▐░▌     ▐░▌  ▐░▌          ▐░▌          ▐░▌    ▐░▌▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 43);
                Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌     ▐░▌          ▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌     ▐░▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 44);
                Console.WriteLine("▐░░░░░░░░░░▌      ▐░▌          ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 45);
                Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀        ▀            ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀         ▀ ");


                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;

                int uzunkenar, kısakenar, alan2, cevre2;
                Console.SetCursorPosition(28, 10);
                Console.WriteLine("Dikdörtgen Çevre Alan Hesabı Menümüze Hoş Geldiniz...");
                System.Threading.Thread.Sleep(1000);

                Console.SetCursorPosition(28, 11);
                Console.Write("Dikdörtgenin kısakenarını giriniz: ");
                kısakenar = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(28, 12);
                Console.Write("Dikdörtgenin uzunkenarını giriniz: ");
                uzunkenar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                cevre2 = (kısakenar * 2) + (uzunkenar * 2);
                alan2 = kısakenar * uzunkenar;



                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(28, 14);
                Console.WriteLine("Dikdörtgeninizin Alanı: " + alan2);
                Console.SetCursorPosition(28, 15);
                Console.WriteLine("Dikdörtgeninizin Çevresi: " + cevre2);
                System.Threading.Thread.Sleep(2000);

                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(24, 20);
                Console.WriteLine("Beş Saniye Sonra Hesaplama Menüsüne Geri Döneceksiniz");
                Console.SetCursorPosition(47, 21);
                Console.WriteLine("-5-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 22);
                Console.WriteLine("-4-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 23);
                Console.WriteLine("-3-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 24);
                Console.WriteLine("-2-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 25);
                Console.WriteLine("-1-");
                System.Threading.Thread.Sleep(1000);
                goto enbas;
            }

            else if (islem == 6)
            {

                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(2, 35);
                Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄   ▄         ▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄ ");
                Console.SetCursorPosition(2, 36);
                Console.WriteLine("▐░░░░░░░░░░▌ ▐░▌       ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌");
                Console.SetCursorPosition(2, 37);
                Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌     ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
                Console.SetCursorPosition(2, 38);
                Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌       ▐░▌▐░▌          ▐░▌          ▐░▌▐░▌    ▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 39);
                Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄█░▌");
                Console.SetCursorPosition(2, 40);
                Console.WriteLine("▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌");
                Console.SetCursorPosition(2, 41);
                Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀      ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌   ▐░▌ ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
                Console.SetCursorPosition(2, 42);
                Console.WriteLine("▐░▌       ▐░▌     ▐░▌          ▐░▌     ▐░▌  ▐░▌          ▐░▌          ▐░▌    ▐░▌▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 43);
                Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌     ▐░▌          ▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌     ▐░▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 44);
                Console.WriteLine("▐░░░░░░░░░░▌      ▐░▌          ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 45);
                Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀        ▀            ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀         ▀ ");


                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                int kenaruzun, cevre3;

                Console.SetCursorPosition(28, 10);
                Console.WriteLine("Eşkenar Üçgen Çevre Hesabı Menümüze Hoş Geldiniz...");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(28, 11);
                Console.Write("Eşkenar Üçgeninizin bir kenar uzunluğunu giriniz: ");
                kenaruzun = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                cevre3 = kenaruzun * 3;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(28, 13);
                Console.Write("Eşkenar Üçgeninizin Çevresi: " + cevre3);
                System.Threading.Thread.Sleep(2000);

                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(24, 20);
                Console.WriteLine("Beş Saniye Sonra Hesaplama Menüsüne Geri Döneceksiniz");
                Console.SetCursorPosition(47, 21);
                Console.WriteLine("-5-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 22);
                Console.WriteLine("-4-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 23);
                Console.WriteLine("-3-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 24);
                Console.WriteLine("-2-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 25);
                Console.WriteLine("-1-");
                System.Threading.Thread.Sleep(1000);
                goto enbas;
            }

            else if (islem == 7)
            {

                Console.Clear();


                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(2, 35);
                Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄   ▄         ▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄ ");
                Console.SetCursorPosition(2, 36);
                Console.WriteLine("▐░░░░░░░░░░▌ ▐░▌       ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌");
                Console.SetCursorPosition(2, 37);
                Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌     ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
                Console.SetCursorPosition(2, 38);
                Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌       ▐░▌▐░▌          ▐░▌          ▐░▌▐░▌    ▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 39);
                Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄█░▌");
                Console.SetCursorPosition(2, 40);
                Console.WriteLine("▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌");
                Console.SetCursorPosition(2, 41);
                Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀      ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌   ▐░▌ ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
                Console.SetCursorPosition(2, 42);
                Console.WriteLine("▐░▌       ▐░▌     ▐░▌          ▐░▌     ▐░▌  ▐░▌          ▐░▌          ▐░▌    ▐░▌▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 43);
                Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌     ▐░▌          ▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌     ▐░▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 44);
                Console.WriteLine("▐░░░░░░░░░░▌      ▐░▌          ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 45);
                Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀        ▀            ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀         ▀ ");


                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;

                int fakt = 1;
                int sayi;
                Console.SetCursorPosition(28, 10);
                Console.WriteLine("Faktöriyel Hesaplama Menümüze Hoş Geldiniz...");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(28, 11);
                Console.Write("Faktöriyel Hesabı Yapılacak Olan Sayıyı Giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= sayi; i++)
                {
                    fakt = fakt * i;
                }


                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(28, 13);
                Console.Write("Sonuç: " + fakt);
                System.Threading.Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(24, 20);
                Console.WriteLine("Beş Saniye Sonra Hesaplama Menüsüne Geri Döneceksiniz");
                Console.SetCursorPosition(47, 21);
                Console.WriteLine("-5-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 22);
                Console.WriteLine("-4-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 23);
                Console.WriteLine("-3-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 24);
                Console.WriteLine("-2-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 25);
                Console.WriteLine("-1-");
                System.Threading.Thread.Sleep(1000);
                goto enbas;
            }

            else if (islem == 8)
            {
                Console.Clear();


                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(2, 35);
                Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄   ▄         ▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄ ");
                Console.SetCursorPosition(2, 36);
                Console.WriteLine("▐░░░░░░░░░░▌ ▐░▌       ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌");
                Console.SetCursorPosition(2, 37);
                Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌     ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
                Console.SetCursorPosition(2, 38);
                Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌       ▐░▌▐░▌          ▐░▌          ▐░▌▐░▌    ▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 39);
                Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄█░▌");
                Console.SetCursorPosition(2, 40);
                Console.WriteLine("▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌");
                Console.SetCursorPosition(2, 41);
                Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀      ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌   ▐░▌ ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
                Console.SetCursorPosition(2, 42);
                Console.WriteLine("▐░▌       ▐░▌     ▐░▌          ▐░▌     ▐░▌  ▐░▌          ▐░▌          ▐░▌    ▐░▌▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 43);
                Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌     ▐░▌          ▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌     ▐░▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 44);
                Console.WriteLine("▐░░░░░░░░░░▌      ▐░▌          ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 45);
                Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀        ▀            ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀         ▀ ");

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;


                int sayı1, sayı2;
                Console.SetCursorPosition(28, 10);
                Console.WriteLine("Bölünebilme İşlemi Menümüze Hoş Geldiniz...");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(28, 11);
                Console.Write("Bölünmesini sorulayacağınız sayıyı giriniz :");
                sayı1 = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(28, 12);
                Console.Write("Bölünebileceği sayıyı giriniz  :");
                sayı2 = int.Parse(Console.ReadLine());


                if (sayı1 % sayı2 == 0)
                {
                    Console.SetCursorPosition(28, 14);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Sayılar tam bölnebiliyor...");
                    System.Threading.Thread.Sleep(1000);
                }

                else
                {
                    Console.SetCursorPosition(28, 14);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Sayılar tam bölünemiyor...\n");
                    System.Threading.Thread.Sleep(1000);

                }



                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(24, 20);
                Console.WriteLine("Beş Saniye Sonra Hesaplama Menüsüne Geri Döneceksiniz");
                Console.SetCursorPosition(47, 21);
                Console.WriteLine("-5-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 22);
                Console.WriteLine("-4-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 23);
                Console.WriteLine("-3-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 24);
                Console.WriteLine("-2-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 25);
                Console.WriteLine("-1-");
                System.Threading.Thread.Sleep(1000);
                goto enbas;



            }


            else if (islem == 9)
            {


                Console.Clear();


                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(2, 35);
                Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄   ▄         ▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄ ");
                Console.SetCursorPosition(2, 36);
                Console.WriteLine("▐░░░░░░░░░░▌ ▐░▌       ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌");
                Console.SetCursorPosition(2, 37);
                Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌     ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
                Console.SetCursorPosition(2, 38);
                Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌       ▐░▌▐░▌          ▐░▌          ▐░▌▐░▌    ▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 39);
                Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄█░▌");
                Console.SetCursorPosition(2, 40);
                Console.WriteLine("▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌");
                Console.SetCursorPosition(2, 41);
                Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀      ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌   ▐░▌ ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
                Console.SetCursorPosition(2, 42);
                Console.WriteLine("▐░▌       ▐░▌     ▐░▌          ▐░▌     ▐░▌  ▐░▌          ▐░▌          ▐░▌    ▐░▌▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 43);
                Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌     ▐░▌          ▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌     ▐░▐░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 44);
                Console.WriteLine("▐░░░░░░░░░░▌      ▐░▌          ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░▌       ▐░▌");
                Console.SetCursorPosition(2, 45);
                Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀        ▀            ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀         ▀ ");

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(30, 20);
                Console.WriteLine("Bir Önceki Sayfaya Aktarılıyorsunuz.");
                Console.SetCursorPosition(47, 21);
                Console.WriteLine("-5-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 22);
                Console.WriteLine("-4-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 23);
                Console.WriteLine("-3-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 24);
                Console.WriteLine("-2-");
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(47, 25);
                Console.WriteLine("-1-");
                System.Threading.Thread.Sleep(1000);

                Secim();
            }

            else
            {
                goto enbas;
            }

        }
        public static void SayıBulma()
        {
            oyun:
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 35);
            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄   ▄         ▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄ ");
            Console.SetCursorPosition(2, 36);
            Console.WriteLine("▐░░░░░░░░░░▌ ▐░▌       ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌");
            Console.SetCursorPosition(2, 37);
            Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌     ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
            Console.SetCursorPosition(2, 38);
            Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌       ▐░▌▐░▌          ▐░▌          ▐░▌▐░▌    ▐░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 39);
            Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄█░▌");
            Console.SetCursorPosition(2, 40);
            Console.WriteLine("▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌");
            Console.SetCursorPosition(2, 41);
            Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀      ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌   ▐░▌ ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
            Console.SetCursorPosition(2, 42);
            Console.WriteLine("▐░▌       ▐░▌     ▐░▌          ▐░▌     ▐░▌  ▐░▌          ▐░▌          ▐░▌    ▐░▌▐░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 43);
            Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌     ▐░▌          ▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌     ▐░▐░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 44);
            Console.WriteLine("▐░░░░░░░░░░▌      ▐░▌          ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 45);
            Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀        ▀            ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀         ▀ ");

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;

            int oyunsayi, oyunsayi2;
            Console.SetCursorPosition(28, 3);
            Console.WriteLine("Sayı Bulma Oyunumuza Hoş Geldiniz.");
            System.Threading.Thread.Sleep(2000);

            Random rnd = new Random();
            oyunsayi2 = rnd.Next(1, 6);

            Console.SetCursorPosition(28, 5);
            Console.Write("1-5 Arasında Tutulan Sayıyı Tahmin Et: ");
            oyunsayi = int.Parse(Console.ReadLine());

            if(oyunsayi==oyunsayi2)
            {

                Console.WriteLine("Bildin!!!\n");

                Console.WriteLine("     ▄▄▄▄▀▀▀▀▀▀▀▀▄▄▄▄▄▄");
                Console.WriteLine("░░░░█░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░▀▀▄        ");
                Console.WriteLine("░░░█░░░▒▒▒▒▒▒░░░░░░░░▒▒▒░░█       ");
                Console.WriteLine("░░█░░░░░░▄██▀▄▄░░░░░▄▄▄░░░█       ");
                Console.WriteLine("░▀▒▄▄   █▀▀▀▀▄▄█░░░██▄▄█░░░█      ");
                Console.WriteLine("█▒█▒▄░▀▄▄▄▀░░░░░░░░█░░░▒▒▒▒▒█     ");
                Console.WriteLine("█▒█░█▀▄▄░░░░░█▀░░░░▀▄░░▄▀▀▀▄▒█    ");
                Console.WriteLine("░█▀▄░█▄░█▀▄▄░▀░▀▀░▄▄▀░░░░█░░█     ");
                Console.WriteLine("░░█░░▀▄▀█▄▄░█▀▀▀▄▄▄▄▀▀█▀██░█      ");
                Console.WriteLine("░░░█░░██░░▀█▄▄▄█▄▄█▄████░█        ");
                Console.WriteLine("░░░░█░░░▀▀▄░█░░░█░███████░█       ");
                Console.WriteLine("░░░░░▀▄░░░▀▀▄▄▄█▄█▄█▄█▄▀░░█       ");
                Console.WriteLine("░░░░░░░▀▄▄░▒▒▒▒░░░░░░░░░░█        ");
                Console.WriteLine("░░░░░░░░░░▀▀▄▄░▒▒▒▒▒▒▒▒▒▒░█       ");
                Console.WriteLine("░░░░░░░░░░░░░░▀▄▄▄▄▄░░░░░█        ");


                Console.SetCursorPosition(35, 10);
                Console.WriteLine("                                   ");
                Console.SetCursorPosition(35, 11);
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   ");
                Console.SetCursorPosition(35, 12);
                Console.WriteLine("░░░░░░░░████░░░░░░████░░░░░░░░░░   ");
                Console.SetCursorPosition(35, 13);
                Console.WriteLine("░░░░░░████████░░████████░░░░░░░░   ");
                Console.SetCursorPosition(35, 14);
                Console.WriteLine("░░░░██████████░░██████████░░░░░░   ");
                Console.SetCursorPosition(35, 15);
                Console.WriteLine("░░░░██████████████████████░░░░░░   ");
                Console.SetCursorPosition(35, 16);
                Console.WriteLine("░░░░██████████████████████░░░░░░   ");
                Console.SetCursorPosition(35, 17);
                Console.WriteLine("░░░░░░██████████████████░░░░░░░░   ");
                Console.SetCursorPosition(35, 18);
                Console.WriteLine("░░░░░░░░██████████████░░░░░░░░░░   ");
                Console.SetCursorPosition(35, 19);
                Console.WriteLine("░░░░░░░░░░██████████░░░░░░░░░░░░   ");
                Console.SetCursorPosition(35, 20);
                Console.WriteLine("░░░░░░░░░░░░██████░░░░░░░░░░░░░░   ");
                Console.SetCursorPosition(35, 21);
                Console.WriteLine("░░░░░░░░░░░░░░██░░░░░░░░░░░░░░░░   ");

            }

            else if(oyunsayi!=oyunsayi2)
            {

                 




                Console.WriteLine("Bilemedin!!!\n");

                Console.WriteLine("             ((((((     ");
                Console.WriteLine("           ((::::::(    ");
                Console.WriteLine("         ((:::::::(     ");
                Console.WriteLine("        (:::::::((      ");
                Console.WriteLine("        (::::::(        ");
                Console.WriteLine(" :::::: (:::::(         ");
                Console.WriteLine(" :::::: (:::::(         ");
                Console.WriteLine(" :::::: (:::::(         ");
                Console.WriteLine("        (:::::(         ");
                Console.WriteLine("        (:::::(         ");
                Console.WriteLine("        (:::::(         ");
                Console.WriteLine(" :::::: (::::::(        ");
                Console.WriteLine(" :::::: (:::::::((      ");
                Console.WriteLine(" ::::::  ((:::::::(     ");
                Console.WriteLine("           ((::::::(    ");
                Console.WriteLine("             ((((((     ");


                
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Yeniden denemek için 'd', başa dönmek için enter tuşuna basınız...");
            if (Console.ReadLine() == "d")
                goto oyun;

        }
        public static void Keyword()
        {
            
            keyword:
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 35);
            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄   ▄         ▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄ ");
            Console.SetCursorPosition(2, 36);
            Console.WriteLine("▐░░░░░░░░░░▌ ▐░▌       ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌");
            Console.SetCursorPosition(2, 37);
            Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌     ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
            Console.SetCursorPosition(2, 38);
            Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌       ▐░▌▐░▌          ▐░▌          ▐░▌▐░▌    ▐░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 39);
            Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄█░▌");
            Console.SetCursorPosition(2, 40);
            Console.WriteLine("▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌");
            Console.SetCursorPosition(2, 41);
            Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀      ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌   ▐░▌ ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
            Console.SetCursorPosition(2, 42);
            Console.WriteLine("▐░▌       ▐░▌     ▐░▌          ▐░▌     ▐░▌  ▐░▌          ▐░▌          ▐░▌    ▐░▌▐░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 43);
            Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌     ▐░▌          ▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌     ▐░▐░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 44);
            Console.WriteLine("▐░░░░░░░░░░▌      ▐░▌          ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 45);
            Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀        ▀            ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀         ▀ ");

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;

            Random rnd2 = new Random();
            int basamak, sayisifre;
            Console.SetCursorPosition(28, 5);
            Console.WriteLine("Şifre Oluşturma Menümüze Hoş Geldiniz.");
            System.Threading.Thread.Sleep(2000);

            Console.SetCursorPosition(28, 7);
            Console.Write("Şifrenizin Basamak Sayısını Giriniz: ");
            basamak = int.Parse(Console.ReadLine());
           
            Console.SetCursorPosition(28, 8);
            Console.Write("Kaç Şifre Oluşturulacağını Giriniz: ");
            sayisifre = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(28, 9);
            Console.Write("Oluşturulacak Olan Dosyanın İsmini Yazınız: ");
            string dosyaadı = Console.ReadLine();

            string dosya = @"..\..\" + dosyaadı + ".txt";
            FileStream fs1 = new FileStream(dosya, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs1);

            Console.SetCursorPosition(28, 10);
            Console.Write("=>Büyük harfleri kullanmak için '1'e");
            Console.SetCursorPosition(28, 11);
            Console.WriteLine("=>Küçük harfleri kullanmak için'2'ye");
            Console.SetCursorPosition(28, 12);
            Console.Write("Rakamları kullanmak için '3'e basınız: ");
            string tür = Console.ReadLine();

            if (tür=="1")
            {

                for(int i=0;i<= sayisifre;i++)
                {
                    for(int a=0;a<basamak;a++)
                    {
                        int sayı = rnd2.Next(65, 91);
                        sw.Write((char)sayı);
                    }
                    sw.WriteLine("");
                }

                sw.Close();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(28, 15);
                Console.WriteLine("Dosyanız Ana Dizinde Oluşturuldu.");

                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(28, 17);
                Console.Write("=>Yeni şifre doyası oluşturmak ister misiniz..?(e/h): ");
                string onay = Console.ReadLine();

                if (onay == "e" || onay == "E")
                {
                    goto keyword;
                }

                else
                {
                    Secim();
                }
                

            }

            else if ( tür=="2")
            {
                for (int i = 0; i <= sayisifre; i++)
                {
                    for (int a = 0; a < basamak; a++)
                    {
                        int sayı = rnd2.Next(97, 123);
                        sw.Write((char)sayı);

                    }
                    sw.WriteLine("");
                }

                sw.Close();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(28, 15);
                Console.WriteLine("Dosyanız Ana Dizinde Oluşturuldu.");

                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(28, 17);
                Console.Write("=>Yeni şifre doyası oluşturmak ister misiniz..?(e/h): ");
                string onay = Console.ReadLine();

                if (onay == "e" || onay == "E")
                {
                    goto keyword;
                }

                else
                {
                    Secim();
                }
            }

            else if (tür=="3")
            {

                for (int i = 0; i <= sayisifre; i++)
                {
                    for (int a = 0; a < basamak; a++)
                    {
                        int sayı = rnd2.Next(0, 10);
                        sw.Write(sayı);

                    }
                    sw.WriteLine("");
                }

                sw.Close();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(28, 15);
                Console.WriteLine("Dosyanız Ana Dizinde Oluşturuldu.");

                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(28, 17);
                Console.Write("=>Yeni şifre doyası oluşturmak ister misiniz..?(e/h): ");
                string onay = Console.ReadLine();

                if (onay == "e" || onay == "E")
                {
                    goto keyword;
                }

                else
                {
                    Secim();
                }

            }

            else
            {
                Secim();
            }


        }
        public static void KullanıcıGirisi()
        {

        kullanıcı:

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;


            Console.SetCursorPosition(2, 35);
            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄   ▄         ▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄ ");
            Console.SetCursorPosition(2, 36);
            Console.WriteLine("▐░░░░░░░░░░▌ ▐░▌       ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌");
            Console.SetCursorPosition(2, 37);
            Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌     ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
            Console.SetCursorPosition(2, 38);
            Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌       ▐░▌▐░▌          ▐░▌          ▐░▌▐░▌    ▐░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 39);
            Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄█░▌");
            Console.SetCursorPosition(2, 40);
            Console.WriteLine("▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌");
            Console.SetCursorPosition(2, 41);
            Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀      ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌   ▐░▌ ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
            Console.SetCursorPosition(2, 42);
            Console.WriteLine("▐░▌       ▐░▌     ▐░▌          ▐░▌     ▐░▌  ▐░▌          ▐░▌          ▐░▌    ▐░▌▐░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 43);
            Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌     ▐░▌          ▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌     ▐░▐░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 44);
            Console.WriteLine("▐░░░░░░░░░░▌      ▐░▌          ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 45);
            Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀        ▀            ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀         ▀ ");







            string ad, sifre;

            Console.SetCursorPosition(28, 10);
            Console.Write("Lütfen Kullanıcı Adınızı Giriniz: ");
            ad = Console.ReadLine();
            Console.SetCursorPosition(28, 11);
            Console.Write("Lütfen Şifrenizi Giriniz: ");
            sifre = Console.ReadLine();
            Console.WriteLine("\n\n");

            if (ad == "Reena" && sifre == "Oguzhan1907")
            {

                Console.WriteLine("Giriş Başarılı...\n");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("3 Saniye Sonra Anasayfaya Aktarılacaksınız...");

                Console.SetCursorPosition(20, 19);
                Console.WriteLine("-3-");
                System.Threading.Thread.Sleep(1000);

                Console.SetCursorPosition(20, 20);
                Console.WriteLine("-2-");
                System.Threading.Thread.Sleep(1000);

                Console.SetCursorPosition(20, 21);
                Console.WriteLine("-1-");
                System.Threading.Thread.Sleep(1000);

                Secim();
            }
            else
            {
                Console.WriteLine("Girmiş Olduğunuz Kullanıcı Adı veya Şifre Hatalı...");
                Console.Clear();
                goto kullanıcı;
            }

            
        }
        public static void Secim()
        {
        secim:

            string secim;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(28, 10);
            Console.WriteLine("-1- Not Ortalama Makinesi");
            Console.SetCursorPosition(28, 11);
            Console.WriteLine("-2- Hesap Makinesi");
            Console.SetCursorPosition(28, 12);
            Console.WriteLine("-3- Sayı Bulma Oyunu");
            Console.SetCursorPosition(28, 13);
            Console.WriteLine("-4- Keyword Şifre Oluşturma\n");
            Console.SetCursorPosition(28, 14);
            Console.WriteLine("-5- Kullanıcı Sayfasına Geri Dön\n");


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            

            Console.SetCursorPosition(2, 35);
            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄   ▄         ▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄ ");
            Console.SetCursorPosition(2, 36);
            Console.WriteLine("▐░░░░░░░░░░▌ ▐░▌       ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌");
            Console.SetCursorPosition(2, 37);
            Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌     ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
            Console.SetCursorPosition(2, 38);
            Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌       ▐░▌▐░▌          ▐░▌          ▐░▌▐░▌    ▐░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 39);
            Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄█░▌");
            Console.SetCursorPosition(2, 40);
            Console.WriteLine("▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌");
            Console.SetCursorPosition(2, 41);
            Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀      ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌   ▐░▌ ▐░▌▐░█▀▀▀▀▀▀▀█░▌");
            Console.SetCursorPosition(2, 42);
            Console.WriteLine("▐░▌       ▐░▌     ▐░▌          ▐░▌     ▐░▌  ▐░▌          ▐░▌          ▐░▌    ▐░▌▐░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 43);
            Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌     ▐░▌          ▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌     ▐░▐░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 44);
            Console.WriteLine("▐░░░░░░░░░░▌      ▐░▌          ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░▌       ▐░▌");
            Console.SetCursorPosition(2, 45);
            Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀        ▀            ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀         ▀ ");

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(0, 18);
            Console.Write("\n Seçim Yapınız: ");
            secim = Console.ReadLine();


            if (secim == "1")
            {

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;

                OrtalamaMakinesi();

                System.Threading.Thread.Sleep(10000);
                goto secim;


            }
            else if (secim == "2")
            {

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;

                HesapMakinesi();




            }

            else if (secim == "3")
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;

                SayıBulma();
            }
            else if(secim =="4")
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;

                Keyword();

            }

            else if (secim == "5")
            {
                Console.SetCursorPosition(28, 25);
                Console.Write("Kullanıcı Sayfasına Yönlendiriliyorsunuz...");

                Console.SetCursorPosition(45, 26);
                Console.WriteLine("-3-");
                System.Threading.Thread.Sleep(1000);

                Console.SetCursorPosition(45, 27);
                Console.WriteLine("-2-");
                System.Threading.Thread.Sleep(1000);

                Console.SetCursorPosition(45, 28);
                Console.WriteLine("-1-");
                System.Threading.Thread.Sleep(1000);

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                KullanıcıGirisi();
            }

            goto secim;

            Console.Read();
        }
    }

}
