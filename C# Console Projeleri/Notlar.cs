
// Console.WriteLine("                       ╔╗ ╦ ╦  ╦═╗╔═╗╔═╗╦ ╦╦    ╔═╗╔═╗╔╦╗╦╦╔═╔═╗╔═╗╦  ╦ ╦");
// Console.WriteLine("                       ╠╩╗╚╦╝  ╠╦╝║╣ ╚═╗║ ║║    ╚═╗╠═╣ ║║║╠╩╗║ ║║ ╦║  ║ ║");
// Console.WriteLine("                       ╚═╝ ╩   ╩╚═╚═╝╚═╝╚═╝╩═╝  ╚═╝╩ ╩═╩╝╩╩ ╩╚═╝╚═╝╩═╝╚═╝");


// byte    1 bayt  0, ..., 255(tam sayı)                                                    byte a = 5;
// sbyte   1 bayt - 128, ..., 127(tam sayı)                                                 sbyte a = 5;
// short   2 bayt - 32768, ..., 32767(tam sayı)                                             short a = 5;
// ushort  2 bayt  0, ..., 65535(tam sayı)                                                  ushort a = 5;
// int 4 bayt - 2147483648, ..., 2147483647(tam sayı)                                       int a = 5;
// uint    4 bayt  0, ..., 4294967295(tam sayı)                                             uint a = 5;
// long    8 bayt - 9223372036854775808, ..., 9223372036854775807(tam sayı)                 long a = 5;
// ulong   8 bayt  0, ..., 18446744073709551615(tam sayı) ulong a = 5;
// float   4 bayt  ±1.5 * 10 - 45, ..., ±3.4 * 1038(reel sayı)                              float a = 5F; veya float a = 5f;
// double  8 bayt  ±5.0 * 10 - 324, ..., ±1.7 * 10308(reel sayı)                            double a = 5; veya double a = 5d; veya double a = 5D;
// decimal 16 bayt ±1.5 * 10 - 28, ..., ±7.9 * 1028(reel sayı)                              decimal a = 5M; veya decimal a = 5m; decimal a,b;

// Math. işlemleri
// Abs(x)  Bir sayının mutlak değerini tutar.
// Cos(x)	Bir sayının kosinüsünü tutar.
// Sin(x)  Bir sayının sinüsünü tutar.
// Tan(x)  Bir sayının tanjantını tutar.
// Ceiling(x)  x sayısından büyük en küçük tam sayıyı tutar(yukarı yuvarlama).
// Floor(x)    x sayısından küçük en büyük tam sayıyı tutar(aşağı yuvarlama).
// Max(x, y)    x ve y sayılarının en büyüğünü tutar.
// Min(x,y)	x ve y sayılarının en küçüğünü tutar.
// Pow(x,y)	x üzeri y'yi tutar.
// Sqrt(x) x'in karekökünü tutar.
// Log(x)  x sayısının e tabanında logaritmasını tutar.
// Exp(x)  e üzeri x'in değerini tutar.
// Log10(x)    x sayısının 10 tabanındaki logaritmasını tutar.


// Birinci öncelikliler    x++, x--
// Tek operand alan operatörler    +, -, !, ~, ++x, --x, (Tür)x
// Çarpma ve bölme *, /, %
// Toplama ve çıkarma	+, -
// Kaydırma operatörleri   <<, >>
// İlişkisel ve tür testi operatörleri<,>, <=, >=, is, as
// Eşitlik operatörü   ==, !=
// Bitsel Ve(AND) &
// Bitsel Özel Veya(XOR)  ^
// Bitsel Veya(OR)    |
// Mantıksal Ve    &&
// Mantıksal Veya  ||
// Koşul operatörü ?:
// Atama ve işlemli atama operatörleri	=, *=, /=, %=, +=, -=, <<=, >>=, &=, ^=, |=



// DateTime dt = DateTime.Now;
// Console.WriteLine("{0:D}", dt);
// d--> 04.01.2009
// D--> 04 Ocak 2009 Pazar
// 
// t--> 16:25
// T--> 16:25:50
// 
// f--> 04 Ocak 2009 Pazar 16:25
// F--> 04 Ocak 2009 Pazar 16:25:50
// 
// g--> 04.01.2009 16:25
// G--> 04.01.2009 16:25:50
// 
// m--> 04 Ocak
// M--> 04 Ocak
// 
// r--> Sun, 04 Jan 2009 16:25:50 GMT
// R--> Sun, 04 Jan 2009 16:25:50 GMT
// 
// s--> 2009-01-04T16:25:50
// 
// u--> 2009-01-04 16:25:50Z
// U--> 04 Ocak 2009 Pazar 14:25:50
// 
// y--> Ocak 2009
// Y--> Ocak 2009


// System.Diagnostics.Process.Start(Environment.GetCommandLineArgs()[0]);                   Programı baştan açma.
// Environment.Exit(0);                                                                     Programı kapatma.

// Console.BackgroundColor = ConsoleColor.DarkGray;                                         Renk değiştirme
// Console.Clear();
// Console.ForegroundColor = ConsoleColor.White;

// System.Threading.Thread.Sleep(300);                                                       Akışı zamanlama

// goto kullanıcı;                                                                          Konuma git

// if (ad == "Resul" && şifre == "12345")                                                   VE && ||VEYA

// Random rnd = new Random();                                                               Random sayı seçme
// sayı = rnd.Next(1, 5);

// BİRDEN FAZLA YERE YAZMA SHİFT+ALT MOUSE

// if (sayı1%sayı2==0)                                                                      MOD alma

// Console.Title = "Denemeler";                                                             Konsol başlığı

// Console.SetCursorPosition(10, 7);                                                        İmlecin yerini ayarlama

// Console.SetWindowSize(70, 35);                                                           Ekran boyutu ayarlama

// string[,] dizi = new string[yük+1,gen+1];                                                Dizi oluşturma

// Console.WriteLine(DateTime.Now);                                                         Zaman kodu

// string b = a.Replace("A", "B");                                                          Metin değiştirme

// string b = a.ToUpper();                                                                  Yazıları büyültür
// string b = a.ToLower();                                                                  Yazıları küçültür.

// Trim()                                                                                   Metinin sağ sol boşluklarını siler

// string dosya = @"E:\deneme.txt";                                                         Metin Belgesine yazı yazdırma
// FileStream fs1 = new FileStream(dosya, FileMode.OpenOrCreate);
// StreamWriter bw = new StreamWriter(fs1);
// sw.WriteLine("Metin");
// BinaryWrite

// Console.CursorVisible = false;                                                           İmleç gizleme

// Console.WriteLine("{0:#,###}",12341445);                                                 12.341.445
// Console.WriteLine("{0:#.##}",31.44425);                                                  31,44
// Console.WriteLine("{0:#,###E+0}",13143212);                                              1.314E+4                                       
// Console.WriteLine("{0:#%}",0.25);                                                        25%                                   
                                                              


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication2
{
    class İlkProgramlar
    {
        public void Main(string[] args)
        {

            Console.Title = "İlkProgramlar";


            denemeyeni();

            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;






            string ad, şifre, seçim;





            Console.WriteLine("                             ____ ____ ____ ____ ____ ____ ____ ____ ____ ____ ____ ");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("                            ||U |||Y |||G |||U |||L |||A |||M |||A |||L |||A |||R ||");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("                            ||__|||__|||__|||__|||__|||__|||__|||__|||__|||__|||__||");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("                            |/_\\||/_\\|/_\\|/_\\|/_\\|/_\\|/_\\|/_\\|/_\\|/_\\|/_\\|/_\\||/_\\|\n");
            System.Threading.Thread.Sleep(300);







            Console.WriteLine("Giriş için kullanıcı adınızı ve parolanızı giriniz...\n");
        kullanıcı:
            Console.Write("Kullanıcı adı :");
            ad = Console.ReadLine();
            Console.Write("Şifre :");
            şifre = Console.ReadLine();
            if (ad == "Resul" && şifre == "12345")

                Console.WriteLine("Giriş onaylandı....\n");

            else
            {
                Console.WriteLine("Kullanıcı adınız veya parolanız yanlış tekrar deneyiniz...");
                goto kullanıcı;
            }

        bas:
            Console.Clear();
            Console.WriteLine("[1]Not Ortalama Makinası");
            Console.WriteLine("[2]Hesap Makinası       ");
            Console.WriteLine("[3]Sayı Bulma Oyunu     ");
            Console.WriteLine("[4]Bölünebilme İşlemi ");
            Console.WriteLine("[5]Faktöriyel Hesapları ");





            Console.Write("\n Seçim yapınız :");
            seçim = Console.ReadLine();
            if (seçim == "1")
            {
                Console.Clear();
                NotOrtalamaMakinası();
                goto bas;
            }
            else if (seçim == "2")
            {
                Console.Clear();
                hesapmakinası();
                goto bas;
            }
            else if (seçim == "3")
            {
                Console.Clear();
                sayıbulma();
                goto bas;
            }
            else if (seçim == "4")
            {
                Console.Clear();
                bölünebilme();
                goto bas;
            }
            else if (seçim == "5")
            {
                Console.Clear();
                Faktoriyel();
                goto bas;
            }

            else

                goto bas;

        }
       
        public void NotOrtalamaMakinası()/////////////////////////////////////////////////////////////NOT ORTALAMASI//////////////////////////////////
        {
        bas:
            Console.Clear();

            float vize, final, ort;
            Console.WriteLine("*****************************");
            Console.WriteLine("****Not Ortalama Makinası****");
            Console.WriteLine("*****************************");
        head:
            Console.Write("Vize notunuzu giriniz :");
            vize = float.Parse(Console.ReadLine());
            if (vize > 100)
                goto head;


            hea:
            Console.Write("Final notunuzu giriniz :");
            final = float.Parse(Console.ReadLine());
            if (final > 100)
                goto hea;

            ort = (vize * 40 / 100) + (final * 60 / 100);
            if (ort >= 100)
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
            else
                Console.WriteLine("Ortalamanız :" + ort);
            if (ort >= 90)
                Console.WriteLine("A Aldınız...");
            else if (ort >= 80)
                Console.WriteLine("B Aldınız...");
            else if (ort >= 70)
                Console.WriteLine("C Aldınız...");
            else if (ort >= 60)
                Console.WriteLine("D Alarak koşullu geçtiniz...");
            else
                Console.WriteLine("Kaldınız...");
            Console.WriteLine("");
            Console.WriteLine("Yeniden denemek için 'd', başa dönmek için enter tuşuna basınız...");
            if (Console.ReadLine() == "d")
                goto bas;
        }
       
        public void hesapmakinası()/////////////////////////////////////////////////////////////////////////////////HESAP MAKİNASI////////////////////////////
        {
            string seçim;
            float top1, top2, top3;

        bas:
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("*******Hesap Makinası********");
            Console.WriteLine("*****************************\n\n");
            Console.WriteLine("[1]Toplama");
            Console.WriteLine("[2]Çıkarma       ");
            Console.WriteLine("[3]Bölme       ");
            Console.WriteLine("[4]Çarpma      \n");

            Console.WriteLine("Yapmak istediğiniz işlemi şeçiniz...");
            seçim = Console.ReadLine();

            if (seçim == "1")
            {
                Console.Write("Toplanacak sayıları giriniz :\n");
                top1 = float.Parse(Console.ReadLine());
                Console.WriteLine("");
                top2 = float.Parse(Console.ReadLine());
                top3 = top1 + top2;

                Console.WriteLine("Sonuç :" + top3);
            }

            else if (seçim == "2")
            {
                Console.Write("Çıkarılacak sayıları giriniz :\n");
                top1 = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                top2 = int.Parse(Console.ReadLine());
                top3 = top1 - top2;
                Console.WriteLine("Sonuç :" + top3);
            }
            else if (seçim == "3")
            {
                Console.Write("Bölünecek sayıları giriniz :\n");
                top1 = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                top2 = int.Parse(Console.ReadLine());
                top3 = top1 / top2;
                Console.WriteLine("Sonuç :" + top3);
            }
            else if (seçim == "4")
            {
                Console.Write("Çarpılacak sayıları giriniz :\n");
                top1 = int.Parse(Console.ReadLine());
                Console.Write("");
                top2 = int.Parse(Console.ReadLine());
                top3 = top1 * top2;
                Console.WriteLine("Sonuç :" + top3);
            }


            Console.WriteLine("Yeniden denemek için 'd', başa dönmek için enter tuşuna basınız...");
            if (Console.ReadLine() == "d")
                Console.Clear();
            goto bas;



        }
        
        public void sayıbulma()

        {
        bas:
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("*******Sayı Bulma Oyunu******");
            Console.WriteLine("*****************************");
            Console.Clear();

            int sayı, sayı2;
            Random rnd = new Random();
            sayı = rnd.Next(1, 5);
            Console.WriteLine("1 ile 5 arası tutulan sayıyı tahmin Et :");
            sayı2 = int.Parse(Console.ReadLine());
            if (sayı == sayı2)
            {
                Console.WriteLine("Bildin!!!");
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
            }
            else if (sayı != sayı2)
            {
                Console.WriteLine("Bilemedin!!!\n");

                Console.WriteLine("                                                ");
                Console.WriteLine("            ░░░░░░░░░░░░░░░░░░░▒▓▓█████████████▓▓▒░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░▒████▓▓▒▒░▒▒▒░▒▒▒▒▒▒▓▓████▓▒░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░▒███▓░░░░░░░░░░░░░░░░░░░░░░▒███████▓▓▒░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░▒██▓░░░░▒▒███▓▓▒░░░░░░░░░░░░░▓▓▒▒▒▒▒▓██████▓░░░░░░░");
                Console.WriteLine("░░░░░░░▒██▓░░░▓███▓▒░░░░░░░░▒▒▒▒▒▒▒▒▒▒░░░░░░▒▓▓███▓████▒▒░░░");
                Console.WriteLine("░░░░░░██▓░░▒▓██▓░░▒▓██████▓░░░░░░░▒░░░░░░▒██▓▒░░░▓███▒▓▒░░░░");
                Console.WriteLine("░░░░░██░░▓███▒░░▒██▒░░░░▒▒██▓░░░░░░░░░░░██▒░░░░▒████▒█░░░░░░");
                Console.WriteLine("░░░░██░▒▓▒▓▓░░░██░░░░░░░░░░░█▓░░░░░░░░░██░░░░░░▒███░░█▒░░░░░");
                Console.WriteLine("░░░▓█░░░░░░░░░██░░░░░░░░░░░░▓█░░░░░░░░██░░░░░░░░░░░░░█▒░░░░░");
                Console.WriteLine("░░░█▓░░░░░░░░░█▒░░████░░░░░░░█▒░░░░░░░██░░░░░░░░░░░░███░░░░░");
                Console.WriteLine("░░▒█░░░░░░░▒▓▒█▓░▓████▓░░░░░▒█░░░░░░░░▒█▒░░░░░░░░░░██░█▒░░░░");
                Console.WriteLine("░░██░░░░░▒▓▒▓▒██▒▒▓▓▓░░░░░░░██░░░░░░░░░▒████▓███████▓░█▒░░░░");
                Console.WriteLine("░░█▓░░░░░▒░░░▒░▒██▓▒░░░░░▒██▓░░░░░░░░░░░░░░██▓░░░░░░▒██▓░░░░");
                Console.WriteLine("░░█░░░░░░░░░▓▒░░░░▒▓██████▓░░░░░░░░░░░░░░▒██░░░▓█▓▓▒░░░██░░░");
                Console.WriteLine("░▒█░░░░░░░░░░░░░░░░░░░░░░░░░░▓▒▓▒▒▒▒▒▓▓▓▓██░░▓█▓░▒▒██▒░░██░░");
                Console.WriteLine("░▓█░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▓▓▒░░██░░██▓░▒░▒░██░░▒█░░");
                Console.WriteLine("░██░░░░░░░░░░░░░░░░░░░░░░░▒▓▒▒▒▒▒▒▒▒░░░██░░▓█░█▓░█▒█▓█▓░░█░░");
                Console.WriteLine("░██░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒░▒▒░░▓█▓░░██░█▒▒█▒█▒▓█░░█░░");
                Console.WriteLine("░██░░░░░░░░░░░░░░░░░░░░░░░░▒░░░░░░░░░░▓█░░░█▒░░░░▒▒░░▒█░▓█░░");
                Console.WriteLine("░▒█░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒░░█▒░░█▒░░░░░░░░▓█░█▓░░");
                Console.WriteLine("░░█▓░▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓█░░█▒░░░░░░░░█░▒█░░░");
                Console.WriteLine("░░▓█░░▒░░▒▒░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░█░░█▒░░░░░░░█▓░█▓░░░");
                Console.WriteLine("░░░█▒░░▒░░▒░░▒▒░░░░░░░░░░░░░░░░░░░░░░░░░█░░█▒░░░░░░▓█░░█░░░░");
                Console.WriteLine("░░░██░░░▒░▒░░░▒▒░░░░░░░░░░░░░░░░░░░░░░░░█░░█▒░░░░░░██░░█░░░░");
                Console.WriteLine("░░░░█▓░░░▒░▒░░░░▒▒░░░░░▒▒▒▒▒▒░░░░░░░░░░▒█░▒█░░░░░░░█▒░░█▓░░░");
                Console.WriteLine("░░░░▓█░░░░▒▒░░░░░▒▒░░░░░░▒▒▒▓▓▓▒░░░░░░░██░██░░░░░░░██░░▓█░░░");
                Console.WriteLine("░░░░░██░░░▒░▒░░░░░▒░░░░░░░░▒░▒▒▓█▒░░░░▒█░░█▓▒▓▓▓▒░░▓█░░░█▒░░");
                Console.WriteLine("░░░░░▒█▒░░░▒▒▒░░░░▒░░░░░░░░░░▒▒▒░▒▓░░░██░▒█░░░░▒▓▓░░██░░█▒░░");
                Console.WriteLine("░░░░░░▒█▒░░░▒░▒░░░▒░░░░░░▒▒▒░░░░▒▒░░░▒█░░██░░░░░░░█░▒█░░█▒░░");
                Console.WriteLine("░░░░░░░▓█░░░▒░▒░░░░▒▒░░░░▓▒▒▓▓▓▒░░▓▒░██░░██▒▒▒▒▓▒▓▓███░░█▒░░");
                Console.WriteLine("░░░░░░░░██░░░▒░▒░░░░░▒▒░░░░░░░░▓█▓░░░█▓░░██░▓█░█░█░░█▒░░█▒░░");
                Console.WriteLine("░░░░░░░░░██░░░░▒▒░░░░░░▒▒░░░░░░░░▒█▓░█▓░░▓█▒▒█▒█░█▒██░░▒█░░░");
                Console.WriteLine("░░░░░░░░░░██▒░░░░▒░░░▒░░░▒▒░░░░░░░░▒▓██░░░██░░░░▒▒██░░░██░░░");
                Console.WriteLine("░░░░░░░░░░░▓██░░░░░░░░▒▒░░░▒░░░░░░░░░▓█░░░░▓███▓▓██░░░██░░░░");
                Console.WriteLine("░░░░░░░░░░░░░▓██▒░░░░░░▒▒▒▒▒░░░░░░░░░░██░░░░░░▒▒▒░░░░██░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░▓███▒░░░░░░░▒▒▒▒▒▒▒▒░░░░▓██▒░░░░░░░▒███░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░▒▓███▓▒░░░░░░░▒░░▒▒▒▒░░░▒██▓██████▓░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░▒████▓▒▒░░░░░░░░░░░░░░░▓██▒░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░▒▓████▓░░░░░░░▓█████▒░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█████████▒░░░░░░░░░░░░░░░░░░░");

            }


            Console.WriteLine("Yeniden denemek için 'd', başa dönmek için enter tuşuna basınız...");
            if (Console.ReadLine() == "d")
                goto bas;

        }
      
        public void bölünebilme()////////////////////////////////////////////////////////////////////////////BÖLÜNEBİLME////////////////////////////////////
        {
        bas:
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("*****Bölünebilme İşlemi******");
            Console.WriteLine("*****************************");

            int sayı1, sayı2;

            Console.Write("Bölünmesini sorulayacağınız sayıyı giriniz :");
            sayı1 = int.Parse(Console.ReadLine());
            Console.Write("Bölünebileceği sayıyı giriniz  :");
            sayı2 = int.Parse(Console.ReadLine());


            if (sayı1 % sayı2 == 0)
                Console.WriteLine("Sayılar tam bölnebiliyor...");
            else
                Console.Write("Sayılar tam bölünemiyor...\n");




            Console.WriteLine("Yeniden denemek için 'd', başa dönmek için enter tuşuna basınız...");
            if (Console.ReadLine() == "d")
                goto bas;


        }
      
        public void Faktoriyel()/////////////////////////////////////////////////////////////////////////////FAKTÖRİYEL HESAPLAMA/////////////////////////////
        {
        bas:
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("****Faktöriyel Hesapları*****");
            Console.WriteLine("*****************************");



            double sonuc = 1;
            Console.Write("Faktöriyeli bulunacak sayıyı giriniz...  ");
            double sayı = int.Parse(Console.ReadLine());



            while (sayı > 0)
            {
                sonuc *= sayı;
                sayı--;

            }
            Console.WriteLine("Sonuç :" + sonuc);

            Console.WriteLine("Yeniden denemek için 'd', başa dönmek için enter tuşuna basınız...");
            if (Console.ReadLine() == "d")

                goto bas;


        }



        ///////////////////////////////////////////////////////////////////////////////DENEMELER/////////////////////////////////////////////////////////////////////// 





        public void İlkprogramlar(int saat, int dakika, int saniye)
        {
            int Dakika, Saniye, Saat;

            Dakika = dakika + saniye / 60;
            Saniye = saniye % 60;
            Saat = saat + Dakika / 60;
            Dakika = Dakika % 60;

            Console.WriteLine(Saat + ":" + Dakika + ":" + Saniye);
            Console.ReadKey();

        }
        public void deneme()   ///////////////////////////////////////////////////////////////////////WHİLE DURDURMA//////////////////////////////
        {
            int sayı, sayı1;



            while (true)


            {
                Random rnd = new Random();
                sayı = rnd.Next(1, 5);

                Console.WriteLine("Tahmin ?");

                sayı1 = int.Parse(Console.ReadLine());

                if (sayı == sayı1)
                {
                    Console.Write("Bildiniz...");
                    break;

                }

                else
                    Console.Write("Bilemedin devam...");

            }
        }
        public void deneme1()  ////////////////////////////////////////////////////////////////////////while kaç defa döneceği///////////////////
        {

            int toplam = 0, sayi, sayac = 0;

            while (sayac < 10)
            {
                Console.Write("Sayı: ");
                sayi = int.Parse(Console.ReadLine());

                toplam += sayi;

                sayac++;
            }

            Console.WriteLine(toplam);
            Console.ReadKey();

        }
        public void deneme2()  ///////////////////////////////////////////////////////////////////////Operatör ?/////////////////////////////////
        {
            Console.WriteLine("Bilgisayar kapatılsın mı (E/H);");
            string e = Console.ReadLine();
            Console.WriteLine(e == "E" ? "Kapatılıyor" : "Kapatılmıyor");

            Console.ReadKey();

        }
        public void deneme3()  ////////////////////////////////////////////////////////////////////////Metni alt alta yazma//////////////////////
        {

            string cumle;
            Console.Write("Bir cümle giriniz: ");
            cumle = Console.ReadLine();

            for (int i = 0; i < cumle.Length; i++)
            {
                Console.WriteLine(cumle[i]);
            }
            Console.ReadKey();
        }
        public void deneme4()  //////////////////////////////////////////////////////////////////////Dikdörtgen çizme////////////////////////////
        {


            Console.Write("Yüksekliği Girin : ");
            int yukseklik = Convert.ToInt32(Console.ReadLine());
            Console.Write("Genişliği Girin : ");
            int genislik = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= yukseklik; i++)
            {
                for (int j = 1; j <= genislik; j++)
                {
                    if (i == 1 || i == yukseklik)
                        Console.Write("*");
                    else
                        if (j == 1 || j == genislik)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("www.yazilimkodlama.com");
            Console.ReadKey();
        }
        public void deneme5()  //////////////////////////////////////////////////////////////////////////////Harf sayacı/////////////////////////
        {
            char harf;

            Console.WriteLine("Metni giriniz");
            string metin = Console.ReadLine();
            Console.WriteLine("Sayılmasını istediğiniz harfi giriniz");
            harf = Convert.ToChar(Console.ReadLine());



            int i = 0, sayac = 0;

            for (i = 0; i < metin.Length; i++)
            {
                if (metin[i] == harf)
                {
                    sayac++;
                }
            }

            Console.WriteLine("Metninizde " + harf + " harfi " + sayac + " adet vardır...");
            Console.ReadKey();

        }
        public void deneme6()  //////////////////////////////////////////////////////////////////////////////Dizin indexi bulma//////////////////
        {
            int[] dizi = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}. elemanı giriniz : ", i + 1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("=========================================");
            // Yazdırma işlemi
            for (int i = 0; i < 10; i++)
            {
                dizi[i] = dizi[i] + (dizi[i] * 20 / 100);
                Console.WriteLine("Dizinin {0}. indexi : {1} ", i, dizi[i]);
            }
            Console.ReadKey();
        }
        public void deneme7()  ////////////////////////////////////////////////////////////////////////////Alt alta metin yazdırma///////////////
        {


            Console.WriteLine("Yazdırılacak metni giriniz");
            string metin = Console.ReadLine();
            Console.WriteLine("------------------------");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(metin);
            }
            Console.ReadKey();

        }
        public void deneme8()  /////////////////////////////////////////////////////////////////////////////Piramitler///////////////////////////
        {


            for (int c = 0; c < 200; c++)
            {
                Random rnd = new Random();
                int sayı = rnd.Next(1, 20);
                for (int i = 0; i < sayı; i++)
                {
                    for (int x = 0; x <= i; x++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }

                for (int a = sayı - 1; a > 0; a--)
                {
                    for (int b = 0; b < a; b++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
                Thread.Sleep(80);



            }


        }
        public void deneme9()  /////////////////////////////////////////////////////////////////////////////Ekolayzır YAN////////////////////////
        {
            for (int c = 0; c < 200; c++)
            {
                {
                    Random rnd = new Random();
                    int sayı = rnd.Next(1, 27);
                    for (int i = 0; i < sayı; i++)

                        Console.Write("█");
                }
                Console.WriteLine("");
                Console.WriteLine("");

                {
                    Random rnd = new Random();
                    int sayı = rnd.Next(1, 35);
                    for (int i = 0; i < sayı; i++)
                        Console.Write("█");
                }
                Console.WriteLine("");
                Console.WriteLine("");

                {
                    Random rnd = new Random();
                    int sayı = rnd.Next(1, 33);
                    for (int i = 0; i < sayı; i++)
                        Console.Write("█");
                }
                Console.WriteLine("");
                Console.WriteLine("");

                {
                    Random rnd = new Random();
                    int sayı = rnd.Next(1, 18);
                    for (int i = 0; i < sayı; i++)
                        Console.Write("█");
                }
                Console.WriteLine("");
                Console.WriteLine("");

                {
                    Random rnd = new Random();
                    int sayı = rnd.Next(1, 34);
                    for (int i = 0; i < sayı; i++)
                        Console.Write("█");
                }
                Console.WriteLine("");
                Console.WriteLine("");

                {
                    Random rnd = new Random();
                    int sayı = rnd.Next(1, 23);
                    for (int i = 0; i < sayı; i++)
                        Console.Write("█");
                }
                Console.WriteLine("");
                Console.WriteLine("");



                {
                    Random rnd = new Random();
                    int sayı = rnd.Next(1, 39);
                    for (int i = 0; i < sayı; i++)
                        Console.Write("█");
                }
                Console.WriteLine("");
                Console.WriteLine("");

                {
                    Random rnd = new Random();
                    int sayı = rnd.Next(1, 27);
                    for (int i = 0; i < sayı; i++)
                        Console.Write("█");
                }
                Console.WriteLine("");
                Console.WriteLine("");

                {
                    Random rnd = new Random();
                    int sayı = rnd.Next(1, 25);
                    for (int i = 0; i < sayı; i++)
                        Console.Write("█");
                }
                Console.WriteLine("");
                Console.WriteLine("");

                {
                    Random rnd = new Random();
                    int sayı = rnd.Next(1, 42);
                    for (int i = 0; i < sayı; i++)
                        Console.Write("█");
                }
                Console.WriteLine("");
                Console.WriteLine("");

                {
                    Random rnd = new Random();
                    int sayı = rnd.Next(1, 32);
                    for (int i = 0; i < sayı; i++)
                        Console.Write("█");
                }
                Console.WriteLine("");
                Console.WriteLine("");

                {
                    Random rnd = new Random();
                    int sayı = rnd.Next(1, 25);
                    for (int i = 0; i < sayı; i++)
                        Console.Write("█");
                }
                Console.WriteLine("");
                Console.WriteLine("");


                {
                    Random rnd = new Random();
                    int sayı = rnd.Next(1, 21);
                    for (int i = 0; i < sayı; i++)
                        Console.Write("█");
                }
                Thread.Sleep(80);

                Console.Clear();
            }
        }
        public void deneme10() ///////////////////////////////////////////////////////////////////////////////Ekolayzır DÜZ//////////////////////

        {

            Console.Title = "Ekolayzır";
            Console.SetWindowSize(100, 25);



            for (int c = 0; c < 200; c++)
            {

                {
                    Random rnd = new Random();
                    int random = rnd.Next(1, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        if (random < 4) { Console.ForegroundColor = ConsoleColor.Red; }
                        Console.SetCursorPosition(4, i); Console.Write("██");
                    }
                }


                {
                    Random rnd = new Random();
                    int random = rnd.Next(4, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(8, i); Console.Write("██"); }
                }

                {
                    Random rnd = new Random();
                    int random = rnd.Next(8, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(12, i); Console.Write("██"); }
                }

                {
                    Random rnd = new Random();
                    int random = rnd.Next(5, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(16, i); Console.Write("██"); }
                }

                {
                    Random rnd = new Random();
                    int random = rnd.Next(2, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(20, i); Console.Write("██"); }
                }

                {
                    Random rnd = new Random();
                    int random = rnd.Next(1, 25);
                    if (random < 4) { Console.ForegroundColor = ConsoleColor.Red; }
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(24, i); Console.Write("██"); }
                }

                {
                    Random rnd = new Random();
                    int random = rnd.Next(2, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(28, i); Console.Write("██"); }
                }

                {
                    Random rnd = new Random();
                    int random = rnd.Next(7, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(32, i); Console.Write("██"); }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(5, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(36, i); Console.Write("██"); }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(4, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(40, i); Console.Write("██"); }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(3, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(44, i); Console.Write("██"); }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(1, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        if (i < 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }


                        Console.SetCursorPosition(48, i);
                        Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(4, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(52, i); Console.Write("██"); }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(3, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(56, i); Console.Write("██"); }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(7, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(60, i); Console.Write("██"); }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(5, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(64, i); Console.Write("██"); }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(2, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(68, i); Console.Write("██"); }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(4, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(72, i); Console.Write("██"); }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(6, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(76, i); Console.Write("██"); }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(3, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(80, i); Console.Write("██"); }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(5, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(84, i); Console.Write("██"); }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(4, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(88, i); Console.Write("██"); }
                }


                Thread.Sleep(50);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

            }
        }
        public void eqo()      ////////////////////////////////////////////////////////////////////////////////////Ekolayzır :Renkli/////////////

        {
            Console.CursorVisible = false;
            Console.Title = "Ekolayzır";
            Console.SetWindowSize(95, 25);
            Console.Clear();



            for (;;)
            {

                Random rn = new Random();
                int a = rn.Next(1, 11);
                if (a == 2) { Console.ForegroundColor = ConsoleColor.Red; }
                else if (a == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Black;


                }
                else if (a == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                }
                else if (a == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;


                }
                else if (a == 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                }
                else if (a == 7)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }
                else if (a == 8)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                }
                else if (a == 9)
                {
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else if (a == 10)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }


                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("                      ╔╗ ╦ ╦  ╦═╗╔═╗╔═╗╦ ╦╦    ╔═╗╔═╗╔╦╗╦╦╔═╔═╗╔═╗╦  ╦ ╦");
                Console.WriteLine("                      ╠╩╗╚╦╝  ╠╦╝║╣ ╚═╗║ ║║    ╚═╗╠═╣ ║║║╠╩╗║ ║║ ╦║  ║ ║");
                Console.WriteLine("                      ╚═╝ ╩   ╩╚═╚═╝╚═╝╚═╝╩═╝  ╚═╝╩ ╩═╩╝╩╩ ╩╚═╝╚═╝╩═╝╚═╝");

                {
                    Random rnd = new Random();
                    int random = rnd.Next(1, 5);
                    for (int i = random; i < 25 && i > 0; i++)
                    {









                    }
                }


                {
                    Random rnd = new Random();
                    int random = rnd.Next(1, 15);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(8, i); Console.Write("██");
                    }
                }

                {
                    Random rnd = new Random();
                    int random = rnd.Next(1, 16);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(12, i); Console.Write("██");
                    }
                }

                {
                    Random rnd = new Random();
                    int random = rnd.Next(5, 12);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(16, i); Console.Write("██");
                    }
                }

                {
                    Random rnd = new Random();
                    int random = rnd.Next(2, 15);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(20, i); Console.Write("██");
                    }
                }

                {
                    Random rnd = new Random();
                    int random = rnd.Next(1, 10);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(24, i); Console.Write("██");
                    }
                }

                {
                    Random rnd = new Random();
                    int random = rnd.Next(2, 15);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(28, i); Console.Write("██");
                    }
                }

                {
                    Random rnd = new Random();
                    int random = rnd.Next(7, 15);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(32, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(2, 16);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(36, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(6, 16);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(40, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(1, 9);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(44, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(7, 15);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(48, i); Console.Write("██");

                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(3, 16);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(52, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(2, 12);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(56, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(4, 14);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(60, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(1, 12);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(64, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(6, 15);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(68, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(5, 18);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(72, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(4, 13);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(76, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(2, 12);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(80, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(2, 9);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(84, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(1, 10);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(88, i); Console.Write("██");
                    }
                }


                System.Threading.Thread.Sleep(50);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

            }
        }
        public void deneme11() ////////////////////////////////////////////////////////////////////////////////Math metodu///////////////////////
        {

            int a;
            a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Math.Abs(Math.Tan(a)));


        }
        public void denemeyeni()/////////////////////////////////////////////////////////////////////////////////Metindeki kelimeleri değiştirme///////////////
        {
            //\D ifadesi ile yazının ilgili yerinde rakam olmayan tek bir karakterin bulunması gerektiği belirtilir.
            //\d ifadesi ile yazının ilgili yerinde 0 - 9 arası tek bir karakterin bulunması gerektiği belirtilir.
            //\W ifadesi ile yazının ilgili yerinde alfanumerik olmayan karakterin bulunması gerektiği belirtiliyor. Alfanumerik karakterler a - z, A - Z ve 0 - 9 aralıklarındaki karakterlerdir.
            //\w ifadesi ile yazının ilgili yerinde bir alfanumerik karakterin bulunması gerektiği belirtiliyor.
            //\S ifadesi ile yazının ilgili yerinde boşluk veya tab karakterleri haricinde bir karakterin olması gerektiği belirtiliyor.
            //\s ifadesi ile yazının ilgili yerinde yalnızca boşluk veya tab karakterlerinden biri bulunacağı belirtiliyor.
            //Belirtilen gruptaki karakterlerden bir ya da daha fazlasının olmasını istiyorsak + işaretini kullanırız. 
            //Bir ifadenin mutlaka istediğimiz karakterle başlamasını istiyorsak ^ karakterini kullanırız. Örneğin ^9
            //Sabit sayıda karakterin olmasını istiyorsak {adet} şeklinde belirtiriz. Örnek:\d{ 3}-\d{ 5} filtresine "215-69857" uyarken "54-34567" uymaz.
            //? karakteri, hangi karakterin sonuna gelmişse o karakterden en az sıfır en fazla bir tane olacağı anlamına gelir. Örnek:
            //\d{ 3}
            //            B? A
            //Bu filtreye "548A" veya "875BA" uyarken "875BBA" uymaz.
            //
            //. (nokta) işareti ilgili yerde "\n" dışında bir karakterin bulunabileceğini belirtir.Örneğin
            //\d{ 3}.A
            //      filtresine "123sA" ve "8766A" uyar.
            //
            //\b bir kelimenin belirtilen yazıyla sonlanması gerektiğini belirtir. Örnek:
            //\d{ 3}
            //            dır\b
            //       filtresine "123dır" uyarken "123dırb" uymaz.
            //
            //\B ile bir kelimenin başında ya da sonunda bulunmaması gereken karakterler belirtilir. Örnek:
            //\d{ 3}
            //            dır\B
            //       filtresine "123dır" veya "dır123" uymazken "123dır8" uyar.
            //
            //       Köşeli parantezler kullanarak bir karakter aralığı belirtebiliriz.Örneğin ilgili yerde sadece büyük harflerin olmasını istiyorsak[A - Z] şeklinde, ilgili yerde sadece küçük harfler olmasını istiyorsak[a - z] şeklinde, ilgili yerde sadece rakamlar olmasını istiyorsak[0 - 9] şeklinde belirtebiliriz. Ayrıca sınırları istediğimiz şekilde değiştirebiliriz.Örneğin[R - Y] ile ilgili yerde yalnızca R ve Y arası büyük harfler olabileceğini belirtiriz.




            string filtre = @"\d+:\d+";
            string yazi = "Saati belirtmek için : işareti kullanılır. Örnek: 12:35";
            Regex nesne = new Regex(filtre);
            string degistirilmis = nesne.Replace(yazi, "00:00");
            Console.WriteLine(degistirilmis);


        }
    }


}


