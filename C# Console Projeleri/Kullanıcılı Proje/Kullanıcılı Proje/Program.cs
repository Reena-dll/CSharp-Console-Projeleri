using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Media;


namespace Kullanıcılı_Proje
{
    class Program
    {
        private static void OrtalamaMakinesi()
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
            if(ihtimal>2)
            {
                goto bas;
            }
         
            Console.SetCursorPosition(28, 12);
            Console.Write("Bir Vizenizin Dönem Notu Puanına Etkileyecek %'si Kaç: ");
            yuzde = Convert.ToInt16(Console.ReadLine());
            if(yuzde>51)
            {
                goto bas;
            }

            if(ihtimal==1)
            {

                int v1ze, f1nal, ortalama ;
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(28, 13);
                Console.Write("Vize'den aldığınız notu giriniz: ");
                v1ze = Convert.ToInt16(Console.ReadLine());
                if(v1ze>100)
                {
                    goto bas;
                }
               
                iht1mal:

                Console.SetCursorPosition(28, 14);
                Console.Write("Finalden Aldığınız Notu Giriniz: ");
                f1nal = Convert.ToInt16(Console.ReadLine());
                if(f1nal>100)
                {
                    goto bas;
                }

                v1ze = (v1ze * yuzde)/100;
                f1nal = (f1nal * (100 - yuzde) / 100);
                ortalama = v1ze + f1nal;
                if(ortalama>100)
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

            else if (ihtimal==2)
            {

                int v2ze,v2ze2, f2nal, ortalama2;

                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(28, 13);
                Console.Write("Birinci vizeden aldığınız notu giriniz: ");
                v2ze = Convert.ToInt16(Console.ReadLine());
                 if(v2ze>100)
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
                f2nal = (f2nal * (100 - (yuzde*2))) / 100;
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



                else if(ortalama2>=50)
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

        static void Main(string[] args)
        {
            Console.Title = "Reena Program";


            
            string yol = @"C:\Users\Reena\Downloads\Music\Hacker Müziği - Hacker Şarkısı - Hacked Müzigi - Hacker Müzihi - Hacker By - Hacker Music - YouTube (online-audio-converter.com).wav";
            

          
           
           
           



            Console.SetWindowSize(100, 50);
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



           



            string ad, sifre, secim;
            
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

                goto secim;
            }
            else
            {
                Console.WriteLine("Girmiş Olduğunuz Kullanıcı Adı veya Şifre Hatalı...");
                Console.Clear();
                goto kullanıcı;
            }

        secim:


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
            Console.WriteLine("-4- Bölünebilme İşlemi");
            Console.SetCursorPosition(28, 14);
            Console.WriteLine("-5- Faktöriyel Hesabı");
            Console.SetCursorPosition(28, 15);
            Console.WriteLine("-6- Kullanıcı Sayfasına Geri Dön\n");

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


            if (secim=="1")
            {

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();         
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
               
                OrtalamaMakinesi();

                System.Threading.Thread.Sleep(10000);
                goto secim;


            }
            else if(secim=="6")
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
                goto kullanıcı;
            }

            Console.Read();
        }
    }
}
