using System;

namespace Bilgi_Yarışması_Oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************************");
            Console.WriteLine();
            Console.WriteLine("Yarışmaya Hoş Geldiniz");
            Console.Title = "Bilgi Yarışması";
            Console.CursorVisible = false;  // İmleçi konsol ekranında göstermez. 
            Console.SetWindowSize(200, 50);  // Ekran boyutunu ayarlar.






            Console.SetCursorPosition(92, 17);
            Console.WriteLine("╔╗ ╦ ╦  ╦═╗╔═╗╔═╗╦ ╦╦    ╔═╗╔═╗╔╦╗╦╦╔═╔═╗╔═╗╦  ╦ ╦");
            Console.SetCursorPosition(92, 18);
            Console.WriteLine("╠╩╗╚╦╝  ╠╦╝║╣ ╚═╗║ ║║    ╚═╗╠═╣ ║║║╠╩╗║ ║║ ╦║  ║ ║");
            Console.SetCursorPosition(92, 19);
            Console.WriteLine("╚═╝ ╩   ╩╚═╚═╝╚═╝╚═╝╩═╝  ╚═╝╩ ╩═╩╝╩╩ ╩╚═╝╚═╝╩═╝╚═╝");


            String ad, soyad;

            Console.Write("İsminizi Giriniz: ");
            ad =Convert.ToString(Console.ReadLine());
            Console.Write("Soyadınızı Giriniz: ");
            soyad = Convert.ToString(Console.ReadLine());

            
            Console.SetCursorPosition(92, 17);
            Console.WriteLine("╔╗ ╦ ╦  ╦═╗╔═╗╔═╗╦ ╦╦    ╔═╗╔═╗╔╦╗╦╦╔═╔═╗╔═╗╦  ╦ ╦");
            Console.SetCursorPosition(92, 18);
            Console.WriteLine("╠╩╗╚╦╝  ╠╦╝║╣ ╚═╗║ ║║    ╚═╗╠═╣ ║║║╠╩╗║ ║║ ╦║  ║ ║");
            Console.SetCursorPosition(92, 19);
            Console.WriteLine("╚═╝ ╩   ╩╚═╚═╝╚═╝╚═╝╩═╝  ╚═╝╩ ╩═╩╝╩╩ ╩╚═╝╚═╝╩═╝╚═╝");


            Console.WriteLine("Başlıyoruz Enter tuşuna basınız...");
            Console.WriteLine("Her yanıttan sonra ENTER tuşuna basmayı unutmayın...");
            Console.ReadLine();


            int dogru, yanlis, para;
            dogru = 0;
            yanlis = 0;
            para = 0;

            Console.WriteLine("Soru -1-");
            Console.WriteLine("Cumhuriyet Kaç Yılında İlan Edilmiştir ?");            
            char c1;
            Console.Write(" A-1920\n B-1923 \n C-1924\n D-1926\n \n Cevabınız: ");
            c1 = Convert.ToChar(Console.ReadLine());
            if(c1=='B' || c1=='b')
            {
                dogru = dogru + 1;
                para = para + 1000;
                Console.WriteLine("Tebrikler Cevap Doğru, Enter Tuşuna Basın");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Maalesef Cevap Yanlış, Enter Tuşuna Basın");
                Console.ReadLine();
            }

            
            Console.WriteLine("Soru -2-");
            Console.WriteLine("Türkiyenin Başkenti Hangi Şehirdir? ");
            char c2;
            Console.Write(" A-İstanbul\n B-Konya \n C-Ankara\n D-Samsun \n \n Cevabınız: ");
            c2 = Convert.ToChar(Console.ReadLine());
            if(c2=='C' || c2=='c')
            {
                dogru = dogru + 1;
                para = para + 1000;
                Console.Write("Tebrikler Cevap Doğru, Enter Tuşuna Basın");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.Write("Maalesef Cevap Yanlış, Enter Tuşuna Basın");
                    Console.ReadLine();
            }

            Console.WriteLine();
            
            Console.WriteLine("Soru -3-");
            Console.WriteLine("Maki Hangi Bölgenin Bitki Örtüsüdür?");
            char c3;
            Console.Write(" A-Akdeniz\n B-Ege\n C-Marmara \n D- Karadeniz \n \n Cevabınız: ");
            c3 = Convert.ToChar(Console.ReadLine());

            if(c3=='A'|| c3=='a')
            {
                dogru = dogru + 1;
                para = para + 1000;
                Console.Write("Tebrikler Cevap Doğru, Enter Tuşuna Basın");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.Write("Maalesef Cevap Yanlış, Enter Tuşuna Basın");
                Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("Soru -4-");
            Console.WriteLine(" 8 Bit değeri kaç Byte'dır?");
            char c4;
            Console.Write(" A-5\n B-1\n C-100 \n D- 8 \n \n Cevabınız: ");
            c4 = Convert.ToChar(Console.ReadLine());

            if (c4 == 'B' || c4 == 'b')
            {
                dogru = dogru + 1;
                para = para + 1000;
                Console.Write("Tebrikler Cevap Doğru, Enter Tuşuna Basın");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.Write("Maalesef Cevap Yanlış, Enter Tuşuna Basın");
                Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("Soru -5-");
            Console.WriteLine("Matematiksel İşlemler Yapılamayan Değişken Türü Hangisidir?");

            char c5;
            Console.Write(" A-İnt\n B-Double\n C-Decimal \n D-String \n \n Cevabınız: ");
            c5 = Convert.ToChar(Console.ReadLine());

            if (c5 == 'D' || c5 == 'd')
            {
                dogru = dogru + 1;
                para = para + 1000;
                Console.Write("Tebrikler Cevap Doğru, Enter Tuşuna Basın");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.Write("Maalesef Cevap Yanlış, Enter Tuşuna Basın");
                Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("Soru -6-");
            Console.WriteLine("Hangisi Programlamanın Temel Renklerinden Değildir ?");

            char c6;
            Console.Write(" A-Mavi\n B-Yeşil\n C-Kırmızı \n D- Sarı \n \n Cevabınız: ");
            c6 = Convert.ToChar(Console.ReadLine());

            if (c6 == 'D' || c6 == 'd')
            {
                dogru = dogru + 1;
                para = para + 1000;
                Console.Write("Tebrikler Cevap Doğru, Enter Tuşuna Basın");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.Write("Maalesef Cevap Yanlış, Enter Tuşuna Basın");
                Console.ReadLine();
            }

            Console.WriteLine();
            
            Console.WriteLine("Soru -7-");
            Console.WriteLine("Avrupa'nın Kullandığı Ortak Parak Birimi");
            char c7;
            Console.Write(" A-Dolar\n B-Euro\n C-Zloty \n D- Ruble \n \n Cevabınız: ");
            c7 = Convert.ToChar(Console.ReadLine());

            if (c7 == 'B' || c7 == 'b')
            {
                dogru = dogru + 1;
                para = para + 1000;
                Console.Write("Tebrikler Cevap Doğru, Enter Tuşuna Basın");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.Write("Maalesef Cevap Yanlış, Enter Tuşuna Basın");
                Console.ReadLine();
            }

            Console.WriteLine();


            Console.WriteLine("Soru -8-");
            Console.WriteLine("Hangi İlimiz Ege Bölgesinde Değildir?");
            char c8;
            Console.Write(" A-İzmir\n B-Muğla\n C-Edirne \n D- Aydın \n \n Cevabınız: ");
            c8 = Convert.ToChar(Console.ReadLine());

            if (c8 == 'C' || c8 == 'c')
            {
                dogru = dogru + 1;
                para = para + 1000;
                Console.Write("Tebrikler Cevap Doğru, Enter Tuşuna Basın");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.Write("Maalesef Cevap Yanlış, Enter Tuşuna Basın");
                Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("Soru -9-");
            Console.WriteLine("Sefiller Kitabının Yazarı Kimdir");
            char c9;
            Console.Write(" A-Jules Verne\n B-Gogol\n C-Tolstoy \n D- Victor Hugo \n \n Cevabınız: ");
            c9 = Convert.ToChar(Console.ReadLine());

            if (c9 == 'D' || c9 == 'd')
            {
                dogru = dogru + 1;
                para = para + 1000;
                Console.Write("Tebrikler Cevap Doğru, Enter Tuşuna Basın");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.Write("Maalesef Cevap Yanlış, Enter Tuşuna Basın");
                Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("Soru -10-");
            Console.WriteLine("Mustafa Kemal Atatürk'ün Nifusa Kayıtlı Olduğu İl Hangisidir?");
            char c10;
            Console.Write(" A-İstanbul\n B-Ankara\n C-İzmir \n D- Gaziantep \n \n Cevabınız: ");
            c10 = Convert.ToChar(Console.ReadLine());

            if (c10 == 'D' || c10 == 'd')
            {
                dogru = dogru + 1;
                para = para + 1000;
                Console.Write("Tebrikler Cevap Doğru, Enter Tuşuna Basın");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.Write("Maalesef Cevap Yanlış, Enter Tuşuna Basın");
                Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("Adınız: " + ad);
            Console.WriteLine("Soyadınız: " + soyad);
            Console.WriteLine("Doğru Sayısı: " + dogru);
            Console.WriteLine("Yanlış Sayısı: " + yanlis);
            Console.WriteLine("Toplam Kazandığınız Para: " + para+" TL");
            Console.WriteLine("OYUN BİTTİ...");
            Console.Read();
        }
    }
}
