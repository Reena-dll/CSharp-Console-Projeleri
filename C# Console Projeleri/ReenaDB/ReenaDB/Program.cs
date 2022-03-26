using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReenaDB
{
    
    class Program
    {
        // Merhabalar, Bu projemde Kullanıcı girişli, Sorgu uygulaması yapmaya çalışacağım. Uygulamamın ismi Reena
        // Ama keşke bu ödeve biraz daha erken başlasaydım. Biraz açık noktalar kaldı, Örneğin: İD giriniz dediğim yerlerde string ifade girince program kitlenmesi gibi yerler
        // Ama bir çok mantık açıkları kapatıldı.
        // Umarım kodları tek tek incelemek için vaktiniz vardır.
        // Ödev 2 günde bitirildi.
        // Admin paneline erişmek için, Kullanıcı adı kısmına: admin , Kullanışı şifre kısmına:password yazabilirsiniz...

            // OĞUZHAN SADIKOĞLU 20181011131  --- Bilgisayar Programcılığı -- Birinci Öğretim

       
        // ÖRNEK CUSTOM TYPE CUSTOM TYPE --- Projede Kullanılmadı ---

        //List<MusterilerCustomModel> MusteriAd = DB.Musteriler.Where(x=> x.MusteriAdı > 5 && x.MusteriSoyadi.Contains("a"))
        //                                         .Select(x=> new MusterilerCustomModel
        //                                         {
        //                                               MusteriAdi = x.MusteriAdi,
        //                                               MusteriSoyadi = x.MusteriSoyadi,
        //                                               Telefon = x.Telefon
        //                                         }).ToList();

        static void Main(string[] args)
        {
            Console.Title = "Reena Program";
            Console.SetWindowSize(100, 50);
            Console.CursorVisible = true;
            GirisSayfasi();

            Console.Read();
        }

        public static void GirisSayfasi()
        {
            
            string tercih;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            MyName();
            Console.SetCursorPosition(28, 5);
            Console.Write("Reena DataBase'e Hoş Geldiniz...");
            Console.SetCursorPosition(28, 10);
            Console.Write("1- Daha Önce Kayıt Olduysanız 1'i");
            Console.SetCursorPosition(28, 11);
            Console.Write("2- Kayıt Olmak İçin 2'i");
            Console.SetCursorPosition(28, 12);
            Console.Write("3- Şifrenizi Unuttuysanız 3'ü");
            Console.SetCursorPosition(28, 13);
            Console.Write("4- Uygulamadan Çıkmak için 4'ü Tuşlayınız");
            Console.SetCursorPosition(35, 15);
            Console.Write("Seçim: ");
            tercih = Console.ReadLine();

            if (tercih=="1")
            {
                KullaniciGirisi();
            }

            else if(tercih=="2")
            {
                KullaniciKayit();
            }
            else if(tercih=="3")
            {
                SifremiUnuttum();
            }
            else if (tercih=="4")
            {
                Environment.Exit(0);
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(17, 17);
                Console.Write("Girmiş Olduğunuz Değer Yanlış. Tekrar Deneyiniz...");
                System.Threading.Thread.Sleep(3000);
                GirisSayfasi();
            }
           
        } // Burası benim ilk açılış ekranım GirisSayfam
        public static void KullaniciGirisi()
        {
        kullanicigirisi:
            ReenaDBEntities DB = new ReenaDBEntities();
            string ad, sifre,secim;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            MyName();
            Console.SetCursorPosition(28, 5);
            Console.Write("Kullanıcı Giriş Sayfamıza Hoş Geldiniz...");
            Console.SetCursorPosition(28, 8);
            Console.Write("Lütfen Kullanıcı Adınızı Giriniz: ");
            ad = Console.ReadLine();
            Console.SetCursorPosition(28, 9);
            Console.Write("Lütfen Kullanıcı Şifrenizi Giriniz: ");
            sifre = Console.ReadLine();

            Kullanici k = DB.Kullanici.Where(x => x.KullanıcıAdı == ad && x.KullanıcıSifre == sifre).SingleOrDefault();

            if (k == null) 
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.SetCursorPosition(35, 17);
                Console.WriteLine("░░░░▄██████████████████████▄░░░░");
                Console.SetCursorPosition(35, 18);
                Console.WriteLine("░░▄██████████████████████████▄░░");
                Console.SetCursorPosition(35, 19);
                Console.WriteLine("▄██████████████████████████████▄");
                Console.SetCursorPosition(35, 20);
                Console.WriteLine("██████░░░▀████████████▀░░░██████");
                Console.SetCursorPosition(35, 21);
                Console.WriteLine("██████░░░░░▀████████▀░░░░░██████");
                Console.SetCursorPosition(35, 22);
                Console.WriteLine("███████▄░░░░░▀████▀░░░░░▄███████");
                Console.SetCursorPosition(35, 23);
                Console.WriteLine("█████████▄░░░░░▀▀░░░░░▄█████████");
                Console.SetCursorPosition(35, 24);
                Console.WriteLine("███████████▄░░░░░░░░▄███████████");
                Console.SetCursorPosition(35, 25);
                Console.WriteLine("████████████▀░░░░░░▀████████████");
                Console.SetCursorPosition(35, 26);
                Console.WriteLine("██████████▀░░░░░░░░░░▀██████████");
                Console.SetCursorPosition(35, 27);
                Console.WriteLine("████████▀░░░░░▄██▄░░░░░▀████████");
                Console.SetCursorPosition(35, 28);
                Console.WriteLine("██████▀░░░░░▄██████▄░░░░░▀██████");
                Console.SetCursorPosition(35, 29);
                Console.WriteLine("██████░░░░▄██████████▄░░░░██████");
                Console.SetCursorPosition(35, 30);
                Console.WriteLine("▀██████▄▄██████████████▄▄██████▀");
                Console.SetCursorPosition(35, 31);
                Console.WriteLine("░░▀██████████████████████████▀░░");
                Console.SetCursorPosition(35, 32);
                Console.WriteLine("░░░░▀██████████████████████▀░░░░");


                Console.SetCursorPosition(28, 11);
                Console.WriteLine("Kullanıcı Adı veya Şifre Hatalı.");
                Console.SetCursorPosition(14, 12);
                Console.WriteLine(" Tekrar Denemek İçin 1'i, Giris Sayfasına Dönmek İçin 2'yi Tuşlayın.");
                Console.SetCursorPosition(45, 13);
                Console.ForegroundColor = ConsoleColor.White;
                secim = Console.ReadLine();
                if(secim=="1")
                {
                    System.Threading.Thread.Sleep(1000);
                    goto kullanicigirisi;
                }
                else if (secim=="2")
                {
                    System.Threading.Thread.Sleep(1000);
                    GirisSayfasi();
                }





            }// KULLANICI ADI VE ŞİFRE YANLIŞ İSE
            else if (k != null) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(34, 11);
              
                Console.Write("Kullanıcı Doğrulandı...");
                Console.SetCursorPosition(34, 14);
                Console.WriteLine("                       ▄▄████▀  ");
                Console.SetCursorPosition(34, 15);
                Console.WriteLine("                     ▄██████    ");
                Console.SetCursorPosition(34, 16);
                Console.WriteLine("                   ▄██████▀     ");
                Console.SetCursorPosition(34, 17);
                Console.WriteLine("                 ▄███████       ");
                Console.SetCursorPosition(34, 18);
                Console.WriteLine("               ▄███████▀        ");
                Console.SetCursorPosition(34, 19);
                Console.WriteLine("              ▄███████          ");
                Console.SetCursorPosition(34, 20);
                Console.WriteLine("             ████████           ");
                Console.SetCursorPosition(34, 21);
                Console.WriteLine("            ███████▀            ");
                Console.SetCursorPosition(34, 22);
                Console.WriteLine(" ▄▄        ███████▀             ");
                Console.SetCursorPosition(34, 23);
                Console.WriteLine("████     ▄███████▀              ");
                Console.SetCursorPosition(34, 24);
                Console.WriteLine("█████▄  ▄███████▀               ");
                Console.SetCursorPosition(34, 25);
                Console.WriteLine("███████████████▀                ");
                Console.SetCursorPosition(34, 26);
                Console.WriteLine("██████████████▀                 ");
                Console.SetCursorPosition(34, 27);
                Console.WriteLine("▀████████████▀                  ");
                Console.SetCursorPosition(34, 28);
                Console.WriteLine("  ▀█████████▀                   ");
                Console.SetCursorPosition(34, 29);
                Console.WriteLine("    ▀████████                   ");

                System.Threading.Thread.Sleep(3000);
                AnaSayfa(ad);


            }// KULLANICI ADI VE ŞİFRE DOĞRU İSE
        } // Kullanıcı GirisSayfasinda 1'i seçtiği alan. Burada kullanıcı üyeliğine girecek.
        public static void KullaniciKayit()
        {
            enbas:
            ReenaDBEntities DB = new ReenaDBEntities();
            
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            MyName();
            string ad, sifre;
            Console.SetCursorPosition(28, 5);
            Console.Write("Kayıt Olma Sayfasına Hoş Geldiniz...");
            Console.SetCursorPosition(28, 8);
            Console.Write("Lütfen Kullanıcı Adınızı Giriniz: ");
            ad = Console.ReadLine();
            Console.SetCursorPosition(28, 9);
            Console.Write("Lütfen Kullanıcı Şifrenizi Giriniz: ");
            sifre = Console.ReadLine();

            Kullanici k = DB.Kullanici.Where(x => x.KullanıcıAdı == ad ).SingleOrDefault(); // Burada uyguladığım metot Database'de ki KullanıcıAdı ile eşleşen kayıt var mı. Onu sorguladım

            if (k==null) // Eğer eşleşen kayıt yok ise, Kullanıcı kayıtı gerçekleşsin.
            {
                Kullanici kayit = new Kullanici();

                kayit.KullanıcıAdı = ad;
                kayit.KullanıcıSifre = sifre;
                DB.Kullanici.Add(kayit);
                DB.SaveChanges();

                int sondeger = DB.Kullanici.Max(s => s.KullanıcıID); // Son değeri çekmem de ki sebep, Zaten yeni bir kayıt geleceğinden dolayı en yüksek ID değeri onun oluyor.

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(28, 11);
                Console.Write("Kayıt İşlemi Başarılı...");
                Console.SetCursorPosition(28, 12);
                Console.Write("Şifrenizi Unuttuğunuzda Bu Kod İle Şifrenizi Değiştirebilirsiniz: " + sondeger);
                Console.SetCursorPosition(28, 13);
                Console.Write("Giriş Sayfasına Yönlendiriliyorsunuz...");
                System.Threading.Thread.Sleep(5000);
                GirisSayfasi();
            }
            else if (k!=null) // Eğer öyle bir kullanıcı adı var ise gerçekleşmesin
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(28, 11);
                Console.Write("Girmiş Olduğunuz Kullanıcı Adını Bir Başkası Kullanıyor");
                Console.SetCursorPosition(35, 12);
                Console.Write("Tekrar Deneyiniz.");
                System.Threading.Thread.Sleep(3000);
                goto enbas;
            }

          


        } // Kullanıcı GirisSayfasında 2'i seçtiği alan. Kullanıcı yeni kayıt açacak.
        public static void SifremiUnuttum()
        {
            enbas:
            ReenaDBEntities DB = new ReenaDBEntities();
            int kod = 0;
            string yenisifre;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            MyName();

            Console.SetCursorPosition(28, 5);
            Console.Write("Şifre Yenileme Sayfasına Hoş Geldiniz...");

            Console.SetCursorPosition(33, 8);
            Console.Write("Şifre Yenileme Kodunu Yazınız: ");
            kod = Convert.ToInt32(Console.ReadLine());
            Kullanici k = DB.Kullanici.Where(x => x.KullanıcıID == kod).SingleOrDefault();

            if (k==null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(28, 11);
                Console.Write("Girmiş Olduğunuz Kod Yanlış, "); 
                Console.Write("Tekrar Deneyiniz...");
                System.Threading.Thread.Sleep(3000);
                goto enbas;
            }

            else if(k!=null)
            {

                Console.SetCursorPosition(33, 9);
                Console.Write("Yeni Şifrenizi Yazınız: ");
                yenisifre = Console.ReadLine();
                var guncelle = DB.Kullanici.Find(kod);
                guncelle.KullanıcıSifre = yenisifre;
                DB.SaveChanges();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(33, 11);
                Console.Write("Şifreniz Başarıyla Değiştirildi.");
                Console.SetCursorPosition(33, 12);
                Console.Write("Giriş Sayfasına Yönlendiriliyorsunuz... ");
                System.Threading.Thread.Sleep(2000);
                GirisSayfasi();
                        
            }



        } // Kullanıcı GirisSayfasında 3'ü seçtiği alan. Şifresini unuttuğunda ID'e göre şifre yenileyecek       
        public static void AnaSayfa(string ad)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            MyName();

            if(ad=="admin")
            {
                AdminAnaSayfa();

            }
            else  
                {
                KullaniciSayfa(ad);
                
                 }
           

        }  //Daha Çok Yönlendirme Sayfası Gibi Kullandım Burayı.
        public static void KullaniciSayfa(string ad)
        {
        enbass:
            ReenaDBEntities DB = new ReenaDBEntities();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            MyName();
            string secim;
            Console.SetCursorPosition(40, 3);
            Console.Write("Hoş Geldin " + ad.ToUpper());
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(40, 7);
            Console.Write("1-Müşteriler");
            Console.SetCursorPosition(40, 8);
            Console.Write("2-Kategoriler");
            Console.SetCursorPosition(40, 9);
            Console.Write("3-Siparişler");
            Console.SetCursorPosition(40, 10);
            Console.Write("4-Sipariş Detay");
            Console.SetCursorPosition(40, 11);
            Console.Write("5-Ürünler");
            Console.SetCursorPosition(40, 12);
            Console.Write("6-Giriş Sayfasına Dönmek İçin");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(27, 4);
            Console.Write(ad.ToUpper() + ", Lütfen İşlem Yapacağın Tabloyu Seç: ");
            secim = Console.ReadLine();


            if (secim == "1")
            {

                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                MyName();
                string tercih;
                Console.SetCursorPosition(33, 4);
                Console.Write("Müşteriler Menüsüne Hoş Geldin " + ad);
                Console.SetCursorPosition(4, 5);
                Console.Write("Bu Menüde Müşteriler Tablosuna Veri Ekleyebilir, İsterseniz Girilen Verileri Çekebilirsiniz...");
                Console.SetCursorPosition(33, 7);
                Console.Write("1-Tabloya Veri Eklemek İçin");
                Console.SetCursorPosition(33, 8);
                Console.Write("2-Tablo Verilerini Çekmek İçin");
                Console.SetCursorPosition(33, 9);
                Console.Write("3-Verileri Güncellemek İçin");
                Console.SetCursorPosition(33, 10);
                Console.Write("4-Bir Önce Ki Menüye Dönmek İçin");


                Console.SetCursorPosition(33, 12);
                Console.Write("Seçim: ");
                tercih = Console.ReadLine();
                if (tercih == "1")
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    MyName();
                    string musteriad, soyad, telefon;
                    Console.SetCursorPosition(33, 4);
                    Console.Write("Ekleme Menüsüne Hoş Geldiniz");

                    Console.SetCursorPosition(33, 6);
                    Console.Write("Müşteri Adını Giriniz: ");
                    musteriad = Console.ReadLine();
                    Console.SetCursorPosition(33, 7);
                    Console.Write("Müşteri Soyadı Giriniz: ");
                    soyad = Console.ReadLine();
                    Console.SetCursorPosition(33, 8);
                    Console.Write("Müşteri Telefonu Giriniz: ");
                    telefon = Console.ReadLine();

                    Musteriler m = DB.Musteriler.Where(x => x.MusteriAdi == musteriad && x.MusteriSoyadi == soyad).SingleOrDefault();

                    if (m == null)
                    {
                        Musteriler kayit2 = new Musteriler();
                        kayit2.MusteriAdi = musteriad;
                        kayit2.MusteriSoyadi = soyad;
                        kayit2.Telofon = telefon;
                        DB.Musteriler.Add(kayit2);
                        DB.SaveChanges();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(28, 11);
                        Console.Write("Kayıt İşlemi Başarılı...");
                        Console.SetCursorPosition(28, 12);
                        Console.Write("Kullanıcı Sayfasına Yönlendiriliyorsunuz...");
                        System.Threading.Thread.Sleep(5000);
                        goto enbass;
                    }

                    if (m != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(28, 11);
                        Console.Write("Girmiş Olduğunuz Veriler Bir Başka Verinin Aynısı");
                        Console.SetCursorPosition(35, 12);
                        Console.Write("Tekrar Deneyiniz.");
                        System.Threading.Thread.Sleep(3000);
                        goto enbass;
                    }

                }
                else if (tercih == "2")
                {
                    MusterilerVeriCekme(ad);
                }
                else if (tercih == "3")
                {

                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    MyName();
                    int guncelleID;
                    Console.SetCursorPosition(33, 4);
                    Console.Write("Güncelleme Menüsüne Hoş Geldiniz");

                    Console.SetCursorPosition(0, 16);
                    var Musterilerliste = DB.Musteriler.ToList();

                    foreach (var item in Musterilerliste)
                    {
                        Console.WriteLine(item.Musteri_Id + " " + item.MusteriAdi + " " + item.MusteriSoyadi);
                    }

                    Console.SetCursorPosition(33, 8);
                    Console.Write("Güncellenecek Kullanıcının İD'sini Giriniz: ");
                    guncelleID = Convert.ToInt32(Console.ReadLine());


                    Musteriler mus = DB.Musteriler.Where(x => x.Musteri_Id == guncelleID).SingleOrDefault();

                    if (mus == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(28, 11);
                        Console.Write("Girmiş Olduğunuz ID Yanlış, ");
                        Console.Write("Tekrar Deneyiniz...");
                        System.Threading.Thread.Sleep(3000);
                        goto enbass;
                    }

                    else if (mus != null)
                    {
                        string musteriAdı, musteriSoyadı;

                        Console.SetCursorPosition(33, 9);
                        Console.Write("Yeni Müşteri İsmini Yazınız: ");
                        musteriAdı = Console.ReadLine();
                        Console.SetCursorPosition(33, 10);
                        Console.Write("Yeni Müşteri Soyadını Yazınız: ");
                        musteriSoyadı = Console.ReadLine();
                        var guncelleMusteri = DB.Musteriler.Find(guncelleID);
                        guncelleMusteri.MusteriAdi = musteriAdı;
                        guncelleMusteri.MusteriSoyadi = musteriSoyadı;
                        DB.SaveChanges();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(33, 12);
                        Console.Write("Müşteriniz Başarıyla Değiştirildi.");
                        Console.SetCursorPosition(33, 13);
                        Console.Write("Kullanıcı Sayfasına Yönlendiriliyorsunuz... ");
                        System.Threading.Thread.Sleep(2000);
                        goto enbass;

                    }

                }
                else if (tercih == "4")
                {
                    goto enbass;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(33, 14);
                    Console.Write("Yanlış Değer Girildi...");
                    System.Threading.Thread.Sleep(2000);
                    goto enbass;
                }




            }

            else if (secim == "2")
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                MyName();
                string tercih2;
                Console.SetCursorPosition(33, 4);
                Console.Write("Kategoriler Menüsüne Hoş Geldin " + ad);
                Console.SetCursorPosition(4, 5);
                Console.Write("Bu Menüde Kategoriler Tablosuna Veri Ekleyebilir, İsterseniz Girilen Verileri Çekebilirsiniz...");
                Console.SetCursorPosition(33, 7);
                Console.Write("1-Tabloya Veri Eklemek İçin");
                Console.SetCursorPosition(33, 8);
                Console.Write("2-Tablo Verilerini Çekmek İçin");
                Console.SetCursorPosition(33, 9);
                Console.Write("3-Verileri Güncellemek İçin");
                Console.SetCursorPosition(33, 10);
                Console.Write("4-Bir Önce Ki Menüye Dönmek İçin");

                Console.SetCursorPosition(33, 12);
                Console.Write("Seçim: ");
                tercih2 = Console.ReadLine();

                if (tercih2 == "1")
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    MyName();
                    string kategoriAdi;
                    Console.SetCursorPosition(33, 4);
                    Console.Write("Ekleme Menüsüne Hoş Geldiniz");

                    Console.SetCursorPosition(33, 6);
                    Console.Write("Kategori Adını Giriniz: ");
                    kategoriAdi = Console.ReadLine();

                    Kategoriler k = DB.Kategoriler.Where(x => x.KategoriAdi == kategoriAdi).SingleOrDefault();

                    if (k == null)
                    {
                        Kategoriler kategoriKayit = new Kategoriler();
                        kategoriKayit.KategoriAdi = kategoriAdi;
                        DB.Kategoriler.Add(kategoriKayit);
                        DB.SaveChanges();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(28, 11);
                        Console.Write("Kayıt İşlemi Başarılı...");
                        Console.SetCursorPosition(28, 12);
                        Console.Write("Kullanıcı Sayfasına Yönlendiriliyorsunuz...");
                        System.Threading.Thread.Sleep(5000);
                        goto enbass;
                    }

                    if (k != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(28, 11);
                        Console.Write("Girmiş Olduğunuz Veriler Bir Başka Verinin Aynısı");
                        Console.SetCursorPosition(35, 12);
                        Console.Write("Tekrar Deneyiniz.");
                        System.Threading.Thread.Sleep(3000);
                        goto enbass;
                    }
                }
                else if (tercih2 == "2")
                {
                    KategoriVeriCekme(ad);
                }
                else if (tercih2 == "3")
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    MyName();
                    int guncelleID2;
                    Console.SetCursorPosition(33, 4);
                    Console.Write("Güncelleme Menüsüne Hoş Geldiniz");

                    Console.SetCursorPosition(0, 16);
                    var KategorilerListe = DB.Kategoriler.ToList();

                    foreach (var item in KategorilerListe)
                    {
                        Console.WriteLine(item.Kategori_Id + " " + item.KategoriAdi);
                    }

                    Console.SetCursorPosition(33, 8);
                    Console.Write("Güncellenecek Kategorinin İD'sini Giriniz: ");
                    guncelleID2 = Convert.ToInt32(Console.ReadLine());

                    Kategoriler kat = DB.Kategoriler.Where(x => x.Kategori_Id == guncelleID2).SingleOrDefault();
                    if (kat == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(28, 11);
                        Console.Write("Girmiş Olduğunuz ID Yanlış, ");
                        Console.Write("Tekrar Deneyiniz...");
                        System.Threading.Thread.Sleep(1000);
                        goto enbass;
                    }

                    else if (kat != null)
                    {
                        string KategoriAdi;

                        Console.SetCursorPosition(33, 9);
                        Console.Write("Yeni Kategori İsmini Yazınız: ");
                        KategoriAdi = Console.ReadLine();
                        Console.SetCursorPosition(33, 10);
                        var guncelleKategori = DB.Kategoriler.Find(guncelleID2);
                        guncelleKategori.KategoriAdi = KategoriAdi;
                        DB.SaveChanges();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(33, 12);
                        Console.Write("Müşteriniz Başarıyla Değiştirildi.");
                        Console.SetCursorPosition(33, 13);
                        Console.Write("Kullanıcı Sayfasına Yönlendiriliyorsunuz... ");
                        System.Threading.Thread.Sleep(2000);
                        goto enbass;

                    }

                }
                else if (tercih2 == "4")
                {
                    goto enbass;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(33, 14);
                    Console.Write("Yanlış Değer Girildi...");
                    System.Threading.Thread.Sleep(2000);
                    goto enbass;
                }


            }

            else if (secim == "3")
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                MyName();
                string tercih3;
                Console.SetCursorPosition(33, 4);
                Console.Write("Siparişler Menüsüne Hoş Geldin " + ad);
                Console.SetCursorPosition(4, 5);
                Console.Write("Bu Menüde Siparişler Tablosuna Veri Ekleyebilir, İsterseniz Girilen Verileri Çekebilirsiniz...");
                Console.SetCursorPosition(33, 7);
                Console.Write("1-Tabloya Veri Eklemek İçin");
                Console.SetCursorPosition(33, 8);
                Console.Write("2-Tablo Verilerini Çekmek İçin");
                Console.SetCursorPosition(33, 9);
                Console.Write("3-Verileri Güncellemek İçin");
                Console.SetCursorPosition(33, 10);
                Console.Write("4-Bir Önce Ki Menüye Dönmek İçin");


                Console.SetCursorPosition(33, 12);
                Console.Write("Seçim: ");
                tercih3 = Console.ReadLine();

                if (tercih3 == "1")
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    MyName();
                    int siparisID,musteriID;
                    Console.SetCursorPosition(33, 4);
                    Console.Write("Ekleme Menüsüne Hoş Geldiniz");

                    Console.SetCursorPosition(33, 6);
                    Console.Write("Kontrol Amaçlı Sipariş ID'si Giriniz: ");
                    siparisID = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(33, 7);
                    Console.Write("Müşteri ID'sini Giriniz: ");
                    musteriID = Convert.ToInt32(Console.ReadLine());
                    Siparisler s = DB.Siparisler.Where(x => x.Siparis_Id == siparisID).SingleOrDefault();
                    if (s == null)
                    {
                        Siparisler siparisKayit = new Siparisler();
                        siparisKayit.tarih = DateTime.Now;
                        siparisKayit.Musteri_Id = musteriID;
                        DB.Siparisler.Add(siparisKayit);
                        DB.SaveChanges();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(28, 11);
                        Console.Write("Kayıt İşlemi Başarılı...");
                        Console.SetCursorPosition(28, 12);
                        Console.Write("Kullanıcı Sayfasına Yönlendiriliyorsunuz...");
                        System.Threading.Thread.Sleep(5000);
                        goto enbass;
                    }

                    if (s != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(28, 11);
                        Console.Write("Girmiş Olduğunuz Sipariş ID Bir Başka Verinin Aynısı");
                        Console.SetCursorPosition(35, 12);
                        Console.Write("Tekrar Deneyiniz.");
                        System.Threading.Thread.Sleep(3000);
                        goto enbass;
                    }
                   
                }
                else if (tercih3 == "2")
                {
                    SiparislerVeriCekme(ad);
                }
                else if (tercih3 == "3")
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    MyName();
                    int guncelleID3;
                    Console.SetCursorPosition(33, 4);
                    Console.Write("Güncelleme Menüsüne Hoş Geldiniz");

                    Console.SetCursorPosition(0, 16);
                    var SiparislerListe = DB.Siparisler.ToList();

                    foreach (var item in SiparislerListe)
                    {
                        Console.WriteLine("Sipariş ID:"+item.Siparis_Id+"  Tarih: "+item.tarih+" Müşteri ID: "+item.Musteri_Id);
                    }

                    Console.SetCursorPosition(33, 8);
                    Console.Write("Güncellenecek Siparişin, Sipariş İD'sini Giriniz: ");
                    guncelleID3 = Convert.ToInt32(Console.ReadLine());

                    Siparisler sip = DB.Siparisler.Where(x => x.Siparis_Id == guncelleID3).SingleOrDefault();          
                    if (sip == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(28, 11);
                        Console.Write("Girmiş Olduğunuz ID Yanlış, ");
                        Console.Write("Tekrar Deneyiniz...");
                        System.Threading.Thread.Sleep(1000);
                        goto enbass;
                    }

                    else if (sip != null)
                    {
                        int yeniMüsteriID;

                        Console.SetCursorPosition(33, 9);
                        Console.Write("Yeni Müşteri ID'yi Yazınız: ");
                        yeniMüsteriID = Convert.ToInt32(Console.ReadLine());
                        Console.SetCursorPosition(33, 10);
                        var guncelleSiparis = DB.Siparisler.Find(guncelleID3);
                        guncelleSiparis.Musteri_Id = yeniMüsteriID;
                        DB.SaveChanges();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(33, 12);
                        Console.Write("Müşteriniz Başarıyla Değiştirildi.");
                        Console.SetCursorPosition(33, 13);
                        Console.Write("Kullanıcı Sayfasına Yönlendiriliyorsunuz... ");
                        System.Threading.Thread.Sleep(2000);
                        goto enbass;

                    }

                }
                else if (tercih3== "4")
                {
                    goto enbass;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(33, 14);
                    Console.Write("Yanlış Değer Girildi...");
                    System.Threading.Thread.Sleep(2000);
                    goto enbass;
                }
            }

            else if (secim == "4")
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                MyName();
                string tercih4;
                Console.SetCursorPosition(33, 4);
                Console.Write("Sipariş Detay Menüsüne Hoş Geldin " + ad);
                Console.SetCursorPosition(2, 5);
                Console.Write("Bu Menüde Sipariş Detay Tablosuna Veri Ekleyebilir, İsterseniz Girilen Verileri Çekebilirsiniz...");
                Console.SetCursorPosition(33, 7);
                Console.Write("1-Tabloya Veri Eklemek İçin");
                Console.SetCursorPosition(33, 8);
                Console.Write("2-Tablo Verilerini Çekmek İçin");
                Console.SetCursorPosition(33, 9);
                Console.Write("3-Verileri Güncellemek İçin");
                Console.SetCursorPosition(33, 10);
                Console.Write("4-Bir Önce Ki Menüye Dönmek İçin");


                Console.SetCursorPosition(33, 12);
                Console.Write("Seçim: ");
                tercih4 = Console.ReadLine();

                if (tercih4 == "1")
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    MyName();
                    int SiparisDetayID,Adet,Fiyat,siparisID,urunID;
                    Console.SetCursorPosition(33, 4);
                    Console.Write("Ekleme Menüsüne Hoş Geldiniz");
                    Console.SetCursorPosition(33, 6);
                    Console.Write("Kontrol Amaçlı Sipariş Detay ID'si Giriniz: ");
                    SiparisDetayID = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(33, 7);
                    Console.Write("Sipariş Adet Giriniz: ");
                    Adet = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(33, 8);
                    Console.Write("Sipariş Fiyat Giriniz: ");
                    Fiyat = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(33, 9);
                    Console.Write("Sipariş İD'yi Giriniz: ");
                    siparisID = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(33, 10);
                    Console.Write("Ürün ID'sini Giriniz: ");
                    urunID = Convert.ToInt32(Console.ReadLine());
                    SiparisDetay sd = DB.SiparisDetay.Where(x => x.SDetay_Id == SiparisDetayID).SingleOrDefault();
                    if (sd == null)
                    {
                        Urunler urunlerKontrol = DB.Urunler.Where(x => x.Urun_Id == urunID).FirstOrDefault();

                        if (urunlerKontrol == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(28, 13);
                            Console.Write("Kayıt İşlemi Tamamlanamadı...");
                            Console.SetCursorPosition(28, 14);
                            Console.Write("Ürünler Tablosunda Olmayan Ürün ID'si Girildi...");
                            System.Threading.Thread.Sleep(2000);
                            goto enbass;
                        }

                        else if(urunlerKontrol!= null)
                        {
                            Siparisler siparisKontrol = DB.Siparisler.Where(x => x.Siparis_Id == siparisID).FirstOrDefault(); // Bu kısımda 3 tane kontrol yaptım. Sipariş ID'si olmayan bir sipariş oluşturulamaz. Aynı şekilde Ürün ID'si olmayan bir ürünün de sipariş detayı oluşturulamaz.
                            // Bu kontrolleri yaparken çok şey öğrendim fakat bunları yazmış olmama rağmen bazen hata veriyor.

                            if (urunlerKontrol==null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(28, 13);
                                Console.Write("Kayıt İşlemi Tamamlanamadı...");
                                Console.SetCursorPosition(28, 14);
                                Console.Write("Siparişler Tablosunda Olmayan Sipariş ID'si Girildi...");
                                System.Threading.Thread.Sleep(2000);
                                goto enbass;
                            }
                            else if(urunlerKontrol != null)
                            {

                                SiparisDetay siparisdetayKayit = new SiparisDetay();
                                siparisdetayKayit.Adet = Adet;
                                siparisdetayKayit.Fiyat = Fiyat;
                                siparisdetayKayit.Siparis_Id = siparisID;
                                siparisdetayKayit.Urun_Id = urunID;
                                DB.SiparisDetay.Add(siparisdetayKayit);
                                DB.SaveChanges();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.SetCursorPosition(28, 13);
                                Console.Write("Kayıt İşlemi Başarılı...");
                                Console.SetCursorPosition(28, 14);
                                Console.Write("Kullanıcı Sayfasına Yönlendiriliyorsunuz...");
                                System.Threading.Thread.Sleep(3000);
                                goto enbass;
                            }
                           
                        }
                       
                    }

                    if (sd != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(28, 13);
                        Console.Write("Girmiş Olduğunuz Sipariş ID Bir Başka Verinin Aynısı");
                        Console.SetCursorPosition(35, 14);
                        Console.Write("Tekrar Deneyiniz.");
                        System.Threading.Thread.Sleep(3000);
                        goto enbass;
                    }
                }
                else if (tercih4 == "2")
                {
                    SiparisDetayVeriCekme(ad);

                }
                else if (tercih4 == "3")
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    MyName();
                    int guncelleID4;
                    Console.SetCursorPosition(33, 4);
                    Console.Write("Güncelleme Menüsüne Hoş Geldiniz");

                    Console.SetCursorPosition(0, 16);
                    var SiparisDetayListe = DB.SiparisDetay.ToList();

                    foreach (var item in SiparisDetayListe)
                    {
                        Console.WriteLine("S.Detay ID "+item.SDetay_Id+" Sipariş ID: "+item.Siparis_Id+" Adet: "+item.Adet+" Fiyat: "+item.Fiyat);
                    }

                    Console.SetCursorPosition(25, 8);
                    Console.Write("Güncellenecek Sipariş Detayın, S.Detay İD'sini Giriniz: ");
                    guncelleID4 = Convert.ToInt32(Console.ReadLine());
                    SiparisDetay sdet = DB.SiparisDetay.Where(x => x.SDetay_Id == guncelleID4).SingleOrDefault();
                    if (sdet == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(28, 11);
                        Console.Write("Girmiş Olduğunuz ID Yanlış, ");
                        Console.Write("Tekrar Deneyiniz...");
                        System.Threading.Thread.Sleep(1000);
                        goto enbass;
                    }

                    else if (sdet != null)
                    {
                        int yeniAdet, yeniFiyat;

                        Console.SetCursorPosition(33, 9);
                        Console.Write("Yeni Fiyatı Yazınız: ");
                        yeniFiyat = Convert.ToInt32(Console.ReadLine());
                        Console.SetCursorPosition(33, 10);
                        Console.Write("Yeni Adeti Yazınız: ");
                        yeniAdet = Convert.ToInt32(Console.ReadLine());
                       
                        var guncelleSiparisDetay = DB.SiparisDetay.Find(guncelleID4);
                        guncelleSiparisDetay.Fiyat = yeniFiyat;
                        guncelleSiparisDetay.Adet = yeniAdet;
                        DB.SaveChanges();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(33, 12);
                        Console.Write("Müşteriniz Başarıyla Değiştirildi.");
                        Console.SetCursorPosition(33, 13);
                        Console.Write("Kullanıcı Sayfasına Yönlendiriliyorsunuz... ");
                        System.Threading.Thread.Sleep(2000);
                        goto enbass;



                    }


                }
                else if (tercih4 == "4")
                {
                    goto enbass;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(33, 14);
                    Console.Write("Yanlış Değer Girildi...");
                    System.Threading.Thread.Sleep(2000);
                    goto enbass;
                }
            }

            else if (secim == "5")
            {
                
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                MyName();
                string tercih4;
                Console.SetCursorPosition(33, 4);
                Console.Write("Ürünler Menüsüne Hoş Geldin " + ad);
                Console.SetCursorPosition(2, 5);
                Console.Write("Bu Menüde Ürünler Tablosuna Veri Ekleyebilir, İsterseniz Girilen Verileri Çekebilirsiniz...");
                Console.SetCursorPosition(33, 7);
                Console.Write("1-Tabloya Veri Eklemek İçin");
                Console.SetCursorPosition(33, 8);
                Console.Write("2-Tablo Verilerini Çekmek İçin");
                Console.SetCursorPosition(33, 9);
                Console.Write("3-Verileri Güncellemek İçin");
                Console.SetCursorPosition(33, 10);
                Console.Write("4-Bir Önce Ki Menüye Dönmek İçin");

                Console.SetCursorPosition(33, 12);
                Console.Write("Seçim: ");
                tercih4 = Console.ReadLine();

                if (tercih4 == "1")
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    MyName();
                    int UrunID, urunFiyat, urunStok, kategoriID;
                    string UrunAdi;
                    Console.SetCursorPosition(33, 4);
                    Console.Write("Ekleme Menüsüne Hoş Geldiniz");

                    Console.SetCursorPosition(33, 6);
                    Console.Write("Kontrol Amaçlı Ürün ID'si Giriniz: ");
                    UrunID = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(33, 7);
                    Console.Write("Ürünün İsmini Giriniz: ");
                    UrunAdi = Console.ReadLine();
                    Console.SetCursorPosition(33, 8);
                    Console.Write("Ürünün Fiyatını Giriniz: ");
                    urunFiyat = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(33, 9);
                    Console.Write("Ürünün Stok Miktarını Giriniz: ");
                    urunStok = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(33, 10);
                    Console.Write("Ürünün Kategori ID'sini Giriniz: ");
                    kategoriID = Convert.ToInt32(Console.ReadLine());

                    Kategoriler KategoriKontrol = DB.Kategoriler.Where(x => x.Kategori_Id == kategoriID).SingleOrDefault(); // EĞER ÜRÜN GİRİLİRKEN KATEGORİ ID'Sİ BULUNAMAZ İSE KAYIT GİRİLMEZ !!! KATEGORİSİ OLMAYAN BİR ÜRÜN OLAMAZ!!!
                    if (KategoriKontrol==null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(28, 12);
                        Console.Write("Girmiş Olduğunuz Kategori ID'si Bulunamadı");
                        Console.SetCursorPosition(35, 13);
                        Console.Write("Tekrar Deneyiniz.");
                        System.Threading.Thread.Sleep(3000);
                        goto enbass;
                    }

                    else if (KategoriKontrol !=null)
                    {
                        Urunler urunler = DB.Urunler.Where(x => x.Urun_Id == UrunID).SingleOrDefault();

                        if (urunler==null)
                        {
                            Urunler urunlerKayit = new Urunler();
                            urunlerKayit.UrunAdi = UrunAdi;
                            urunlerKayit.UrunFiyat = urunFiyat;
                            urunlerKayit.UrunStok = urunStok;
                            urunlerKayit.Kategori_Id = kategoriID;
                            DB.Urunler.Add(urunlerKayit);
                            DB.SaveChanges();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(28, 12);
                            Console.Write("Kayıt İşlemi Başarılı...");
                            Console.SetCursorPosition(28, 13);
                            Console.Write("Kullanıcı Sayfasına Yönlendiriliyorsunuz...");
                            System.Threading.Thread.Sleep(5000);
                            goto enbass;
                        }

                        else if (urunler != null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(28, 12);
                            Console.Write("Girmiş Olduğunuz Urun ID Bir Başka Verinin Aynısı");
                            Console.SetCursorPosition(35, 13);
                            Console.Write("Tekrar Deneyiniz.");
                            System.Threading.Thread.Sleep(3000);
                            goto enbass;
                        }

                    }
                   
                   
                }
                else if (tercih4 == "2")
                {
                    UrunlerVeriCekme(ad);
                }
                else if (tercih4 == "3")
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    MyName();
                    int guncelleID5, urunFiyat, urunStok, kategoriID;
                    string urunAdi;
                    Console.SetCursorPosition(33, 4);
                    Console.Write("Güncelleme Menüsüne Hoş Geldiniz");

                    Console.SetCursorPosition(0, 18);
                    var UrunlerListe = DB.Urunler.ToList();

                    foreach (var item in UrunlerListe)
                    {
                        Console.WriteLine("Ürün ID:" + item.Urun_Id + "  Ürün Adı: " + item.UrunAdi + " Ürün Fiyat: " + item.UrunFiyat+" Ürün Stok: "+item.UrunStok+" Kategori ID: "+item.Kategori_Id);
                    }

                    Console.SetCursorPosition(33, 8);
                    Console.Write("Güncellenecek Ürünün, Ürün İD'sini Giriniz: ");
                    guncelleID5 = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(33, 9);
                    Console.Write("Kategori ID'sini Giriniz: ");
                    kategoriID = Convert.ToInt32(Console.ReadLine());

                    Kategoriler KategoriKontrol = DB.Kategoriler.Where(x => x.Kategori_Id == kategoriID).SingleOrDefault();

                    if (KategoriKontrol==null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(28, 14);
                        Console.Write("Girmiş Olduğunuz Kategori ID Uyuşmuyor, ");
                        Console.Write("Tekrar Deneyiniz...");
                        System.Threading.Thread.Sleep(1000);
                        goto enbass;
                    }
                    else if (KategoriKontrol!=null)
                    {

                        Urunler urunKontrol = DB.Urunler.Where(x => x.Urun_Id == guncelleID5).SingleOrDefault();

                        if (urunKontrol==null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(28, 11);
                            Console.Write("Girmiş Olduğunuz ID Yanlış, ");
                            Console.Write("Tekrar Deneyiniz...");
                            System.Threading.Thread.Sleep(1000);
                            goto enbass;                          
                        }

                        if (urunKontrol!=null)
                        {
                            int yeniMüsteriID;

                            Console.SetCursorPosition(33, 10);
                            Console.Write("Yeni Ürün İsmini Giriniz: ");
                            urunAdi = Console.ReadLine();
                            Console.SetCursorPosition(33, 11);
                            Console.Write("Yeni Fiyatı Giriniz: ");
                            urunFiyat = Convert.ToInt32(Console.ReadLine());
                            Console.SetCursorPosition(33, 12);
                            Console.Write("Yeni Ürün Stoğu Giriniz: ");
                            urunStok = Convert.ToInt32(Console.ReadLine());
                            var guncelleUrun = DB.Urunler.Find(guncelleID5);
                            guncelleUrun.UrunAdi = urunAdi;
                            guncelleUrun.UrunFiyat = urunFiyat;
                            guncelleUrun.UrunStok = urunStok;
                            guncelleUrun.Kategori_Id = kategoriID;
                            DB.SaveChanges();
                           
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(33, 15);
                            Console.Write("Müşteriniz Başarıyla Değiştirildi.");
                            Console.SetCursorPosition(33, 16);
                            Console.Write("Kullanıcı Sayfasına Yönlendiriliyorsunuz... ");
                            System.Threading.Thread.Sleep(2000);
                            goto enbass;
                        }

                    }
                   
                }
                else if(tercih4 == "4")
                {
                    goto enbass;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(33, 14);
                    Console.Write("Yanlış Değer Girildi...");
                    System.Threading.Thread.Sleep(2000);
                    goto enbass;
                }

            }

            else if (secim == "6")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(35, 17);
                Console.Write("Giriş Sayfasına Yönlendiriliyorsunuz.");
                System.Threading.Thread.Sleep(2000);
                GirisSayfasi();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(40, 15);
                Console.Write("Girmiş Olduğunuz Veri Yanlış...");
                System.Threading.Thread.Sleep(2000);
                goto enbass;
            }

        }// Normal kullanıcı arayüzü!!!
        public static void MusterilerVeriCekme(string ad)
        {
        enbas:
            ReenaDBEntities DB = new ReenaDBEntities();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            MyName();
            string secim;
            Console.SetCursorPosition(33, 4);
            Console.Write("Müşteriler Veri Çekme Menüsüne Hoş Geldin "+ad);
            Console.SetCursorPosition(27, 7);
            Console.Write("1-Bütün Tabloyu Çek");
            Console.SetCursorPosition(27, 8);
            Console.Write("2-Sadece Telefon Kolonunu Çek");
            Console.SetCursorPosition(27, 9);
            Console.Write("3-Sadece İsim Soy İsim Çek");
            Console.SetCursorPosition(27, 10);
            Console.Write("4-İsminde İçeren Harfe Göre Çek");
            Console.SetCursorPosition(27, 11);
            Console.Write("5-Sadece İsime Göre Çek");
            Console.SetCursorPosition(27, 12);
            Console.Write("6-Kullanıcı Sayfasına Dönmek İçin");
            Console.SetCursorPosition(32, 14);
            Console.Write("Seçim: ");
            secim = Console.ReadLine();

            if (secim == "1")
            {
                var musteriler = DB.Musteriler.ToList();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(0, 17);
                foreach (var item in musteriler)
                {
                    Console.WriteLine(item.MusteriAdi + " " + item.MusteriSoyadi + " " + item.Telofon);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 14);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;
            }

            if (secim == "2")
            {
                var musteriler = DB.Musteriler.ToList();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(0, 17);
                foreach (var item in musteriler)
                {
                    Console.WriteLine(item.Telofon);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 14);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;
            }

            if (secim == "3")
            {
                var musteriler = DB.Musteriler.ToList();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(0, 17);
                foreach (var item in musteriler)
                {
                    Console.WriteLine(item.MusteriAdi + " " + item.MusteriSoyadi);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 14);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;
            }

            if (secim == "4")
            {
                string basharf;
                Console.SetCursorPosition(32, 15);
                Console.Write("Lütfen Harfi Giriniz: ");
                basharf = Console.ReadLine();
                if (basharf == null)
                {
                    Console.SetCursorPosition(32, 16);
                    Console.Write("Burayı Boş Bırakamazsınız!!!");
                    Console.SetCursorPosition(32, 17);
                    Console.Write("Devam Etmek İçin Enter'e Basınız");
                    Console.ReadLine();
                    goto enbas;
                }
                List<Musteriler> musterilerr = DB.Musteriler.Where(s => s.MusteriAdi.Contains(basharf)).ToList();

                if (musterilerr.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(15, 16);
                    Console.Write("Bu Harf İçeren Veri Yok... Devam Etmek İçin Enter'e Basınız");
                    Console.ReadLine();
                    goto enbas;
                }

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(0, 17);
                foreach (var item in musterilerr)
                {
                    Console.WriteLine(item.MusteriAdi + " " + item.MusteriSoyadi + " " + item.Telofon);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 16);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;

            }
            if (secim == "5")
            {
                string isim;
                Console.SetCursorPosition(32, 15);
                Console.Write("Lütfen İsmi Giriniz: ");
                isim = Console.ReadLine();
                if (isim == null)
                {
                    Console.SetCursorPosition(32, 16);
                    Console.Write("Burayı Boş Bırakamazsınız!!!");
                    Console.SetCursorPosition(32, 17);
                    Console.Write("Devam Etmek İçin Enter'e Basınız");
                    Console.ReadLine();
                    goto enbas;
                }

                List<Musteriler> musteriler3 = DB.Musteriler.Where(s => s.MusteriAdi == isim).ToList();

                if (musteriler3.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(15, 16);
                    Console.Write("Bu İsmi İçeren Veri Yok ... Devam Etmek İçin Enter'e Basınız");
                    Console.ReadLine();
                    goto enbas;
                }

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(0, 17);
                foreach (var item in musteriler3)
                {
                    Console.WriteLine(item.MusteriAdi + " " + item.MusteriSoyadi + " " + item.Telofon);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 16);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;
            }
            if (secim == "6")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 15);
                Console.Write("Kullanıcı Sayfasına Yönlendiriliyorsunuz");
                System.Threading.Thread.Sleep(2000);
                KullaniciSayfa(ad);

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(27, 20);
                Console.Write("Girmiş Olduğunuz Değer Yanlış...");
                System.Threading.Thread.Sleep(2000);
                goto enbas;
            }


        }// Müşteri Verilerini Çekme Sayfası
        public static void KategoriVeriCekme(string ad)
        {
            enbas:
            ReenaDBEntities DB = new ReenaDBEntities();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            MyName();
            string secim;
            Console.SetCursorPosition(33, 4);
            Console.Write("Kategori Veri Çekme Menüsüne Hoş Geldin "+ad);
            Console.SetCursorPosition(27, 7);
            Console.Write("1-Bütün Tabloyu Çek");
            Console.SetCursorPosition(27,8);
            Console.Write("2-Sadece Kategori Adı Kolonunu Çek");
            Console.SetCursorPosition(27, 9);
            Console.Write("3-Kullanıcı Sayfasına Dönmek İçin");
            Console.SetCursorPosition(32, 12);
            Console.Write("Seçim: ");
            secim = Console.ReadLine();
            var Kategoriler = DB.Kategoriler.ToList();

            if (secim == "1")
            {
                
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(0, 17);
                foreach (var item in Kategoriler)
                {
                    Console.WriteLine(item.Kategori_Id+" "+item.KategoriAdi);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 14);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;
            }
            if (secim=="2")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(0, 17);
                foreach (var item in Kategoriler)
                {
                    Console.WriteLine(item.KategoriAdi);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 14);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;
            }
            if (secim=="3")
            {
                KullaniciSayfa(ad);
            }

            else
            {
                Console.SetCursorPosition(27, 14);
                Console.Write("Girmiş Olduğunuz Değer Yanlış...");
                System.Threading.Thread.Sleep(2000);
                goto enbas;
            }
        } // Kategori Verilerini Çekme Sayfası
        public static void SiparislerVeriCekme(string ad)
        {
            enbas:
            ReenaDBEntities DB = new ReenaDBEntities();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            MyName();
            string secim;
            Console.SetCursorPosition(33, 4);
            Console.Write("Siparişler Veri Çekme Menüsüne Hoş Geldin " + ad);
            Console.SetCursorPosition(27, 7);
            Console.Write("1-Bütün Tabloyu Çek");
            Console.SetCursorPosition(27, 8);
            Console.Write("2-Sadece Tarih  Kolonunu Çek");
            Console.SetCursorPosition(27, 9);
            Console.Write("3-Tablo Verisinden X Kadar Atlayıp Çek ( SKİP ): ");
            Console.SetCursorPosition(27, 10);
            Console.Write("4-Tablo Verisinden X Kadarını Çek ( TAKE ): ");
            Console.SetCursorPosition(27, 11);
            Console.Write("5-Kullanıcı Sayfasına Dönmek İçin");
            Console.SetCursorPosition(32, 13);
            Console.Write("Seçim: ");
            secim = Console.ReadLine();
            if (secim=="1")
            {
                Console.SetCursorPosition(0, 18);
                var SiparislerListe = DB.Siparisler.ToList();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                foreach (var item in SiparislerListe)
                {
                    Console.WriteLine("Sipariş ID:" + item.Siparis_Id + "  Tarih: " + item.tarih + " Müşteri ID: " + item.Musteri_Id);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 15);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;

            }

            else if (secim=="2")
            {
                Console.SetCursorPosition(0, 18);
                var SiparislerListe = DB.Siparisler.ToList();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                foreach (var item in SiparislerListe)
                {
                    Console.WriteLine("  Tarih: " + item.tarih);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 15);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;
            }

            else if(secim=="3")
            {
                int skip;
                Console.SetCursorPosition(32, 14);
                Console.Write("X: ");
                skip = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(0, 18);
                List<Siparisler> siparisslerr = DB.Siparisler.OrderBy(s => s.Siparis_Id).Skip(skip).ToList();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                foreach (var item in siparisslerr)
                {
                    Console.WriteLine("Sipariş ID:" + item.Siparis_Id + "  Tarih: " + item.tarih + " Müşteri ID: " + item.Musteri_Id);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 16);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;
            }

            else if (secim=="4")
            {
                int take;
                Console.SetCursorPosition(32, 14);
                Console.Write("Take: ");
                take = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(0, 18);
                List<Siparisler> siparisslerr = DB.Siparisler.OrderBy(s => s.Siparis_Id).Take(take).ToList();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                foreach (var item in siparisslerr)
                {
                    Console.WriteLine("Sipariş ID:" + item.Siparis_Id + "  Tarih: " + item.tarih + " Müşteri ID: " + item.Musteri_Id);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 16);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;
            }

            else if (secim == "5")
            {
                KullaniciSayfa(ad);
            }

            else
            {
                Console.SetCursorPosition(27, 14);
                Console.Write("Girmiş Olduğunuz Değer Yanlış...");
                System.Threading.Thread.Sleep(2000);
                goto enbas;
            }

        } // Siparisler Verilerini Çekme Sayfası
        public static void SiparisDetayVeriCekme(string ad)
        {
            enbas:
            ReenaDBEntities DB = new ReenaDBEntities();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            MyName();
            string secim;
            Console.SetCursorPosition(33, 4);
            Console.Write("Sipariş Detay Veri Çekme Menüsüne Hoş Geldin " + ad);
            Console.SetCursorPosition(27, 7);
            Console.Write("1-Bütün Tabloyu Çek ( TO ARRAY )");
            Console.SetCursorPosition(27, 8);
            Console.Write("2-Toplam Sipariş Detay Bilgisini Çek ( COUNT )");
            Console.SetCursorPosition(27, 9);
            Console.Write("3-Toplam Fiyat Miktarını Çek  ( SUM )");
            Console.SetCursorPosition(27, 10);
            Console.Write("4-Ortalama Fiyat Miktarını Seç  ( AVG )");
            Console.SetCursorPosition(27, 11);
            Console.Write("5-Kullanıcı Sayfasına Dönmek İçin");
            Console.SetCursorPosition(32, 14);
            Console.Write("Seçim: ");
            secim = Console.ReadLine();

            if (secim== "1")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                var SiparisDetay = DB.SiparisDetay.ToArray();
                Console.SetCursorPosition(0, 20);
                foreach (var item in SiparisDetay)
                {
                    Console.WriteLine("S.Detay ID: " + item.SDetay_Id + " Adet: " + item.Adet + " Fiyat: " + item.Fiyat + " Sipariş ID: " + item.Siparis_Id + " Urun ID: " + item.Urun_Id);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 16);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;

            }
            else if(secim=="2")
            {

                int SiparisDetayCount = (from i in DB.SiparisDetay where i.Siparis_Id>0 select i).Count();  // Kolonu saydırmak için sipariş detay ID'si 0 dan büyük olanları çektim. Zaten hepsi 0 dan büyük olduğu için hepsini saydı :D.
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(20, 16);
                Console.Write("Toplam Sipariş Detay Sayısı ( COUNT ) = " + SiparisDetayCount);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 18);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;

            }
            else if (secim=="3")
            {
                decimal siparisdetaysum = (from i in DB.SiparisDetay select i.Fiyat.Value).Sum();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(20, 16);
                Console.Write("Toplam Fiyat Miktarı ( SUM ) = " + siparisdetaysum);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 18);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;


            }
            else if (secim =="4")
            {

                double siparisdetayAvg = (from i in DB.SiparisDetay select i.Fiyat.Value).Average();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(20, 16);
                Console.Write(" Fiyat Ortalaması ( AVG ) = " + siparisdetayAvg);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 18);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;
            }
            else if(secim=="5")
            {
                KullaniciSayfa(ad);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(40, 15);
                Console.Write("Girmiş Olduğunuz Veri Yanlış...");
                System.Threading.Thread.Sleep(2000);
                goto enbas;
            }

        } // Sipariş Detay Verilerini Çekme Sayfası
        public static void UrunlerVeriCekme(string ad)
        {
        enbas:
            ReenaDBEntities DB = new ReenaDBEntities();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            MyName();
            string secim;
            Console.SetCursorPosition(33, 4);
            Console.Write("Ürünler Veri Çekme Menüsüne Hoş Geldin " + ad);
            Console.SetCursorPosition(27, 7);
            Console.Write("1-Bütün Tabloyu Çek ( TO ARRAY )");
            Console.SetCursorPosition(27, 8);
            Console.Write("2-Toplam Ürünler ( COUNT )");
            Console.SetCursorPosition(27, 9);
            Console.Write("3-Kategoriler Tablosu İle Ürünler Tablosu ( InnerJoin )");
            Console.SetCursorPosition(27, 10);
            Console.Write("4-Ortalama Fiyat Miktarını Seç  ( AVG )");
            Console.SetCursorPosition(27, 11);
            Console.Write("5-Kategori ID'ye Göre Sıralanmış ( GROUP BY ) ");
            Console.SetCursorPosition(27, 12);
            Console.Write("6-Kullanıcı Sayfasına Dönmek İçin");
            Console.SetCursorPosition(32, 14);
            Console.Write("Seçim: ");
            secim = Console.ReadLine();

            if (secim=="1")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                var Urunlerss = DB.Urunler.ToArray();
                Console.SetCursorPosition(0, 20);
                foreach (var item in Urunlerss)
                {
                    Console.WriteLine("Ürün ID: "+item.Urun_Id+" Ürün Adı: "+item.UrunAdi+" Ürün Fiyat: "+item.UrunFiyat+" Ürün Stok: "+item.UrunStok+" Kategori ID: "+item.Kategori_Id);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 16);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;
            }
            else if(secim=="2")
            {
                int UrunCount = (from i in DB.Urunler where i.Urun_Id > 0 select i).Count(); // Kolonu saydırmak için urun ID'si 0 dan büyük olanları çektim. Zaten hepsi 0 dan büyük olduğu için hepsini saydı :D.         
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(20, 16);
                Console.Write("Toplam Ürünler ( COUNT ) = " + UrunCount);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 18);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;
            }
            else if(secim=="3")
            {
                var joinKategori = (from i in DB.Urunler
                                    join x in DB.Kategoriler
                                    on i.Urun_Id equals x.Kategori_Id
                                    select new
                                    {
                                        UrunAdi = i.UrunAdi,
                                        KategoriAdi = x.KategoriAdi
                                    }).ToList();
                Console.SetCursorPosition(0, 20);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                foreach (var item in joinKategori)
                {
                    Console.WriteLine("Ürün Adı: " + item.UrunAdi + " Kategori Adı: " + item.KategoriAdi);
                }


                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 18);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;


            }
            else if(secim=="4")
            {
                double urunAvg = (from i in DB.Urunler select i.UrunFiyat.Value).Average();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(20, 16);
                Console.Write(" Ortalama Fiyat ( AVG ) = " + urunAvg);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 18);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;
            }
            else if(secim=="5")
            {
                //var urunlerGroup = (from i in DB.Urunler
                //                    group i by i.Kategori_Id into g
                //                    select new
                //                    {
                //                        KategoriID = g.Key,
                //                        Count = g.Count()
                //                    }).ToList();

                var UrunlerGroup2 = from Urunler in DB.Urunler group Urunler by Urunler.UrunAdi;

                Console.SetCursorPosition(0, 20);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                foreach (var item in UrunlerGroup2)
                {
                    Console.WriteLine(item.Key, item.Count(x=> x.Kategori_Id>0));
                }


                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(27, 18);
                Console.Write("Devam Etmek İçin Enter'e Basınız");
                Console.ReadLine();
                goto enbas;

            }
            else if (secim == "6")
            {
                KullaniciSayfa(ad);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(40, 15);
                Console.Write("Girmiş Olduğunuz Veri Yanlış...");
                System.Threading.Thread.Sleep(2000);
                goto enbas;
            }

        }// Ürünlerin Verilerini Çekme Sayfası
        public static void AdminAnaSayfa()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;// Burada White Yaptım Aşağıda yeşil. Çünkü MyName metodu geldiğinde siyah renginde yazmasını istiyorum. Aşağıda yeşil
            MyName();
            Console.ForegroundColor = ConsoleColor.Green;
            string secim;
            Console.SetCursorPosition(35, 5);
            Console.Write("Admin Paneline Hoş Geldiniz ");
            Console.SetCursorPosition(27, 6);
            Console.Write("Unutmayın Ki Veri Silmek Sadece Admin'e Mahsustur...");
            Console.SetCursorPosition(10, 10);
            Console.Write("Bu Panelde Normal Kullanıcıların Yetkisi Olmayan Kontrolleri Gerçekleştirebilirsiniz.");
            Console.SetCursorPosition(35, 12);
            Console.Write("1-Kullanıcı Silmek İçin");
            Console.SetCursorPosition(35, 13);
            Console.Write("2-Tablo İçi Verileri Silmek İçin");
            Console.SetCursorPosition(35, 14);
            Console.Write("3-Giriş Sayfasına Dönmek İçin");
            Console.SetCursorPosition(45, 16);
            secim = Console.ReadLine();

            if (secim=="1")
            {
                Silmeİslemi();
            }
            else if (secim=="2")
            {
                TabloVeriSilme();
            }
            else if (secim =="3")
            {
                Console.SetCursorPosition(32, 20);
                Console.WriteLine("Giriş Sayfasına Yönlendiriliyorsunuz.");
                System.Threading.Thread.Sleep(3000);
                GirisSayfasi();
            }
            else
            {

                Console.SetCursorPosition(20, 20);
                Console.Write("Girmiş Olduğunuz Değer Yanlış. Admin Paneline Yönlendiriliyorsunuz");
                System.Threading.Thread.Sleep(2000);
                AdminAnaSayfa();
            }
        }  // Admin kullanıcı arayüzü !!!
        public static void Silmeİslemi()
        {
            ReenaDBEntities DB = new ReenaDBEntities();
            string KullaniciAdi;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            MyName();
            Console.SetCursorPosition(35, 5);
            Console.Write("Kullanıcı Silme Menüsüne Hoş Geldiniz...");

            var ornek = DB.Kullanici.Where(o => o.KullanıcıAdı != "admin").ToList(); // ADMİN kullanıcısını listeye koymadım. Çünkü admin hesabı silinir ise Admin paneline giriş yapamayız!!!!
            Console.SetCursorPosition(0, 10);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            foreach (var item in ornek)
                {
                    Console.WriteLine(item.KullanıcıAdı);
                }
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(33, 7);
            Console.Write("Silmek İstediğiniz Kullanıcının Adını Yazınız: ");
            KullaniciAdi = Console.ReadLine();

            Kullanici k = DB.Kullanici.Where(x => x.KullanıcıAdı == KullaniciAdi).SingleOrDefault();

            if (k==null)
            {
                Console.SetCursorPosition(29, 9);
                Console.Write("Girmiş Olduğunuz İsim Uyuşmuyor. Lütfen Tekrar Deneyiniz...");
                System.Threading.Thread.Sleep(3000);
                AdminAnaSayfa();
            }
            else if (k!=null)
            {

                Kullanici silme = (from i in DB.Kullanici where i.KullanıcıAdı == KullaniciAdi select i).SingleOrDefault();
                DB.Kullanici.Remove(silme);
                DB.SaveChanges();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(29, 9);
                Console.Write("Kayıt Silinmiştir. Admin Paneline Yönlendiriliyorsunuz...");
                System.Threading.Thread.Sleep(3000);
                AdminAnaSayfa();
            }
        }  // Admin Kullanıcı Silme İşlemi !!!
        public static void TabloVeriSilme()
        {
            ReenaDBEntities DB = new ReenaDBEntities();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            MyName();
            string tercih;
            Console.SetCursorPosition(33, 4);
            Console.Write("Tablodan Veri Silme Bölümüne Hoş Geldiniz.");
            Console.SetCursorPosition(33, 5);
            Console.Write("Hangi Tablodan Veri Silmek İstersiniz");
            Console.SetCursorPosition(40, 8);
            Console.Write("1-Kategoriler");
            Console.SetCursorPosition(40, 9);
            Console.Write("2-Müşteriler");
            Console.SetCursorPosition(40, 10);
            Console.Write("3-Ürünler");
            Console.SetCursorPosition(40, 11);
            Console.Write("4-Siparişler");
            Console.SetCursorPosition(40, 12);
            Console.Write("5-Sipariş Detay");
            Console.SetCursorPosition(40, 13);
            Console.Write("6-Admin Paneline Dönmek İçin");
            Console.SetCursorPosition(40, 15);
            Console.Write("Seçim: ");
            tercih = Console.ReadLine();

            if (tercih == "1")
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                MyName();
                string kategoriadi;
                Console.SetCursorPosition(33, 4);
                Console.Write("Kategoriler Menüsüne Hoş Geldiniz.");
                var kategoriler = DB.Kategoriler.ToList();
                Console.SetCursorPosition(0, 12);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                foreach (var item in kategoriler)
                {
                    Console.WriteLine(item.KategoriAdi);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(30, 5);
                Console.Write("Silmek İstediğiniz Kategoriyi Yazınız: ");
                kategoriadi = Console.ReadLine();
                Kategoriler k = DB.Kategoriler.Where(x => x.KategoriAdi == kategoriadi).SingleOrDefault();

                if (k == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(25, 8);
                    Console.Write("Girmiş Olduğunuz İsim Uyuşmuyor. Lütfen Tekrar Deneyiniz...");
                    System.Threading.Thread.Sleep(3000);
                    AdminAnaSayfa();
                }

                if (k != null)
                {
                    Kategoriler silme1 = (from i in DB.Kategoriler where i.KategoriAdi == kategoriadi select i).SingleOrDefault();// Burada sileceğimiz veriyi buluypruz. Kategoriler tablosundan kontrol ediyoruz.
                    Urunler koşul2 = (from i in DB.Urunler where i.Kategori_Id == silme1.Kategori_Id select i).FirstOrDefault(); // Burası çok incedir ki, Kategori ID'si ürünler tablosunda yer alan kategorilerin silinme işlemi gerçekleştirilemez. Sebebi Ürünü olan bir kategoriyi silemeyiz!!! 
                    // Diğer bir ince konu ise şudur ki, FirstOrDefault. Ürünler tablosunda belki de 2 tane ürünü olabilir seçeceğimiz kişinin. Bu yüzden FirstOrDefault diyoruz, ilk veriyi alsın getirsin. Zaten ben uyuşan veri var mı ona bakıyorum kaç tane olacağı benim için önemli değil. Eğer bu değişkende 2 veri döenrse hata alırız. Bu yüzden tek veri alıyoruz.
                   
                        if (koşul2 == null)
                    {

                        DB.Kategoriler.Remove(silme1);
                        DB.SaveChanges();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(30, 7);
                        Console.Write("Silme İşlemi Başarıyla Gerçekleşti.");
                        Console.SetCursorPosition(30, 8);
                        Console.Write("Admin Paneline Yönlendiriliyorsunuz...");
                        System.Threading.Thread.Sleep(3000);
                        AdminAnaSayfa();
                    }

                    else if (koşul2 != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(30, 8);
                        Console.Write("Silme İşlemi Gerçekleşmedi.");
                        Console.SetCursorPosition(25, 9);
                        Console.Write("Ürünü Olan Bir Kategori Silinemez. Lütfen Ürünleri Siliniz...");
                        System.Threading.Thread.Sleep(3000);
                        AdminAnaSayfa();
                    }

                }





            }
            else if (tercih == "2")
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                MyName();
                string musteriadi, musterisoyad;
                Console.SetCursorPosition(33, 4);
                Console.Write("Müşteriler Menüsüne Hoş Geldiniz.");
                var müsteriler = DB.Musteriler.ToList();
                Console.SetCursorPosition(0, 12);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                foreach (var item in müsteriler)
                {
                    Console.WriteLine(item.MusteriAdi + " " + item.MusteriSoyadi);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(30, 5);
                Console.Write("Silmek İstediğiniz Müşterinin Adı: ");
                musteriadi = Console.ReadLine();
                Console.SetCursorPosition(30, 6);
                Console.Write("Silmek İstediğiniz Müşterinin Soyadı: ");
                musterisoyad = Console.ReadLine();
                Musteriler m = DB.Musteriler.Where(x => x.MusteriAdi == musteriadi && x.MusteriSoyadi == musterisoyad).SingleOrDefault(); // Burada ise girilen veri benim tablomda var mı yok mu onu kontrol ediyorum.

                if (m == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(25, 8);
                    Console.Write("Girmiş Olduğunuz İsim Uyuşmuyor. Lütfen Tekrar Deneyiniz...");
                    System.Threading.Thread.Sleep(3000);
                    AdminAnaSayfa();
                }

                if (m != null)
                {
                    Musteriler silme2 = (from i in DB.Musteriler where i.MusteriAdi == musteriadi && i.MusteriSoyadi == musterisoyad select i).SingleOrDefault(); // Burada sileceğimiz veriyi buluypruz. Müşteriler tablosundan kontrol ediyoruz.
                    Siparisler koşul = (from i in DB.Siparisler where i.Musteri_Id == silme2.Musteri_Id select i).FirstOrDefault(); // Burası çok incedir ki, Müşteri ID'si sipariş tablosunda yer olan müşterilerin silinme işlemi gerçekleştirilemez. Sebebi siparişi olan bir müşteriyi silemeyiz!!! 
                    // Diğer bir ince konu ise şudur ki, FirstOrDefault. Siparişler tablosunda belki de 2 tane siparişi olabilir seçeceğimiz kişinin. Bu yüzden FirstOrDefault diyoruz, ilk veriyi alsın getirsin. Zaten ben uyuşan veri var mı ona bakıyorum kaç tane olacağı benim için önemli değil. Eğer bu değişkende 2 veri döenrse hata alırız. Bu yüzden tek veri alıyoruz.
                    if (koşul == null)
                    {
                        DB.Musteriler.Remove(silme2);
                        DB.SaveChanges();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(30, 8);
                        Console.Write("Silme İşlemi Başarıyla Gerçekleşti.");
                        Console.SetCursorPosition(30, 9);
                        Console.Write("Admin Paneline Yönlendiriliyorsunuz...");
                        System.Threading.Thread.Sleep(3000);
                        AdminAnaSayfa();
                    }
                    else if (koşul != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(30, 8);
                        Console.Write("Silme İşlemi Gerçekleşmedi.");
                        Console.SetCursorPosition(30, 9);
                        Console.Write("Siparişi Olan Bir Müşteri Silinemez...");
                        System.Threading.Thread.Sleep(3000);
                        AdminAnaSayfa();
                    }
                }

            }
            else if (tercih == "3")
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                MyName();
                int urunID;
                Console.SetCursorPosition(33, 4);
                Console.Write("Ürünler Menüsüne Hoş Geldiniz.");
                var urunler = DB.Urunler.ToList();
                Console.SetCursorPosition(0, 12);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                foreach (var item in urunler)
                {
                    Console.WriteLine(item.Urun_Id + " " + item.UrunAdi + " " + item.UrunFiyat + "TL");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(30, 5);
                Console.Write("Silmek İstediğiniz Ürünün ID'sini Yazınız: ");
                urunID = Convert.ToInt32(Console.ReadLine());
                Urunler u = DB.Urunler.Where(x => x.Urun_Id == urunID).SingleOrDefault();
                if (u == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(25, 8);
                    Console.Write("Girmiş Olduğunuz ID Uyuşmuyor. Lütfen Tekrar Deneyiniz...");
                    System.Threading.Thread.Sleep(3000);
                    AdminAnaSayfa();
                }

                if (u != null)
                {
                    Urunler silme3 = (from i in DB.Urunler where i.Urun_Id == urunID select i).SingleOrDefault();
                    SiparisDetay koşul3 = (from i in DB.SiparisDetay where i.Urun_Id == urunID select i).FirstOrDefault();
                    if (koşul3 == null)
                    {
                        DB.Urunler.Remove(silme3);
                        DB.SaveChanges();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(30, 7);
                        Console.Write("Silme İşlemi Başarıyla Gerçekleşti.");
                        Console.SetCursorPosition(30, 8);
                        Console.Write("Admin Paneline Yönlendiriliyorsunuz...");
                        System.Threading.Thread.Sleep(3000);
                        AdminAnaSayfa();
                    }

                    else if (koşul3 != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(30, 7);
                        Console.Write("Silme İşlemi Gerçekleşmedi.");
                        Console.SetCursorPosition(30, 8);
                        Console.Write("Siparişi Olan Bir Ürün Silinemez...");
                        System.Threading.Thread.Sleep(3000);
                        AdminAnaSayfa();

                    }
                }


            }
            else if (tercih == "4")
            {


                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                MyName();
                int urunID;
                Console.SetCursorPosition(33, 4);
                Console.Write("Siparişler Menüsüne Hoş Geldiniz.");
                var siparisler = DB.Siparisler.ToList();
                Console.SetCursorPosition(0, 12);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                foreach (var item in siparisler)
                {
                    Console.WriteLine(item.Siparis_Id + " " + item.tarih);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(30, 5);
                Console.Write("Silmek İstediğiniz Ürünün ID'sini Yazınız: ");
                urunID = Convert.ToInt32(Console.ReadLine());    
                Siparisler s = DB.Siparisler.Where(x => x.Siparis_Id == urunID).SingleOrDefault();
                if (s == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(25, 8);
                    Console.Write("Girmiş Olduğunuz ID Uyuşmuyor. Lütfen Tekrar Deneyiniz...");
                    System.Threading.Thread.Sleep(3000);
                    AdminAnaSayfa();
                }

                if (s != null)
                {
                    Siparisler silme4 = (from i in DB.Siparisler where i.Siparis_Id == urunID select i).SingleOrDefault();
                    SiparisDetay koşul3 = (from i in DB.SiparisDetay where i.Siparis_Id == urunID select i).FirstOrDefault();
                    if (koşul3 == null)
                    {
                        DB.Siparisler.Remove(silme4);
                        DB.SaveChanges();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(30, 7);
                        Console.Write("Silme İşlemi Başarıyla Gerçekleşti.");
                        Console.SetCursorPosition(30, 8);
                        Console.Write("Admin Paneline Yönlendiriliyorsunuz...");
                        System.Threading.Thread.Sleep(3000);
                        AdminAnaSayfa();
                    }
                    else if (koşul3 != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(30, 7);
                        Console.Write("Silme İşlemi Gerçekleşmedi.");
                        Console.SetCursorPosition(30, 8);
                        Console.Write("Siparişi Olan Bir Ürün Silinemez...");
                        System.Threading.Thread.Sleep(3000);
                        AdminAnaSayfa();
                    }


                }
            }
            else if (tercih == "5")

            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                MyName();
                int siparisID;
                Console.SetCursorPosition(33, 4);
                Console.Write("Sipariş Detay Menüsüne Hoş Geldiniz.");
                var siparisdetay = DB.SiparisDetay.ToList();
                Console.SetCursorPosition(0, 12);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                foreach (var item in siparisdetay)
                {
                    Console.WriteLine(item.SDetay_Id+" FİYAT = "+item.Fiyat+" ADET ="+item.Adet);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(30, 5);
                Console.Write("Silmek İstediğiniz Ürünün ID'sini Yazınız: ");
                siparisID = Convert.ToInt32(Console.ReadLine());
                SiparisDetay sd = DB.SiparisDetay.Where(x => x.SDetay_Id == siparisID).SingleOrDefault();
                if (sd == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(25, 8);
                    Console.Write("Girmiş Olduğunuz ID Uyuşmuyor. Lütfen Tekrar Deneyiniz...");
                    System.Threading.Thread.Sleep(3000);
                    AdminAnaSayfa();
                }

                if (sd != null)
                {
                    SiparisDetay silme5 = (from i in DB.SiparisDetay where i.SDetay_Id == siparisID select i).SingleOrDefault();


                        DB.SiparisDetay.Remove(silme5);
                        DB.SaveChanges();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(30, 7);
                        Console.Write("Silme İşlemi Başarıyla Gerçekleşti.");
                        Console.SetCursorPosition(30, 8);
                        Console.Write("Admin Paneline Yönlendiriliyorsunuz...");
                        System.Threading.Thread.Sleep(3000);
                        AdminAnaSayfa(); 
                }
                
            }
            else if (tercih == "6")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(35, 17);
                Console.Write("Admin Paneline Yönlendiriliyorsunuz.");
                System.Threading.Thread.Sleep(2000);
                AdminAnaSayfa();
            }
        } // Admin Tablo içi veri silme sayfası
        public static void MyName() // DataBase'min ASCII ismi 
        {
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
        }

    }
}
