using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;


namespace ALTIDAALTI
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.CursorVisible = false;
            Console.SetWindowSize(200, 50);

            giris();
            aciklama();
            soru1();
            soru2();
            soru3();
            soru4();
            soru5();
            soru6();
            
        }
        
        static void giris()
        {



            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;


            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n                                           \"ALT+ENTER\" TUŞLARINA BASINIZ VE BEKLEYİNİZ...5");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n                                           \"ALT+ENTER\" TUŞLARINA BASINIZ VE BEKLEYİNİZ...4");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n                                           \"ALT+ENTER\" TUŞLARINA BASINIZ VE BEKLEYİNİZ...3");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n                                           \"ALT+ENTER\" TUŞLARINA BASINIZ VE BEKLEYİNİZ...2");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n                                           \"ALT+ENTER\" TUŞLARINA BASINIZ VE BEKLEYİNİZ...1");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("");

            Console.WriteLine("                                                                                 ██████╗     ██████╗  █████╗      ██████╗ ");
            Console.WriteLine("                                                                                ██╔════╝     ██╔══██╗██╔══██╗    ██╔════╝ ");
            Console.WriteLine("                                                                                ███████╗     ██║  ██║███████║    ███████╗ ");
            Console.WriteLine("                                                                                ██╔═══██╗    ██║  ██║██╔══██║    ██╔═══██╗");
            Console.WriteLine("                                                                                ╚██████╔╝    ██████╔╝██║  ██║    ╚██████╔╝");
            Console.WriteLine("                                                                                 ╚═════╝     ╚═════╝ ╚═╝  ╚═╝     ╚═════╝ ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗   ██╗ █████╗ ██████╗ ██╗███████╗███╗   ███╗ █████╗ ███████╗██╗███╗   ██╗ █████╗                              ");
            Console.WriteLine("                                                            ╚██╗ ██╔╝██╔══██╗██╔══██╗██║██╔════╝████╗ ████║██╔══██╗██╔════╝██║████╗  ██║██╔══██╗                             ");
            Console.WriteLine("                                                             ╚████╔╝ ███████║██████╔╝██║███████╗██╔████╔██║███████║███████╗██║██╔██╗ ██║███████║                             ");
            Console.WriteLine("                                                              ╚██╔╝  ██╔══██║██╔══██╗██║╚════██║██║╚██╔╝██║██╔══██║╚════██║██║██║╚██╗██║██╔══██║                             ");
            Console.WriteLine("                                                               ██║   ██║  ██║██║  ██║██║███████║██║ ╚═╝ ██║██║  ██║███████║██║██║ ╚████║██║  ██║                             ");
            Console.WriteLine("                                                               ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝                             ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗  ██╗ ██████╗ ███████╗ ██████╗ ███████╗██╗     ██████╗ ██╗███╗   ██╗██╗███████╗                               ");
            Console.WriteLine("                                                            ██║  ██║██╔═══██╗██╔════╝██╔════╝ ██╔════╝██║     ██╔══██╗██║████╗  ██║██║╚══███╔╝                               ");
            Console.WriteLine("                                                            ███████║██║   ██║███████╗██║  ███╗█████╗  ██║     ██║  ██║██║██╔██╗ ██║██║  ███╔╝                                ");
            Console.WriteLine("                                                            ██╔══██║██║   ██║╚════██║██║   ██║██╔══╝  ██║     ██║  ██║██║██║╚██╗██║██║ ███╔╝                                 ");
            Console.WriteLine("                                                            ██║  ██║╚██████╔╝███████║╚██████╔╝███████╗███████╗██████╔╝██║██║ ╚████║██║███████╗                               ");
            Console.WriteLine("                                                            ╚═╝  ╚═╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝╚══════╝                               ");
            System.Threading.Thread.Sleep(50);
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                                                 ██████╗     ██████╗  █████╗      ██████╗ ");
            Console.WriteLine("                                                                                ██╔════╝     ██╔══██╗██╔══██╗    ██╔════╝ ");
            Console.WriteLine("                                                                                ███████╗     ██║  ██║███████║    ███████╗ ");
            Console.WriteLine("                                                                                ██╔═══██╗    ██║  ██║██╔══██║    ██╔═══██╗");
            Console.WriteLine("                                                                                ╚██████╔╝    ██████╔╝██║  ██║    ╚██████╔╝");
            Console.WriteLine("                                                                                 ╚═════╝     ╚═════╝ ╚═╝  ╚═╝     ╚═════╝ ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗   ██╗ █████╗ ██████╗ ██╗███████╗███╗   ███╗ █████╗ ███████╗██╗███╗   ██╗ █████╗                              ");
            Console.WriteLine("                                                            ╚██╗ ██╔╝██╔══██╗██╔══██╗██║██╔════╝████╗ ████║██╔══██╗██╔════╝██║████╗  ██║██╔══██╗                             ");
            Console.WriteLine("                                                             ╚████╔╝ ███████║██████╔╝██║███████╗██╔████╔██║███████║███████╗██║██╔██╗ ██║███████║                             ");
            Console.WriteLine("                                                              ╚██╔╝  ██╔══██║██╔══██╗██║╚════██║██║╚██╔╝██║██╔══██║╚════██║██║██║╚██╗██║██╔══██║                             ");
            Console.WriteLine("                                                               ██║   ██║  ██║██║  ██║██║███████║██║ ╚═╝ ██║██║  ██║███████║██║██║ ╚████║██║  ██║                             ");
            Console.WriteLine("                                                               ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝                             ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗  ██╗ ██████╗ ███████╗ ██████╗ ███████╗██╗     ██████╗ ██╗███╗   ██╗██╗███████╗                               ");
            Console.WriteLine("                                                            ██║  ██║██╔═══██╗██╔════╝██╔════╝ ██╔════╝██║     ██╔══██╗██║████╗  ██║██║╚══███╔╝                               ");
            Console.WriteLine("                                                            ███████║██║   ██║███████╗██║  ███╗█████╗  ██║     ██║  ██║██║██╔██╗ ██║██║  ███╔╝                                ");
            Console.WriteLine("                                                            ██╔══██║██║   ██║╚════██║██║   ██║██╔══╝  ██║     ██║  ██║██║██║╚██╗██║██║ ███╔╝                                 ");
            Console.WriteLine("                                                            ██║  ██║╚██████╔╝███████║╚██████╔╝███████╗███████╗██████╔╝██║██║ ╚████║██║███████╗                               ");
            Console.WriteLine("                                                            ╚═╝  ╚═╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝╚══════╝                               ");

            System.Threading.Thread.Sleep(50);
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                                                 ██████╗     ██████╗  █████╗      ██████╗ ");
            Console.WriteLine("                                                                                ██╔════╝     ██╔══██╗██╔══██╗    ██╔════╝ ");
            Console.WriteLine("                                                                                ███████╗     ██║  ██║███████║    ███████╗ ");
            Console.WriteLine("                                                                                ██╔═══██╗    ██║  ██║██╔══██║    ██╔═══██╗");
            Console.WriteLine("                                                                                ╚██████╔╝    ██████╔╝██║  ██║    ╚██████╔╝");
            Console.WriteLine("                                                                                 ╚═════╝     ╚═════╝ ╚═╝  ╚═╝     ╚═════╝ ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗   ██╗ █████╗ ██████╗ ██╗███████╗███╗   ███╗ █████╗ ███████╗██╗███╗   ██╗ █████╗                              ");
            Console.WriteLine("                                                            ╚██╗ ██╔╝██╔══██╗██╔══██╗██║██╔════╝████╗ ████║██╔══██╗██╔════╝██║████╗  ██║██╔══██╗                             ");
            Console.WriteLine("                                                             ╚████╔╝ ███████║██████╔╝██║███████╗██╔████╔██║███████║███████╗██║██╔██╗ ██║███████║                             ");
            Console.WriteLine("                                                              ╚██╔╝  ██╔══██║██╔══██╗██║╚════██║██║╚██╔╝██║██╔══██║╚════██║██║██║╚██╗██║██╔══██║                             ");
            Console.WriteLine("                                                               ██║   ██║  ██║██║  ██║██║███████║██║ ╚═╝ ██║██║  ██║███████║██║██║ ╚████║██║  ██║                             ");
            Console.WriteLine("                                                               ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝                             ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗  ██╗ ██████╗ ███████╗ ██████╗ ███████╗██╗     ██████╗ ██╗███╗   ██╗██╗███████╗                               ");
            Console.WriteLine("                                                            ██║  ██║██╔═══██╗██╔════╝██╔════╝ ██╔════╝██║     ██╔══██╗██║████╗  ██║██║╚══███╔╝                               ");
            Console.WriteLine("                                                            ███████║██║   ██║███████╗██║  ███╗█████╗  ██║     ██║  ██║██║██╔██╗ ██║██║  ███╔╝                                ");
            Console.WriteLine("                                                            ██╔══██║██║   ██║╚════██║██║   ██║██╔══╝  ██║     ██║  ██║██║██║╚██╗██║██║ ███╔╝                                 ");
            Console.WriteLine("                                                            ██║  ██║╚██████╔╝███████║╚██████╔╝███████╗███████╗██████╔╝██║██║ ╚████║██║███████╗                               ");
            Console.WriteLine("                                                            ╚═╝  ╚═╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝╚══════╝                               ");



            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                                                 ██████╗     ██████╗  █████╗      ██████╗ ");
            Console.WriteLine("                                                                                ██╔════╝     ██╔══██╗██╔══██╗    ██╔════╝ ");
            Console.WriteLine("                                                                                ███████╗     ██║  ██║███████║    ███████╗ ");
            Console.WriteLine("                                                                                ██╔═══██╗    ██║  ██║██╔══██║    ██╔═══██╗");
            Console.WriteLine("                                                                                ╚██████╔╝    ██████╔╝██║  ██║    ╚██████╔╝");
            Console.WriteLine("                                                                                 ╚═════╝     ╚═════╝ ╚═╝  ╚═╝     ╚═════╝ ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗   ██╗ █████╗ ██████╗ ██╗███████╗███╗   ███╗ █████╗ ███████╗██╗███╗   ██╗ █████╗                              ");
            Console.WriteLine("                                                            ╚██╗ ██╔╝██╔══██╗██╔══██╗██║██╔════╝████╗ ████║██╔══██╗██╔════╝██║████╗  ██║██╔══██╗                             ");
            Console.WriteLine("                                                             ╚████╔╝ ███████║██████╔╝██║███████╗██╔████╔██║███████║███████╗██║██╔██╗ ██║███████║                             ");
            Console.WriteLine("                                                              ╚██╔╝  ██╔══██║██╔══██╗██║╚════██║██║╚██╔╝██║██╔══██║╚════██║██║██║╚██╗██║██╔══██║                             ");
            Console.WriteLine("                                                               ██║   ██║  ██║██║  ██║██║███████║██║ ╚═╝ ██║██║  ██║███████║██║██║ ╚████║██║  ██║                             ");
            Console.WriteLine("                                                               ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝                             ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗  ██╗ ██████╗ ███████╗ ██████╗ ███████╗██╗     ██████╗ ██╗███╗   ██╗██╗███████╗                               ");
            Console.WriteLine("                                                            ██║  ██║██╔═══██╗██╔════╝██╔════╝ ██╔════╝██║     ██╔══██╗██║████╗  ██║██║╚══███╔╝                               ");
            Console.WriteLine("                                                            ███████║██║   ██║███████╗██║  ███╗█████╗  ██║     ██║  ██║██║██╔██╗ ██║██║  ███╔╝                                ");
            Console.WriteLine("                                                            ██╔══██║██║   ██║╚════██║██║   ██║██╔══╝  ██║     ██║  ██║██║██║╚██╗██║██║ ███╔╝                                 ");
            Console.WriteLine("                                                            ██║  ██║╚██████╔╝███████║╚██████╔╝███████╗███████╗██████╔╝██║██║ ╚████║██║███████╗                               ");
            Console.WriteLine("                                                            ╚═╝  ╚═╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝╚══════╝                               ");

            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                                                 ██████╗     ██████╗  █████╗      ██████╗ ");
            Console.WriteLine("                                                                                ██╔════╝     ██╔══██╗██╔══██╗    ██╔════╝ ");
            Console.WriteLine("                                                                                ███████╗     ██║  ██║███████║    ███████╗ ");
            Console.WriteLine("                                                                                ██╔═══██╗    ██║  ██║██╔══██║    ██╔═══██╗");
            Console.WriteLine("                                                                                ╚██████╔╝    ██████╔╝██║  ██║    ╚██████╔╝");
            Console.WriteLine("                                                                                 ╚═════╝     ╚═════╝ ╚═╝  ╚═╝     ╚═════╝ ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗   ██╗ █████╗ ██████╗ ██╗███████╗███╗   ███╗ █████╗ ███████╗██╗███╗   ██╗ █████╗                              ");
            Console.WriteLine("                                                            ╚██╗ ██╔╝██╔══██╗██╔══██╗██║██╔════╝████╗ ████║██╔══██╗██╔════╝██║████╗  ██║██╔══██╗                             ");
            Console.WriteLine("                                                             ╚████╔╝ ███████║██████╔╝██║███████╗██╔████╔██║███████║███████╗██║██╔██╗ ██║███████║                             ");
            Console.WriteLine("                                                              ╚██╔╝  ██╔══██║██╔══██╗██║╚════██║██║╚██╔╝██║██╔══██║╚════██║██║██║╚██╗██║██╔══██║                             ");
            Console.WriteLine("                                                               ██║   ██║  ██║██║  ██║██║███████║██║ ╚═╝ ██║██║  ██║███████║██║██║ ╚████║██║  ██║                             ");
            Console.WriteLine("                                                               ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝                             ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗  ██╗ ██████╗ ███████╗ ██████╗ ███████╗██╗     ██████╗ ██╗███╗   ██╗██╗███████╗                               ");
            Console.WriteLine("                                                            ██║  ██║██╔═══██╗██╔════╝██╔════╝ ██╔════╝██║     ██╔══██╗██║████╗  ██║██║╚══███╔╝                               ");
            Console.WriteLine("                                                            ███████║██║   ██║███████╗██║  ███╗█████╗  ██║     ██║  ██║██║██╔██╗ ██║██║  ███╔╝                                ");
            Console.WriteLine("                                                            ██╔══██║██║   ██║╚════██║██║   ██║██╔══╝  ██║     ██║  ██║██║██║╚██╗██║██║ ███╔╝                                 ");
            Console.WriteLine("                                                            ██║  ██║╚██████╔╝███████║╚██████╔╝███████╗███████╗██████╔╝██║██║ ╚████║██║███████╗                               ");
            Console.WriteLine("                                                            ╚═╝  ╚═╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝╚══════╝                               ");

            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                                                 ██████╗     ██████╗  █████╗      ██████╗ ");
            Console.WriteLine("                                                                                ██╔════╝     ██╔══██╗██╔══██╗    ██╔════╝ ");
            Console.WriteLine("                                                                                ███████╗     ██║  ██║███████║    ███████╗ ");
            Console.WriteLine("                                                                                ██╔═══██╗    ██║  ██║██╔══██║    ██╔═══██╗");
            Console.WriteLine("                                                                                ╚██████╔╝    ██████╔╝██║  ██║    ╚██████╔╝");
            Console.WriteLine("                                                                                 ╚═════╝     ╚═════╝ ╚═╝  ╚═╝     ╚═════╝ ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗   ██╗ █████╗ ██████╗ ██╗███████╗███╗   ███╗ █████╗ ███████╗██╗███╗   ██╗ █████╗                              ");
            Console.WriteLine("                                                            ╚██╗ ██╔╝██╔══██╗██╔══██╗██║██╔════╝████╗ ████║██╔══██╗██╔════╝██║████╗  ██║██╔══██╗                             ");
            Console.WriteLine("                                                             ╚████╔╝ ███████║██████╔╝██║███████╗██╔████╔██║███████║███████╗██║██╔██╗ ██║███████║                             ");
            Console.WriteLine("                                                              ╚██╔╝  ██╔══██║██╔══██╗██║╚════██║██║╚██╔╝██║██╔══██║╚════██║██║██║╚██╗██║██╔══██║                             ");
            Console.WriteLine("                                                               ██║   ██║  ██║██║  ██║██║███████║██║ ╚═╝ ██║██║  ██║███████║██║██║ ╚████║██║  ██║                             ");
            Console.WriteLine("                                                               ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝                             ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗  ██╗ ██████╗ ███████╗ ██████╗ ███████╗██╗     ██████╗ ██╗███╗   ██╗██╗███████╗                               ");
            Console.WriteLine("                                                            ██║  ██║██╔═══██╗██╔════╝██╔════╝ ██╔════╝██║     ██╔══██╗██║████╗  ██║██║╚══███╔╝                               ");
            Console.WriteLine("                                                            ███████║██║   ██║███████╗██║  ███╗█████╗  ██║     ██║  ██║██║██╔██╗ ██║██║  ███╔╝                                ");
            Console.WriteLine("                                                            ██╔══██║██║   ██║╚════██║██║   ██║██╔══╝  ██║     ██║  ██║██║██║╚██╗██║██║ ███╔╝                                 ");
            Console.WriteLine("                                                            ██║  ██║╚██████╔╝███████║╚██████╔╝███████╗███████╗██████╔╝██║██║ ╚████║██║███████╗                               ");
            Console.WriteLine("                                                            ╚═╝  ╚═╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝╚══════╝                               ");


            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                                                 ██████╗     ██████╗  █████╗      ██████╗ ");
            Console.WriteLine("                                                                                ██╔════╝     ██╔══██╗██╔══██╗    ██╔════╝ ");
            Console.WriteLine("                                                                                ███████╗     ██║  ██║███████║    ███████╗ ");
            Console.WriteLine("                                                                                ██╔═══██╗    ██║  ██║██╔══██║    ██╔═══██╗");
            Console.WriteLine("                                                                                ╚██████╔╝    ██████╔╝██║  ██║    ╚██████╔╝");
            Console.WriteLine("                                                                                 ╚═════╝     ╚═════╝ ╚═╝  ╚═╝     ╚═════╝ ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗   ██╗ █████╗ ██████╗ ██╗███████╗███╗   ███╗ █████╗ ███████╗██╗███╗   ██╗ █████╗                              ");
            Console.WriteLine("                                                            ╚██╗ ██╔╝██╔══██╗██╔══██╗██║██╔════╝████╗ ████║██╔══██╗██╔════╝██║████╗  ██║██╔══██╗                             ");
            Console.WriteLine("                                                             ╚████╔╝ ███████║██████╔╝██║███████╗██╔████╔██║███████║███████╗██║██╔██╗ ██║███████║                             ");
            Console.WriteLine("                                                              ╚██╔╝  ██╔══██║██╔══██╗██║╚════██║██║╚██╔╝██║██╔══██║╚════██║██║██║╚██╗██║██╔══██║                             ");
            Console.WriteLine("                                                               ██║   ██║  ██║██║  ██║██║███████║██║ ╚═╝ ██║██║  ██║███████║██║██║ ╚████║██║  ██║                             ");
            Console.WriteLine("                                                               ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝                             ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗  ██╗ ██████╗ ███████╗ ██████╗ ███████╗██╗     ██████╗ ██╗███╗   ██╗██╗███████╗                               ");
            Console.WriteLine("                                                            ██║  ██║██╔═══██╗██╔════╝██╔════╝ ██╔════╝██║     ██╔══██╗██║████╗  ██║██║╚══███╔╝                               ");
            Console.WriteLine("                                                            ███████║██║   ██║███████╗██║  ███╗█████╗  ██║     ██║  ██║██║██╔██╗ ██║██║  ███╔╝                                ");
            Console.WriteLine("                                                            ██╔══██║██║   ██║╚════██║██║   ██║██╔══╝  ██║     ██║  ██║██║██║╚██╗██║██║ ███╔╝                                 ");
            Console.WriteLine("                                                            ██║  ██║╚██████╔╝███████║╚██████╔╝███████╗███████╗██████╔╝██║██║ ╚████║██║███████╗                               ");
            Console.WriteLine("                                                            ╚═╝  ╚═╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝╚══════╝                               ");


            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                                                 ██████╗     ██████╗  █████╗      ██████╗ ");
            Console.WriteLine("                                                                                ██╔════╝     ██╔══██╗██╔══██╗    ██╔════╝ ");
            Console.WriteLine("                                                                                ███████╗     ██║  ██║███████║    ███████╗ ");
            Console.WriteLine("                                                                                ██╔═══██╗    ██║  ██║██╔══██║    ██╔═══██╗");
            Console.WriteLine("                                                                                ╚██████╔╝    ██████╔╝██║  ██║    ╚██████╔╝");
            Console.WriteLine("                                                                                 ╚═════╝     ╚═════╝ ╚═╝  ╚═╝     ╚═════╝ ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗   ██╗ █████╗ ██████╗ ██╗███████╗███╗   ███╗ █████╗ ███████╗██╗███╗   ██╗ █████╗                              ");
            Console.WriteLine("                                                            ╚██╗ ██╔╝██╔══██╗██╔══██╗██║██╔════╝████╗ ████║██╔══██╗██╔════╝██║████╗  ██║██╔══██╗                             ");
            Console.WriteLine("                                                             ╚████╔╝ ███████║██████╔╝██║███████╗██╔████╔██║███████║███████╗██║██╔██╗ ██║███████║                             ");
            Console.WriteLine("                                                              ╚██╔╝  ██╔══██║██╔══██╗██║╚════██║██║╚██╔╝██║██╔══██║╚════██║██║██║╚██╗██║██╔══██║                             ");
            Console.WriteLine("                                                               ██║   ██║  ██║██║  ██║██║███████║██║ ╚═╝ ██║██║  ██║███████║██║██║ ╚████║██║  ██║                             ");
            Console.WriteLine("                                                               ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝                             ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗  ██╗ ██████╗ ███████╗ ██████╗ ███████╗██╗     ██████╗ ██╗███╗   ██╗██╗███████╗                               ");
            Console.WriteLine("                                                            ██║  ██║██╔═══██╗██╔════╝██╔════╝ ██╔════╝██║     ██╔══██╗██║████╗  ██║██║╚══███╔╝                               ");
            Console.WriteLine("                                                            ███████║██║   ██║███████╗██║  ███╗█████╗  ██║     ██║  ██║██║██╔██╗ ██║██║  ███╔╝                                ");
            Console.WriteLine("                                                            ██╔══██║██║   ██║╚════██║██║   ██║██╔══╝  ██║     ██║  ██║██║██║╚██╗██║██║ ███╔╝                                 ");
            Console.WriteLine("                                                            ██║  ██║╚██████╔╝███████║╚██████╔╝███████╗███████╗██████╔╝██║██║ ╚████║██║███████╗                               ");
            Console.WriteLine("                                                            ╚═╝  ╚═╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝╚══════╝                               ");


            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                                                 ██████╗     ██████╗  █████╗      ██████╗ ");
            Console.WriteLine("                                                                                ██╔════╝     ██╔══██╗██╔══██╗    ██╔════╝ ");
            Console.WriteLine("                                                                                ███████╗     ██║  ██║███████║    ███████╗ ");
            Console.WriteLine("                                                                                ██╔═══██╗    ██║  ██║██╔══██║    ██╔═══██╗");
            Console.WriteLine("                                                                                ╚██████╔╝    ██████╔╝██║  ██║    ╚██████╔╝");
            Console.WriteLine("                                                                                 ╚═════╝     ╚═════╝ ╚═╝  ╚═╝     ╚═════╝ ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗   ██╗ █████╗ ██████╗ ██╗███████╗███╗   ███╗ █████╗ ███████╗██╗███╗   ██╗ █████╗                              ");
            Console.WriteLine("                                                            ╚██╗ ██╔╝██╔══██╗██╔══██╗██║██╔════╝████╗ ████║██╔══██╗██╔════╝██║████╗  ██║██╔══██╗                             ");
            Console.WriteLine("                                                             ╚████╔╝ ███████║██████╔╝██║███████╗██╔████╔██║███████║███████╗██║██╔██╗ ██║███████║                             ");
            Console.WriteLine("                                                              ╚██╔╝  ██╔══██║██╔══██╗██║╚════██║██║╚██╔╝██║██╔══██║╚════██║██║██║╚██╗██║██╔══██║                             ");
            Console.WriteLine("                                                               ██║   ██║  ██║██║  ██║██║███████║██║ ╚═╝ ██║██║  ██║███████║██║██║ ╚████║██║  ██║                             ");
            Console.WriteLine("                                                               ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝                             ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗  ██╗ ██████╗ ███████╗ ██████╗ ███████╗██╗     ██████╗ ██╗███╗   ██╗██╗███████╗                               ");
            Console.WriteLine("                                                            ██║  ██║██╔═══██╗██╔════╝██╔════╝ ██╔════╝██║     ██╔══██╗██║████╗  ██║██║╚══███╔╝                               ");
            Console.WriteLine("                                                            ███████║██║   ██║███████╗██║  ███╗█████╗  ██║     ██║  ██║██║██╔██╗ ██║██║  ███╔╝                                ");
            Console.WriteLine("                                                            ██╔══██║██║   ██║╚════██║██║   ██║██╔══╝  ██║     ██║  ██║██║██║╚██╗██║██║ ███╔╝                                 ");
            Console.WriteLine("                                                            ██║  ██║╚██████╔╝███████║╚██████╔╝███████╗███████╗██████╔╝██║██║ ╚████║██║███████╗                               ");
            Console.WriteLine("                                                            ╚═╝  ╚═╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝╚══════╝                               ");


            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                                                 ██████╗     ██████╗  █████╗      ██████╗ ");
            Console.WriteLine("                                                                                ██╔════╝     ██╔══██╗██╔══██╗    ██╔════╝ ");
            Console.WriteLine("                                                                                ███████╗     ██║  ██║███████║    ███████╗ ");
            Console.WriteLine("                                                                                ██╔═══██╗    ██║  ██║██╔══██║    ██╔═══██╗");
            Console.WriteLine("                                                                                ╚██████╔╝    ██████╔╝██║  ██║    ╚██████╔╝");
            Console.WriteLine("                                                                                 ╚═════╝     ╚═════╝ ╚═╝  ╚═╝     ╚═════╝ ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗   ██╗ █████╗ ██████╗ ██╗███████╗███╗   ███╗ █████╗ ███████╗██╗███╗   ██╗ █████╗                              ");
            Console.WriteLine("                                                            ╚██╗ ██╔╝██╔══██╗██╔══██╗██║██╔════╝████╗ ████║██╔══██╗██╔════╝██║████╗  ██║██╔══██╗                             ");
            Console.WriteLine("                                                             ╚████╔╝ ███████║██████╔╝██║███████╗██╔████╔██║███████║███████╗██║██╔██╗ ██║███████║                             ");
            Console.WriteLine("                                                              ╚██╔╝  ██╔══██║██╔══██╗██║╚════██║██║╚██╔╝██║██╔══██║╚════██║██║██║╚██╗██║██╔══██║                             ");
            Console.WriteLine("                                                               ██║   ██║  ██║██║  ██║██║███████║██║ ╚═╝ ██║██║  ██║███████║██║██║ ╚████║██║  ██║                             ");
            Console.WriteLine("                                                               ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝                             ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗  ██╗ ██████╗ ███████╗ ██████╗ ███████╗██╗     ██████╗ ██╗███╗   ██╗██╗███████╗                               ");
            Console.WriteLine("                                                            ██║  ██║██╔═══██╗██╔════╝██╔════╝ ██╔════╝██║     ██╔══██╗██║████╗  ██║██║╚══███╔╝                               ");
            Console.WriteLine("                                                            ███████║██║   ██║███████╗██║  ███╗█████╗  ██║     ██║  ██║██║██╔██╗ ██║██║  ███╔╝                                ");
            Console.WriteLine("                                                            ██╔══██║██║   ██║╚════██║██║   ██║██╔══╝  ██║     ██║  ██║██║██║╚██╗██║██║ ███╔╝                                 ");
            Console.WriteLine("                                                            ██║  ██║╚██████╔╝███████║╚██████╔╝███████╗███████╗██████╔╝██║██║ ╚████║██║███████╗                               ");
            Console.WriteLine("                                                            ╚═╝  ╚═╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝╚══════╝                               ");

            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                                                 ██████╗     ██████╗  █████╗      ██████╗ ");
            Console.WriteLine("                                                                                ██╔════╝     ██╔══██╗██╔══██╗    ██╔════╝ ");
            Console.WriteLine("                                                                                ███████╗     ██║  ██║███████║    ███████╗ ");
            Console.WriteLine("                                                                                ██╔═══██╗    ██║  ██║██╔══██║    ██╔═══██╗");
            Console.WriteLine("                                                                                ╚██████╔╝    ██████╔╝██║  ██║    ╚██████╔╝");
            Console.WriteLine("                                                                                 ╚═════╝     ╚═════╝ ╚═╝  ╚═╝     ╚═════╝ ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗   ██╗ █████╗ ██████╗ ██╗███████╗███╗   ███╗ █████╗ ███████╗██╗███╗   ██╗ █████╗                              ");
            Console.WriteLine("                                                            ╚██╗ ██╔╝██╔══██╗██╔══██╗██║██╔════╝████╗ ████║██╔══██╗██╔════╝██║████╗  ██║██╔══██╗                             ");
            Console.WriteLine("                                                             ╚████╔╝ ███████║██████╔╝██║███████╗██╔████╔██║███████║███████╗██║██╔██╗ ██║███████║                             ");
            Console.WriteLine("                                                              ╚██╔╝  ██╔══██║██╔══██╗██║╚════██║██║╚██╔╝██║██╔══██║╚════██║██║██║╚██╗██║██╔══██║                             ");
            Console.WriteLine("                                                               ██║   ██║  ██║██║  ██║██║███████║██║ ╚═╝ ██║██║  ██║███████║██║██║ ╚████║██║  ██║                             ");
            Console.WriteLine("                                                               ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝                             ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗  ██╗ ██████╗ ███████╗ ██████╗ ███████╗██╗     ██████╗ ██╗███╗   ██╗██╗███████╗                               ");
            Console.WriteLine("                                                            ██║  ██║██╔═══██╗██╔════╝██╔════╝ ██╔════╝██║     ██╔══██╗██║████╗  ██║██║╚══███╔╝                               ");
            Console.WriteLine("                                                            ███████║██║   ██║███████╗██║  ███╗█████╗  ██║     ██║  ██║██║██╔██╗ ██║██║  ███╔╝                                ");
            Console.WriteLine("                                                            ██╔══██║██║   ██║╚════██║██║   ██║██╔══╝  ██║     ██║  ██║██║██║╚██╗██║██║ ███╔╝                                 ");
            Console.WriteLine("                                                            ██║  ██║╚██████╔╝███████║╚██████╔╝███████╗███████╗██████╔╝██║██║ ╚████║██║███████╗                               ");
            Console.WriteLine("                                                            ╚═╝  ╚═╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝╚══════╝                               ");

            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                                                 ██████╗     ██████╗  █████╗      ██████╗ ");
            Console.WriteLine("                                                                                ██╔════╝     ██╔══██╗██╔══██╗    ██╔════╝ ");
            Console.WriteLine("                                                                                ███████╗     ██║  ██║███████║    ███████╗ ");
            Console.WriteLine("                                                                                ██╔═══██╗    ██║  ██║██╔══██║    ██╔═══██╗");
            Console.WriteLine("                                                                                ╚██████╔╝    ██████╔╝██║  ██║    ╚██████╔╝");
            Console.WriteLine("                                                                                 ╚═════╝     ╚═════╝ ╚═╝  ╚═╝     ╚═════╝ ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗   ██╗ █████╗ ██████╗ ██╗███████╗███╗   ███╗ █████╗ ███████╗██╗███╗   ██╗ █████╗                              ");
            Console.WriteLine("                                                            ╚██╗ ██╔╝██╔══██╗██╔══██╗██║██╔════╝████╗ ████║██╔══██╗██╔════╝██║████╗  ██║██╔══██╗                             ");
            Console.WriteLine("                                                             ╚████╔╝ ███████║██████╔╝██║███████╗██╔████╔██║███████║███████╗██║██╔██╗ ██║███████║                             ");
            Console.WriteLine("                                                              ╚██╔╝  ██╔══██║██╔══██╗██║╚════██║██║╚██╔╝██║██╔══██║╚════██║██║██║╚██╗██║██╔══██║                             ");
            Console.WriteLine("                                                               ██║   ██║  ██║██║  ██║██║███████║██║ ╚═╝ ██║██║  ██║███████║██║██║ ╚████║██║  ██║                             ");
            Console.WriteLine("                                                               ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝                             ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗  ██╗ ██████╗ ███████╗ ██████╗ ███████╗██╗     ██████╗ ██╗███╗   ██╗██╗███████╗                               ");
            Console.WriteLine("                                                            ██║  ██║██╔═══██╗██╔════╝██╔════╝ ██╔════╝██║     ██╔══██╗██║████╗  ██║██║╚══███╔╝                               ");
            Console.WriteLine("                                                            ███████║██║   ██║███████╗██║  ███╗█████╗  ██║     ██║  ██║██║██╔██╗ ██║██║  ███╔╝                                ");
            Console.WriteLine("                                                            ██╔══██║██║   ██║╚════██║██║   ██║██╔══╝  ██║     ██║  ██║██║██║╚██╗██║██║ ███╔╝                                 ");
            Console.WriteLine("                                                            ██║  ██║╚██████╔╝███████║╚██████╔╝███████╗███████╗██████╔╝██║██║ ╚████║██║███████╗                               ");
            Console.WriteLine("                                                            ╚═╝  ╚═╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝╚══════╝                               ");

            System.Threading.Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                                                 ██████╗     ██████╗  █████╗      ██████╗ ");
            Console.WriteLine("                                                                                ██╔════╝     ██╔══██╗██╔══██╗    ██╔════╝ ");
            Console.WriteLine("                                                                                ███████╗     ██║  ██║███████║    ███████╗ ");
            Console.WriteLine("                                                                                ██╔═══██╗    ██║  ██║██╔══██║    ██╔═══██╗");
            Console.WriteLine("                                                                                ╚██████╔╝    ██████╔╝██║  ██║    ╚██████╔╝");
            Console.WriteLine("                                                                                 ╚═════╝     ╚═════╝ ╚═╝  ╚═╝     ╚═════╝ ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗   ██╗ █████╗ ██████╗ ██╗███████╗███╗   ███╗ █████╗ ███████╗██╗███╗   ██╗ █████╗                              ");
            Console.WriteLine("                                                            ╚██╗ ██╔╝██╔══██╗██╔══██╗██║██╔════╝████╗ ████║██╔══██╗██╔════╝██║████╗  ██║██╔══██╗                             ");
            Console.WriteLine("                                                             ╚████╔╝ ███████║██████╔╝██║███████╗██╔████╔██║███████║███████╗██║██╔██╗ ██║███████║                             ");
            Console.WriteLine("                                                              ╚██╔╝  ██╔══██║██╔══██╗██║╚════██║██║╚██╔╝██║██╔══██║╚════██║██║██║╚██╗██║██╔══██║                             ");
            Console.WriteLine("                                                               ██║   ██║  ██║██║  ██║██║███████║██║ ╚═╝ ██║██║  ██║███████║██║██║ ╚████║██║  ██║                             ");
            Console.WriteLine("                                                               ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝                             ");
            Console.WriteLine("                                                                                                                                                                             ");
            Console.WriteLine("                                                            ██╗  ██╗ ██████╗ ███████╗ ██████╗ ███████╗██╗     ██████╗ ██╗███╗   ██╗██╗███████╗                               ");
            Console.WriteLine("                                                            ██║  ██║██╔═══██╗██╔════╝██╔════╝ ██╔════╝██║     ██╔══██╗██║████╗  ██║██║╚══███╔╝                               ");
            Console.WriteLine("                                                            ███████║██║   ██║███████╗██║  ███╗█████╗  ██║     ██║  ██║██║██╔██╗ ██║██║  ███╔╝                                ");
            Console.WriteLine("                                                            ██╔══██║██║   ██║╚════██║██║   ██║██╔══╝  ██║     ██║  ██║██║██║╚██╗██║██║ ███╔╝                                 ");
            Console.WriteLine("                                                            ██║  ██║╚██████╔╝███████║╚██████╔╝███████╗███████╗██████╔╝██║██║ ╚████║██║███████╗                               ");
            Console.WriteLine("                                                            ╚═╝  ╚═╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝╚══════╝                               ");


            int sayı = 10;


            while (sayı > 0)
            {



                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("                                                                                 ██████╗     ██████╗  █████╗      ██████╗ ");
                Console.WriteLine("                                                                                ██╔════╝     ██╔══██╗██╔══██╗    ██╔════╝ ");
                Console.WriteLine("                                                                                ███████╗     ██║  ██║███████║    ███████╗ ");
                Console.WriteLine("                                                                                ██╔═══██╗    ██║  ██║██╔══██║    ██╔═══██╗");
                Console.WriteLine("                                                                                ╚██████╔╝    ██████╔╝██║  ██║    ╚██████╔╝");
                Console.WriteLine("                                                                                 ╚═════╝     ╚═════╝ ╚═╝  ╚═╝     ╚═════╝ ");
                Console.WriteLine("                                                                                                                                                                             ");
                Console.WriteLine("                                                            ██╗   ██╗ █████╗ ██████╗ ██╗███████╗███╗   ███╗ █████╗ ███████╗██╗███╗   ██╗ █████╗                              ");
                Console.WriteLine("                                                            ╚██╗ ██╔╝██╔══██╗██╔══██╗██║██╔════╝████╗ ████║██╔══██╗██╔════╝██║████╗  ██║██╔══██╗                             ");
                Console.WriteLine("                                                             ╚████╔╝ ███████║██████╔╝██║███████╗██╔████╔██║███████║███████╗██║██╔██╗ ██║███████║                             ");
                Console.WriteLine("                                                              ╚██╔╝  ██╔══██║██╔══██╗██║╚════██║██║╚██╔╝██║██╔══██║╚════██║██║██║╚██╗██║██╔══██║                             ");
                Console.WriteLine("                                                               ██║   ██║  ██║██║  ██║██║███████║██║ ╚═╝ ██║██║  ██║███████║██║██║ ╚████║██║  ██║                             ");
                Console.WriteLine("                                                               ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝                             ");
                Console.WriteLine("                                                                                                                                                                             ");
                Console.WriteLine("                                                            ██╗  ██╗ ██████╗ ███████╗ ██████╗ ███████╗██╗     ██████╗ ██╗███╗   ██╗██╗███████╗                               ");
                Console.WriteLine("                                                            ██║  ██║██╔═══██╗██╔════╝██╔════╝ ██╔════╝██║     ██╔══██╗██║████╗  ██║██║╚══███╔╝                               ");
                Console.WriteLine("                                                            ███████║██║   ██║███████╗██║  ███╗█████╗  ██║     ██║  ██║██║██╔██╗ ██║██║  ███╔╝                                ");
                Console.WriteLine("                                                            ██╔══██║██║   ██║╚════██║██║   ██║██╔══╝  ██║     ██║  ██║██║██║╚██╗██║██║ ███╔╝                                 ");
                Console.WriteLine("                                                            ██║  ██║╚██████╔╝███████║╚██████╔╝███████╗███████╗██████╔╝██║██║ ╚████║██║███████╗                               ");
                Console.WriteLine("                                                            ╚═╝  ╚═╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝╚══════╝                               ");
                System.Threading.Thread.Sleep(50);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                                                                                ██████╗     ██████╗  █████╗      ██████╗ ");
                Console.WriteLine("                                                                               ██╔════╝     ██╔══██╗██╔══██╗    ██╔════╝ ");
                Console.WriteLine("                                                                               ███████╗     ██║  ██║███████║    ███████╗ ");
                Console.WriteLine("                                                                               ██╔═══██╗    ██║  ██║██╔══██║    ██╔═══██╗");
                Console.WriteLine("                                                                               ╚██████╔╝    ██████╔╝██║  ██║    ╚██████╔╝");
                Console.WriteLine("                                                                                ╚═════╝     ╚═════╝ ╚═╝  ╚═╝     ╚═════╝ ");
                Console.WriteLine("                                                                                                                                                                            ");
                Console.WriteLine("                                                           ██╗   ██╗ █████╗ ██████╗ ██╗███████╗███╗   ███╗ █████╗ ███████╗██╗███╗   ██╗ █████╗                              ");
                Console.WriteLine("                                                           ╚██╗ ██╔╝██╔══██╗██╔══██╗██║██╔════╝████╗ ████║██╔══██╗██╔════╝██║████╗  ██║██╔══██╗                             ");
                Console.WriteLine("                                                            ╚████╔╝ ███████║██████╔╝██║███████╗██╔████╔██║███████║███████╗██║██╔██╗ ██║███████║                             ");
                Console.WriteLine("                                                             ╚██╔╝  ██╔══██║██╔══██╗██║╚════██║██║╚██╔╝██║██╔══██║╚════██║██║██║╚██╗██║██╔══██║                             ");
                Console.WriteLine("                                                              ██║   ██║  ██║██║  ██║██║███████║██║ ╚═╝ ██║██║  ██║███████║██║██║ ╚████║██║  ██║                             ");
                Console.WriteLine("                                                              ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝                             ");
                Console.WriteLine("                                                                                                                                                                            ");
                Console.WriteLine("                                                           ██╗  ██╗ ██████╗ ███████╗ ██████╗ ███████╗██╗     ██████╗ ██╗███╗   ██╗██╗███████╗                               ");
                Console.WriteLine("                                                           ██║  ██║██╔═══██╗██╔════╝██╔════╝ ██╔════╝██║     ██╔══██╗██║████╗  ██║██║╚══███╔╝                               ");
                Console.WriteLine("                                                           ███████║██║   ██║███████╗██║  ███╗█████╗  ██║     ██║  ██║██║██╔██╗ ██║██║  ███╔╝                                ");
                Console.WriteLine("                                                           ██╔══██║██║   ██║╚════██║██║   ██║██╔══╝  ██║     ██║  ██║██║██║╚██╗██║██║ ███╔╝                                 ");
                Console.WriteLine("                                                           ██║  ██║╚██████╔╝███████║╚██████╔╝███████╗███████╗██████╔╝██║██║ ╚████║██║███████╗                               ");
                Console.WriteLine("                                                           ╚═╝  ╚═╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝╚══════╝                               ");
                System.Threading.Thread.Sleep(50);

                sayı--;

            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                                                       BAŞLAMAK İÇİN BİR TUŞA BASINIZ...\n\n\n\n\n\n\n");


         
            Console.WriteLine("                                                                              ╔╗ ╦ ╦  ╦═╗╔═╗╔═╗╦ ╦╦    ╔═╗╔═╗╔╦╗╦╦╔═╔═╗╔═╗╦  ╦ ╦");
            Console.WriteLine("                                                                              ╠╩╗╚╦╝  ╠╦╝║╣ ╚═╗║ ║║    ╚═╗╠═╣ ║║║╠╩╗║ ║║ ╦║  ║ ║");
            Console.WriteLine("                                                                              ╚═╝ ╩   ╩╚═╚═╝╚═╝╚═╝╩═╝  ╚═╝╩ ╩═╩╝╩╩ ╩╚═╝╚═╝╩═╝╚═╝");


            Console.ReadKey();
            Console.Clear();



        }
        static void aciklama()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                            YARIŞMAMIZ 6 SORUDAN OLUŞMAKTADIR VE SON SORUYU BİLEREK BÜYÜK ÖDÜLÜN SAHİBİ OLABİLİRSİNİZ...");
            Console.WriteLine("                                                                                                                                                              ");
            Console.WriteLine("                                                                                SORULARIN PUANLARI AŞAĞIDA GÖRDÜĞÜNÜZ GİBİDİR...                                                          ");
            Console.WriteLine("                                                                                                                                                           ");
            Console.WriteLine("                                                                                                1.  500   PUAN                                                                     ");
            Console.WriteLine("                                                                                                2.  1000  PUAN                                                                                     ");
            Console.WriteLine("                                                                                                3.  2000  PUAN                                                                     ");
            Console.WriteLine("                                                                                                4.  3000  PUAN                                                                     ");
            Console.WriteLine("                                                                                                5.  5000  PUAN                                                                     ");
            Console.WriteLine("                                                                                                6.  10000 PUAN                                                                      ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                                                     HAZIRSANIZ EĞER YARIŞMAMIZ BAŞLIYOR.....                                                                              ");


            Console.ReadKey();
            Console.Clear();

        }
        static void soru1()
        {

            int s;
            Random rnd = new Random();
            s = rnd.Next(1, 10);

            if (s == 1)

            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        1. Soru==>          “Kuşlar”, “Bulutlar” ve “Eşek Arıları” adlı tiyatro eserleri, Antik Çağ'ın en önemli komedya yazarlarından olan hangi yazara aittir?");
                Console.WriteLine("                                                    ");
                Console.WriteLine("                                                          A)Euripides                         B)Aristofanes                                             ");
                Console.WriteLine("                                                                                                                                                         ");
                Console.WriteLine("                                                          C)Sofokles                          D)Demokritos                                               ");
                string cevap = Console.ReadLine();
                if (cevap == "b" || cevap == "B")
                {
                    Console.WriteLine("                                                                      TEBRİKLER!!!");
                    Console.WriteLine("                                                                    ");
                    Console.WriteLine("                                                                      DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                     ");
                    Console.WriteLine("                                                      SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();
                    


                }
                else
                {
                    Console.WriteLine("                                                                     YANLIŞ CEVAP!!!!");
                    Console.WriteLine("                                                                     ");

                    Console.ReadKey();
                    Console.Clear();

                    baraj2000();


                }



            }
            else if (s == 2)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        1. Soru==>                                  Mezar taşında “Dedi Kuzgun: Bir daha asla!” yazan şair ve yazar kimdir?                 ");
                Console.WriteLine("                                                                                                                                              ");
                Console.WriteLine("                                                          A)Edgar Allan Poe                         B)Emily Dickinson                     ");
                Console.WriteLine("                                                                                                                                               ");
                Console.WriteLine("                                                          C)Pablo Neruda                            D)T.S. Eliot                               ");
                string cevap = Console.ReadLine();
                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("                                                                            TEBRİKLER!!!");
                    Console.WriteLine("                                                                          ");
                    Console.WriteLine("                                                                            DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                           ");
                    Console.WriteLine("                                                            SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();
                    

                }
                else
                {
                    Console.WriteLine("                                                                            YANLIŞ CEVAP!!!!");
                    Console.WriteLine("                                                                            ");

                    Console.ReadKey();
                    Console.Clear();

                    baraj2000();


                }
            }

            else if (s == 3)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        1. Soru==>                            “Karartma Geceleri”, “Bacaksız Okulda” ve “Sarı Yazma” kitapları hangi yazara aittir?");
                Console.WriteLine("                                                    ");
                Console.WriteLine("                                                          A)Haldun Taner                           B)Rıfat Ilgaz                ");
                Console.WriteLine("                                                                                                                                      ");
                Console.WriteLine("                                                          C)Kemalettin Tuğcu                       D)Orhan Kemal                      ");
                string cevap = Console.ReadLine();
                if (cevap == "b" || cevap == "B")
                {
                    Console.WriteLine("                                                                              TEBRİKLER!!!");
                    Console.WriteLine("                                                                            ");
                    Console.WriteLine("                                                                              DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                             ");
                    Console.WriteLine("                                                              SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();
                    


                }
                else
                {                                                                                 
                    Console.WriteLine("                                                                              YANLIŞ CEVAP!!!!");
                    Console.WriteLine("                                                                              ");

                    Console.ReadKey();
                    Console.Clear();

                    baraj2000();

                }

            }
            else if (s == 4)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        1. Soru==>                               “İnsan Ne ile Yaşar” ve “Kreutzer Sonat” kitaplarının yazarı kimdir?                                    ");
                Console.WriteLine("                                                                                                                                                             ");
                Console.WriteLine("                                                          A)Lev Tolstoy                         B)Necib Mahfuz                                             ");
                Console.WriteLine("                                                                                                                                                             ");
                Console.WriteLine("                                                          C)Halit Hüseyni                       D)Goethe                                                     ");
                string cevap = Console.ReadLine();
                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("                                                                       ");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                        ");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();
                    


                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("                                                                         ");

                    Console.ReadKey();
                    Console.Clear();

                    baraj2000();

                }
            }













            else if (s == 5)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("         1. Soru==>                “Bilginin Arkeolojisi” ve “Kelimeler ve Şeyler” kitaplarının yazarı, tarihçi, eleştirmen ve sosyolog kimdir?                                                      ");
                Console.WriteLine("                                                                                                                                                             ");
                Console.WriteLine("                                                          A)Noam Chomsky                       B)Michel Foucault                                             ");
                Console.WriteLine("                                                                                                                                                             ");
                Console.WriteLine("                                                          C)Louis Althusser                    D)Jacques Lacan                                                   ");
                string cevap = Console.ReadLine();
                if (cevap == "b" || cevap == "B")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("                                                                       ");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                        ");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("                                                                         ");

                    Console.ReadKey();
                    Console.Clear();

                    baraj2000();

                }
            }

            else if (s ==6 )
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("         1. Soru==>                   “Küçük Deniz Kızı” adlı kitabın yazarı olan ve çıktığı Avrupa gezisinden sonra kaleme aldığı ?                                 ");
                Console.WriteLine("                                                                                                                                                             ");
                Console.WriteLine("                                                  “Bir Şairin Çarşısı” adlı eserinde İstabul’u anlatan yazar hangisidir                                                                                                     ");
                Console.WriteLine("                                                                                                                                                             ");
                Console.WriteLine("                                                          A)Hans Christian Andersen            B)Carlo Collodi                         ");
                Console.WriteLine("                                                                                                                                                             ");
                Console.WriteLine("                                                          C)Jonathan Swift                     D)La Fontaine                                                   ");
                string cevap = Console.ReadLine();
                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("                                                                       ");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                        ");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("                                                                         ");

                    Console.ReadKey();
                    Console.Clear();

                    baraj2000();

                }
            }

            else if (s ==7 )
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("       1. Soru==>   Yunan mitolojisinde berberinin bir kuyuya, kulaklarının eşek kulakları olduğu sırrını söylediği Midas hangi ülkenin kralıdır?    ");
                Console.WriteLine("                                                                                                                                                             ");
                Console.WriteLine("                                                          A)Makedonya                         B)İyonya                                   ");
                Console.WriteLine("                                                                                                                                                             ");
                Console.WriteLine("                                                          C)Hitit                             D)Frigya                                                  ");
                string cevap = Console.ReadLine();
                if (cevap == "d" || cevap == "D")
                {
                    Console.WriteLine("                                                                   TEBRİKLER!!!");
                    Console.WriteLine("                                                                 ");
                    Console.WriteLine("                                                                   DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                  ");
                    Console.WriteLine("                                                   SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("                                                                         ");

                    Console.ReadKey();
                    Console.Clear();

                    baraj2000();

                }
            }

            else if (s == 8)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("      1. Soru==>                        Başkarakterleri Dr. Jack, Sawyer ve Kate olan, gizemli senaryosuyla büyük ilgi toplayan, ");
                Console.WriteLine("                                                                                                                                                             ");

                Console.WriteLine("                                              finaliyle bir kısım hayranını hayal kırıklığına uğratan dizi hangisidir?                 ");
                Console.WriteLine("                                                                                                                                                             ");

                Console.WriteLine("                                                          A)Breaking Bad                       B)Dr. Who                                            ");

                Console.WriteLine("                                                                                                                                                             ");
                Console.WriteLine("                                                          C)Fringe                             D)Lost                                                   ");
                string cevap = Console.ReadLine();
                if (cevap == "d" || cevap == "D")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("                                                                       ");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                        ");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("                                                                         ");

                    Console.ReadKey();
                    Console.Clear();

                    baraj2000();

                }
            }

            else if (s ==9 )
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("          1. Soru==>                  Kağıda alerjisi olduğu bilinen, “Beyaz Gemi” ve “Toprak Ana” romanlarının yazarı kimdir?");
                Console.WriteLine("                                                                                                                                                             ");
                Console.WriteLine("                                                          A)Cengiz Aytmato                     B)Tarık Buğra                                             ");
                Console.WriteLine("                                                                                                                                                             ");
                Console.WriteLine("                                                          C)Halil Cibran                       D)Mihail Şolohov                                              ");
                string cevap = Console.ReadLine();
                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("                                                                       ");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                        ");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("                                                                         ");

                    Console.ReadKey();
                    Console.Clear();

                    baraj2000();

                }
            }

            else



            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("          1. Soru==>                         Türk edebiyatının ilk realist roman örneği sayılan “Araba Sevdası” eseri kime aittir?                                    ");
                Console.WriteLine("                                                                                                                                                             ");
                Console.WriteLine("                                                          A)Recaizade Mahmud Ekrem                          B)Muallim Naci                                             ");
                Console.WriteLine("                                                                                                                                                             ");
                Console.WriteLine("                                                          C)Ahmetd Mithat Efendi                            D)Nabizade Nazım                                                     ");
                string cevap = Console.ReadLine();
                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("                                                                                     TEBRİKLER!!!");
                    Console.WriteLine("                                                                                   ");
                    Console.WriteLine("                                                                                     DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                                                     SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();
                    


                }
                else
                {
                    Console.WriteLine("                                                                                     YANLIŞ CEVAP!!!!");
                    Console.WriteLine("                                                                                     ");

                    Console.ReadKey();
                    Console.Clear();

                    baraj2000();

                }

            }

                    

      }
        static void soru2()
        {

            int s;
            Random rnd = new Random();
            s = rnd.Next(1, 10);

            if (s == 1)

            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        2. Soru==>                                  Dünyadaki en fazla dinozor yumurtası fosilini bulundurarak Guinness         ");
                Console.WriteLine("                                              Dünya Rekorları'na giren ve lakabı “Dinozorlar Evi” olan şehir hangi ülkededir?");
                Console.WriteLine("");

                Console.WriteLine("                                                          A)İngiltere                  B)Rusya                  ");
                Console.WriteLine("                                                                                                                                                         ");
                Console.WriteLine("                                                          C)Çin                        D)ABD                                               ");
                string cevap = Console.ReadLine();
                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine("                                                                      TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                      DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                      SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();
                    


                }
                else
                {
                    Console.WriteLine("                                                                     YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan500();


                }



            }
            else if (s == 2)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        2. Soru==>         Antik Yunan’da düzenlenen Olimpiyat oyunlarında birinci olana verilen kupanın içinde hangisi olurdu?                                      ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Altın sikke                        B)Gümüş sikke                    ");
                Console.WriteLine("                                                                                                                                               ");
                Console.WriteLine("                                                          C)Zeytinyağı                         D)Tuz                               ");
                string cevap = Console.ReadLine();
                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine("                                                                            TEBRİKLER!!!");
                    Console.WriteLine("                                                                          ");
                    Console.WriteLine("                                                                            DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                           ");
                    Console.WriteLine("                                                            SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();
                    

                }
                else
                {
                    Console.WriteLine("                                                                            YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan500();


                }
            }

            else if (s == 3)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        2. Soru==>                            “Süper Mario” oyununda, Mario’nun kendisi gibi muslukçu olan erkek kardeşinin adı nedir?              ?");
                Console.WriteLine("");
                Console.WriteLine("                                                                 A)Emilio                         B)Luigi                ");
                Console.WriteLine("");                                                              
                Console.WriteLine("                                                                 C)Leonardo                       D)Luciano                     ");
                string cevap = Console.ReadLine();
                if (cevap == "b" || cevap == "B")
                {
                    Console.WriteLine("                                                                              TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                              DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                              SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();
                    


                }
                else
                {                                                                                 
                    Console.WriteLine("                                                                              YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan500();

                }

            }
            else if (s == 4)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        2. Soru==>             Hangisi, 11 Oscar ile “En Fazla Oscar Kazanan Filmler” listesinde ilk sırayı paylaşan 3 filmden biri değildir?                  ?                                    ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Ben-Hur                                  B)Titanik                                             ");
                Console.WriteLine("");
                Console.WriteLine("                                                          C)Yüzüklerin Efendisi: Kralın Dönüşü       D)Yıldız Savaşları: Yeni Bir Umut                                                     ");
                string cevap = Console.ReadLine();
                if (cevap == "d" || cevap == "D")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();
                    


                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan500();

                }
            }













            else if (s == 5)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("         2. Soru==>                               Afrika’da ulusal parkların dışındaki çiftçi tarlalarına zarar veren filleri ");
                Console.WriteLine("                                           engellemek için çiftçiler hangilerini besleyerek filleri tarlalarından uzak tutabilmektedirler?                                        ");
                Console.WriteLine("                                                                 A)Fare                     B)Arı                                             ");
                Console.WriteLine("");                                     
                Console.WriteLine("                                                                 C)Karga                    D)Kirpi                                                  ");
                string cevap = Console.ReadLine();
                if (cevap == "b" || cevap == "B")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("                                                                       ");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                        ");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan500();

                }
            }

            else if (s ==6 )
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("         2. Soru==>                                               Hangi kuşun diğer adı “ebabil”dir?                                ");
                Console.WriteLine("");                                            
                Console.WriteLine("                                                            A)Bataklık kırlangıcı           B)Çöl kırlangıcı                         ");
                Console.WriteLine("                                                                                                                                                               ");
                Console.WriteLine("                                                            C)Deniz kırlangıcı              D)Dağ kırlangıcı                                                   ");
                string cevap = Console.ReadLine();
                if (cevap == "D" || cevap == "d")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan500();

                }
            }

            else if (s ==7 )
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("       2. Soru==>     1926'da önce kullanılan ve “Alaturka” da denilen saat sistemine göre bir günün bitip diğerinin başladığını haber veren ezan hangisi olur?  ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Sabah ezanı            B)Öğle ezanı                             ");
                Console.WriteLine("");
                Console.WriteLine("                                                          C)Akşam ezanı            D)Yatsı ezanı                                                ");
                string cevap = Console.ReadLine();
                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine("                                                                   TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                   DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                   SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                    YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan500();

                }
            }

            else if (s == 8)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("      2. Soru==>                                                 Hangisi bir hamur tatlısıdır?  ");
                Console.WriteLine("");                                                              
                Console.WriteLine("                                                                  A)Kesat                     B)Mafiş                                         ");
                                                                                                    
                Console.WriteLine("");                                                              
                Console.WriteLine("                                                                  C)Heyhey                    D)Maval                                                   ");
                string cevap = Console.ReadLine();
                if (cevap == "b" || cevap == "B")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan500();

                }
            }

            else if (s ==9 )
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("          2. Soru==>     İstanbul’da bir firma, 7 yıldır devam eden kampanya boyunca hangi hizmeti alan müşterilerine Franz Kafka’nın “Dönüşüm” kitabını hediye etmiştir?             ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Böcek ilaçlama                 B)Tercüme ve çeviri                                           ");
                Console.WriteLine("");
                Console.WriteLine("                                                          C)Estetik operasyon              D)Boya ve badana                                          ");
                string cevap = Console.ReadLine();
                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan500();

                }
            }

            else



            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("          2. Soru==>                                Hangi hayvan, yavrularını 8 yıldan daha uzun süre emzirebilmektedir?                                                 ");
                Console.WriteLine("");                                                
                Console.WriteLine("                                                                        A)Orangutan                   B)Ayı                                          ");
                Console.WriteLine("");                                                
                Console.WriteLine("                                                                        C)Yarasa                      D)Zürafa                                                     ");
                string cevap = Console.ReadLine();
                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("                                                                               TEBRİKLER!!!");
                    Console.WriteLine("                                                                             ");
                    Console.WriteLine("                                                                               DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                              ");
                    Console.WriteLine("                                                               SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();
                    


                }
                else
                {
                    Console.WriteLine("                                                                                 YANLIŞ CEVAP!!!!");
                    Console.WriteLine("                                                                                     ");

                    Console.ReadKey();
                    Console.Clear();

                    kazan500();

                }

            }

                    

      }
        static void soru3()
        {

            int s;
            Random rnd = new Random();
            s = rnd.Next(1, 10);

            if (s == 1)

            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        3. Soru==>    2009'da yeni bir gök taşı keşfeden Fransız gök bilimci Jean-Claude Merlin, gök taşına, hayran olduğu hangi sanatçının ismini vermiştir?      ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Ajda Pekkan                    B)Sezen Aksu                                             ");
                Console.WriteLine("                                                                                                                                                         ");
                Console.WriteLine("                                                          C)Yıldız Tilbe                   D)Zeki Müren                                               ");
                string cevap = Console.ReadLine();
                if (cevap == "b" || cevap == "B")
                {
                    Console.WriteLine("                                                                      TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                      DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                      SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();
                    


                }
                else
                {
                    Console.WriteLine("                                                                     YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan1000();


                }



            }
            else if (s == 2)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        3. Soru==>                              Osmanlıcada “dücace” ve “harguş” hangi iki hayvana verilen adlardır?                                        ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Tavuk ve tavşan                  B)Kedi ve köpek                    ");
                Console.WriteLine("                                                                                                                                               ");
                Console.WriteLine("                                                          C)At ve eşek                       D)Yılan ve fil                               ");
                string cevap = Console.ReadLine();
                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("                                                                            TEBRİKLER!!!");
                    Console.WriteLine("                                                                          ");
                    Console.WriteLine("                                                                            DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                           ");
                    Console.WriteLine("                                                            SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();
                    

                }
                else
                {
                    Console.WriteLine("                                                                            YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan1000();


                }
            }

            else if (s == 3)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        3. Soru==>                      Hangi ünlü kişinin beyni, ölümünden sonra incelenmek için 30.000'den fazla parçaya ayrılmıştır?                 ?");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Albert Einstein                      B)Winston Churchill                ");
                Console.WriteLine("");
                Console.WriteLine("                                                          C)Vladimir Lenin                       D)Nikola Tesla                     ");
                string cevap = Console.ReadLine();
                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine("                                                                              TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                              DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                              SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();
                    


                }
                else
                {                                                                                 
                    Console.WriteLine("                                                                              YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan1000();

                }

            }
            else if (s == 4)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        3. Soru==>            Adolphe Sax 1846'da tasarladığı müzik aleti saksafonun patentinin başvurusunda sunduğu saksafonu hangisinden üretmiştir?                ?                                    ");
                Console.WriteLine("");                           
                Console.WriteLine("                                                                 A)Seramik                     B)Ahşap                                             ");
                Console.WriteLine("");                           
                Console.WriteLine("                                                                 C)Nakır                       D)Cam                                                     ");
                string cevap = Console.ReadLine();
                if (cevap == "b" || cevap == "B")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();
                    


                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan1000();

                }
            }



            else if (s == 5)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("         3. Soru==>                2011'de yapılan bir çalışmaya göre hangi ünlü yapının çıplak gözle görülür biçimde eğiliyor olduğu açıklanmıştır?                                          ");
                Console.WriteLine("");                              
                Console.WriteLine("                                                              A)Empire State Binası            B)Eyfel Kulesi                                             ");
                Console.WriteLine("");                              
                Console.WriteLine("                                                              C)Big Ben                        D)Özgürlük Anıtı                                                  ");
                string cevap = Console.ReadLine();
                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("                                                                       ");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                        ");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan1000();

                }
            }

            else if (s ==6 )
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("         3. Soru==>             Hangi animasyon filmi, Time dergisinin 2007'de yayımladığı “en iyi 25 korku filmi” listesinde yer almaktadır?                              ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Kayıp Balık Nemo               B)Bambi                         ");
                Console.WriteLine("                                                                                                                                                             ");
                Console.WriteLine("                                                          C)Peter Pan                      D)Aslan Kral                                            ");
                string cevap = Console.ReadLine();
                if (cevap == "b" || cevap == "B")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan1000();

                }
            }

            else if (s ==7 )
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("       3. Soru==>     Lisedeyken bir arkadaşıyla okulun ders programını “hack”leyerek kendisini sadece kızların olduğu sınıflara yerleştiren kişi kimdir?  ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Steve Jobs                      B)Mark Zuckerberg                             ");
                Console.WriteLine("");
                Console.WriteLine("                                                          C)Bill Gates                      D)Elon Musk                                                ");
                string cevap = Console.ReadLine();
                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine("                                                                   TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                   DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                   SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan1000();

                }
            }

            else if (s == 8)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("      3. Soru==>             George R.R. Martin’in, çocukken beslediği ve sırayla ölen hangi hayvanlarının birbirlerine tuzak kurduğunu                    ");
                Console.WriteLine("                                                     hayal etmesi Game of Thrones’a ilham vermiştir?");
                Console.WriteLine("  ");                       
                Console.WriteLine("                                                             A)Kaplumbağa                     B)Tavşan                                         ");
                Console.WriteLine("");                          
                Console.WriteLine("                                                             C)Fare                           D)Karga                                                   ");
                string cevap = Console.ReadLine();
                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan1000();

                }
            }

            else if (s ==9 )
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("          3. Soru==>   Heykeltraş Pietro da Milano’nun 2012'de yaklaşık 400 bin sterline müzadeye çıkan madalyonu hangi padişahın bilinen ilk portresini taşır?        ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Kanuni Sultan Süleyman        B)Fatih Sultan Mehmed                                           ");
                Console.WriteLine("");
                Console.WriteLine("                                                          C)Yavuz Sultan Selim            D)Abdülmecid                                          ");
                string cevap = Console.ReadLine();
                if (cevap == "b" || cevap == "B")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan1000();

                }
            }

            else



            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("          3. Soru==>          Hesap ödemek yerine ya bağış yapılan ya da gönüllü olarak çalışılan ABD’deki “Soul Kitchen” adlı restoran kime aittir?                                              ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Bono                        B)Jon Bon Jovi                                          ");
                Console.WriteLine("");
                Console.WriteLine("                                                          C)Keanu Reeves                D)Lady Gaga                                                     ");
                string cevap = Console.ReadLine();
                if (cevap == "b" || cevap == "B")
                {
                    Console.WriteLine("                                                                     TEBRİKLER!!!");
                    Console.WriteLine("                                                                   ");
                    Console.WriteLine("                                                                     DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                    ");
                    Console.WriteLine("                                                     SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();
                    


                }
                else
                {
                    Console.WriteLine("                                                                      YANLIŞ CEVAP!!!!");
                    Console.WriteLine("                                                                                     ");

                    Console.ReadKey();
                    Console.Clear();

                    kazan1000();

                }

            }

                    

      }
        static void soru4()
        {

            int s;
            Random rnd = new Random();
            s = rnd.Next(1, 10);

            if (s == 1)

            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        4. Soru==>      İngilizcesi “Happy birthday” olan ve Türkiye’de “İyi ki doğdun” olarak söylenen şarkının 1893'te yazılan ilk sözlerinde yer alan ifadenin Türkçesi nedir?    ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Bu ne güzel pasta                 B)İyi uykular size                                             ");
                Console.WriteLine("                                                                                                                                                         ");
                Console.WriteLine("                                                          C)Kedim bugün yasta                 D)Herkese günaydın                                               ");
                string cevap = Console.ReadLine();
                if (cevap == "d" || cevap == "D")
                {
                    Console.WriteLine("                                                                          TEBRİKLER!!!");
                    Console.WriteLine("");                                             
                    Console.WriteLine("                                                                          DOĞRU CEVAP!!!");
                    Console.WriteLine("");                                             
                    Console.WriteLine("                                                          SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan2000();


                }



            }
            else if (s == 2)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        4. Soru==>     Paul McCartney, The Beatles’ın “A Day in the Life” şarkısının sonuna yerleştirdiği sesin sadece hangi hayvan tarafından duyulabileceğini söylemiştir?                                          ");
                Console.WriteLine("");
                Console.WriteLine("                                                                     A)Yarasa                     B)Ayı                    ");
                Console.WriteLine("                                                                                                                                                          ");
                Console.WriteLine("                                                                     C)Köpek                      D)Fare                               ");
                string cevap = Console.ReadLine();
                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine("                                                                            TEBRİKLER!!!");
                    Console.WriteLine("                                                                          ");
                    Console.WriteLine("                                                                            DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                           ");
                    Console.WriteLine("                                                            SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();


                }
                else
                {
                    Console.WriteLine("                                                                            YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan2000();


                }
            }

            else if (s == 3)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        4. Soru==>      1941'de kocası Almanlar tarafından öldürülen Mariya Oktyabrskaya, her şeyini satıp “Savaşan Kız Arkadaş” adını verdiği hangi aracı alarak savaşa katılmıştır?                      ?");
                Console.WriteLine("");
                Console.WriteLine("                                                                        A)Savaş gemisi            B)Tank               ");
                Console.WriteLine("");                                                                  
                Console.WriteLine("                                                                        C)Uçak                    D)Denizaltı                     ");
                string cevap = Console.ReadLine();
                if (cevap == "b" || cevap == "B")
                {
                    Console.WriteLine("                                                                              TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                              DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                              SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                              YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan2000();

                }

            }
            else if (s == 4)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        4. Soru==>        İzmir Seferihisar’da bulunan 1,5 metre yüksekliğinde bir sütuna yazılmış ve 58 satırdan oluşan 2200 yıllık yazıtın hangisi olduğu anlaşılmıştır?                                                   ");
                Console.WriteLine("");
                Console.WriteLine("                                                            A)Yemek tarifi                       B)Piyes tanıtımı                                             ");
                Console.WriteLine("");                                                       
                Console.WriteLine("                                                            C)Evlilik akdi                       D)Kira sözleşmesi                                                     ");
                string cevap = Console.ReadLine();
                if (cevap == "d" || cevap == "D")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan2000();

                }
            }













            else if (s == 5)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("         4. Soru==>       Geçtiğimiz günlerde ABD’de banka soyan 70 yaşında bir adam, paraları aldıktan sonra kaçmadan polislerin gelmesini bekleyip sorguda soygunu niçin yaptığını söylemiştir?                                               ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Haberlere çıkmak için                 B)Karısından kurtulmak için                                             ");
                Console.WriteLine("");
                Console.WriteLine("                                                          C)Arkadaş bulabilmek için               D)Kalacak yer bulmak için                                                  ");
                string cevap = Console.ReadLine();
                if (cevap == "b" || cevap == "B")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("                                                                       ");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                        ");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan2000();

                }
            }

            else if (s == 6)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("         4. Soru==>        1961'de Türkiye’deki ilk banka soygunlarından birinin gerçekleştiği İstanbul Çemberlitaş'taki bankanın adı nedir?                                       ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Arpa Bankası               B)Pirinç Bankası                         ");
                Console.WriteLine("                                                                                                                                                             ");
                Console.WriteLine("                                                          C)Buğday Bankası             D)Pancar Bankası                                                   ");
                string cevap = Console.ReadLine();
                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan2000();

                }
            }

            else if (s == 7)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("       4. Soru==>   Oscar ödüllü yönetmen Steven Spielberg, yarım bıraktığı üniversite eğitimini 33 yıl sonra hangi filmi bitirme tezi olarak sunup tamamlamıştır?    ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Er Ryan'ı Kurtarmak          B)Schindler'in Listesi                             ");
                Console.WriteLine("");
                Console.WriteLine("                                                          C)Jaws                         D)E.T.                                                ");
                string cevap = Console.ReadLine();
                if (cevap == "b" || cevap == "B")
                {
                    Console.WriteLine("                                                                   TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                   DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                   SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                     YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan2000();

                }
            }

            else if (s == 8)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("      4. Soru==>                             Bilinen 118 element arasında hangi isimde bir element yoktur?                    ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Aynştaynyum                     B)Newtonyum                                         ");

                Console.WriteLine("");
                Console.WriteLine("                                                          C)Mendelevyum                     D)Nobelyum                                                   ");
                string cevap = Console.ReadLine();
                if (cevap == "d" || cevap == "D")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan2000();

                }
            }

            else if (s == 9)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("          4. Soru==>    Apollo 11'in Ay’dan havalanmasını sağlayan şalter yanlışlıkla kırılınca Buzz Aldrin hangisini kırılan şalter yerine kullanıp mekiğin Ay’dan havalanmasını sağlamıştır?              ");
                Console.WriteLine("");
                Console.WriteLine("                                                             A)Alyans                    B)Diş fırçası                                           ");
                Console.WriteLine("");                                                     
                Console.WriteLine("                                                             C)Tükenmez kalem            D)Saç tokası                                          ");
                string cevap = Console.ReadLine();
                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan2000();

                }
            }

            else



            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("          4. Soru==>       Albert Einstein 'Genel Görelilik Kuramı'nın yayımladığında New York Times gazetesi Einstein ile röportaj yapması için kimi yollamıştır?                                                 ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Emlak muhabirini              B)Moda muhabirini                                          ");
                Console.WriteLine("");
                Console.WriteLine("                                                          C)Ekonomi muhabirini            D)Golf muhabirini                                                     ");
                string cevap = Console.ReadLine();
                if (cevap == "d" || cevap == "D")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("                                                                       ");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                        ");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                          YANLIŞ CEVAP!!!!");
                    Console.WriteLine("                                                                                     ");

                    Console.ReadKey();
                    Console.Clear();

                    kazan2000();

                }

            }



        }
        static void soru5()
        {

            int s;
            Random rnd = new Random();
            s = rnd.Next(1, 10);

            if (s == 1)

            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        5. Soru==>                     “Bir kız bana emmi dedi neyleyim” sözü hangi halk ozanına aittir?      ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Ercişli Emrah                B)Dadaloğlu                                             ");
                Console.WriteLine("                                                                                                                                                         ");
                Console.WriteLine("                                                          C)Aşık Daimi                   D)Karacaoğlan                                               ");
                string cevap = Console.ReadLine();
                if (cevap == "d" || cevap == "D")
                {
                    Console.WriteLine("                                                                      TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                      DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                      SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                     YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan3000();


                }



            }
            else if (s == 2)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        5. Soru==>               Kur’an-ı Kerim’de 'Biz, gerçekten insanı en güzel bir biçimde yarattık’ ayetinin yer aldığı sure hangisidir?                                ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)İnsan                        B)Kalem                    ");
                Console.WriteLine("                                                                                                                                               ");
                Console.WriteLine("                                                          C)Asr                           D)Tin                               ");
                string cevap = Console.ReadLine();
                if (cevap == "d" || cevap == "D")
                {
                    Console.WriteLine("                                                                   TEBRİKLER!!!");
                    Console.WriteLine("                                                                 ");
                    Console.WriteLine("                                                                   DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                  ");
                    Console.WriteLine("                                                   SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();


                }
                else
                {
                    Console.WriteLine("                                                                      YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan3000();


                }
            }

            else if (s == 3)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        5. Soru==>                            Pera Müzesi’nde sergilenen Osman Hamdi Bey’e ait “Kaplumbağa Terbiyecisi” tablosunda yerde kaç adet kaplumbağa vardır?                ?");
                Console.WriteLine("");                                          
                Console.WriteLine("                                                                          A)1                   B)3                ");
                Console.WriteLine("");                                          
                Console.WriteLine("                                                                          C)5                   D)7                     ");
                string cevap = Console.ReadLine();                              
                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine("                                                                              TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                              DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                              SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                              YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan3000();

                }

            }
            else if (s == 4)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        5. Soru==>                                         Hangisinin resmi adında “Halk Cumhuriyeti” yoktur?           ?                                    ");
                Console.WriteLine("");                                                  
                Console.WriteLine("                                                                    A)Cezayir               B)Bangladeş                                             ");
                Console.WriteLine("");                                                  
                Console.WriteLine("                                                                    C)Laos                  D)Vietnam                                                     ");
                string cevap = Console.ReadLine();
                if (cevap == "d" || cevap == "D")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan3000();

                }
            }



            

            else if (s == 5)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                   
                Console.WriteLine("         5. Soru==>                            ABD Ulusal Arşivi’nden en çok talep edilen fotoğraf, neyin fotoğrafıdır?                                   ");
                Console.WriteLine("");
                Console.WriteLine("                                                 A)Bahriyelinin bir kızı öpme anı             B)Nixon ve Elvis'in el sıkışması                                             ");
                Console.WriteLine("");
                Console.WriteLine("                                                 C)Abraham Lincoln'ün portresi                D)Marilyn Monroe'nun uçuşan eteği                                                  ");
                string cevap = Console.ReadLine();
                if (cevap == "b" || cevap == "B")
                {
                    Console.WriteLine("                                                                           TEBRİKLER!!!");
                    Console.WriteLine("                                                                         ");
                    Console.WriteLine("                                                                           DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                          ");
                    Console.WriteLine("                                                           SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();                                               
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan3000();

                }
            }

            else if (s == 6)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("         5. Soru==>           Sultan Abdülaziz’in yaverliğini yapan, bileklerini kesip, ölümü sırasında hissettiklerini bilimsel bir gözlem olarak kaydeden kişi kimdir?                           ");
                Console.WriteLine("");                           
                Console.WriteLine("                                                               A)Ahmet Rıza              B)Beşir Fuad                       ");
                Console.WriteLine("                                                                                                                                                                  ");
                Console.WriteLine("                                                               C)İzzet Melih             D)Sadık Hidayet                                                   ");
                string cevap = Console.ReadLine();
                if (cevap == "b" || cevap == "B")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan3000();

                }
            }

            else if (s == 7)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("       5. Soru==>                    “Hep denedin, hep yenildin, olsun, yine dene yine yenil, daha iyi yenil” sözü kime aittir?   ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Mahatma Gandhi                 B)Samuel Beckett                             ");
                Console.WriteLine("");
                Console.WriteLine("                                                          C)Che Guevara                    D)Goethe                                                ");
                string cevap = Console.ReadLine();
                if (cevap == "b" || cevap == "B")
                {
                    Console.WriteLine("                                                                      TEBRİKLER!!!");
                    Console.WriteLine("");                                            
                    Console.WriteLine("                                                                      DOĞRU CEVAP!!!");
                    Console.WriteLine("");                                            
                    Console.WriteLine("                                                      SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan3000();

                }
            }

            else if (s == 8)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("      5. Soru==>    “Sevgili Dünya, gidiyorum çünkü sıkıldım. Yeterince yaşadım. Seni dertlerinle başbaşa bırakıyorum. İyi şanslar” intihar notu hangi Oscarlı aktöre aittir?          ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Tony Hancock                     B)Robert Montgomery                                         ");

                Console.WriteLine("");
                Console.WriteLine("                                                          C)Charles Boyer                    D)George Sanders                                                   ");
                string cevap = Console.ReadLine();
                if (cevap == "d" || cevap == "D")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan3000();

                }
            }

            else if (s == 9)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("          5. Soru==>               Dünyanın çevresini yelkenliyle hiç karaya çıkmadan dolaşmak isteyen birinin hangi güney enlemini takip etmesi gerekir?   ");
                Console.WriteLine("");                               
                Console.WriteLine("                                                                    A)40                    B)50                                           ");
                Console.WriteLine("");                               
                Console.WriteLine("                                                                    C)60                    D)70                                          ");
                string cevap = Console.ReadLine();
                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                         SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan3000();

                }
            }

            else



            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("          5. Soru==>                       2002 seçimlerinde kampanya şarkısı olarak Whitney Houston’ın “I will always love you” parçasını kullanan diktatör kimdir?                                    ");
                Console.WriteLine("");                                       
                Console.WriteLine("                                                                        A)Hafız Esad                   B)Muammer Kaddafi                                          ");
                Console.WriteLine("");                                       
                Console.WriteLine("                                                                        C)Saddam Hüseyin               D)Kim Jong Il                                                     ");
                string cevap = Console.ReadLine();
                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine("                                                                                     TEBRİKLER!!!");
                    Console.WriteLine("                                                                                   ");
                    Console.WriteLine("                                                                                     DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                                                     SIRADAKİ SORUYA GEÇMEK İÇİN BİR TUŞA BASINIZ...");
                    Console.ReadKey();
                    Console.Clear();



                }
                else
                {
                    Console.WriteLine("                                                                                     YANLIŞ CEVAP!!!!");
                    Console.WriteLine("                                                                                     ");

                    Console.ReadKey();
                    Console.Clear();

                    kazan3000();

                }

            }



        }
        static void soru6()
        {

            int s;
            Random rnd = new Random();
            s = rnd.Next(1, 10);

            if (s == 1)

            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        6. Soru==>                               Kur’an-ı Kerim’de hangisi üzerine yemin edilmemiştir?    ");
                Console.WriteLine("");                                          
                Console.WriteLine("                                                               A)Deniz                  B)Güneş                                             ");
                Console.WriteLine("                                                                                                                                                              ");
                Console.WriteLine("                                                               C)Arı                    D)Kalem                                               ");
                string cevap = Console.ReadLine();
                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine("                                                                      TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                      DOĞRU CEVAP!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();
                    kazan10000();


                }
                else
                {
                    Console.WriteLine("                                                                     YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");
                    Console.ReadKey();
                    Console.Clear();

                    kazan5000();


                }



            }
            else if (s == 2)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        6. Soru==>             Heredot’un yazdığı, Mısır firavununun dilin kökeni deneyinde, doğunca çobana verilerek kapatılan, o dahil kimseyle konuşturulmayan çocuğun söylediği ilk kelime nedir?                                    ");
                Console.WriteLine("");                          
                Console.WriteLine("                                                                 A)Ver                             B)Anne                    ");
                Console.WriteLine("                                                                                                                                                      ");
                Console.WriteLine("                                                                 C)Ekmek                           D)Su                               ");
                string cevap = Console.ReadLine();
                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine("                                                                            TEBRİKLER!!!");
                    Console.WriteLine("                                                                          ");
                    Console.WriteLine("                                                                            DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                           ");
                    Console.ReadKey();
                    Console.Clear();
                    kazan10000();

                }
                else
                {
                    Console.WriteLine("                                                                            YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan5000();


                }
            }

            else if (s == 3)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                  
                Console.WriteLine("        6. Soru==>                                 “Yapabilirler çünkü yapabileceklerini düşünüyorlar” sözü kime aittir?             ?");
                Console.WriteLine("");                                               
                Console.WriteLine("                                                                  A)Thales                          B)Sokrates                ");
                Console.WriteLine("");                                               
                Console.WriteLine("                                                                  C)Vergilius                       D)Zenon                     ");
                string cevap = Console.ReadLine();
                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine("                                                                              TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                              DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.ReadKey();
                    Console.Clear();
                    kazan10000();


                }
                else
                {
                    Console.WriteLine("                                                                              YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan5000();

                }

            }
            else if (s == 4)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("        6. Soru==>         “Mango bahçelerinin kokusu beni sevinçten delirtiyor” dizesinin yer aldığı, sözleri Nobelli yazar Tagore’ye ait ulusal marş hangi ülkeye aittir?                                       ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Hindistan                    B)Pakistan                                             ");
                Console.WriteLine("");
                Console.WriteLine("                                                          C)Sri Lanka                    D)Bangladeş                                                     ");
                string cevap = Console.ReadLine();
                if (cevap == "d" || cevap == "D")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.ReadKey();
                    Console.Clear();
                    kazan10000();


                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan5000();

                }
            }







            else if (s == 5)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("         6. Soru==>      1 milyon TL değerindeki soruyu bilir ve ödemenizi 200'lük banknotlar halinde alırsanız, yaklaşık kaç kilogramlık ağırlık taşımak durumda kalacaksınız?                                      ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)5,5 kg                       B)6,5 kg                                             ");
                Console.WriteLine("");
                Console.WriteLine("                                                          C)7,5 kg                       D)8,5 kg                                                  ");
                string cevap = Console.ReadLine();
                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("                                                                       ");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                        ");
                    Console.ReadKey();
                    Console.Clear();
                    kazan10000();


                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan5000();

                }
            }

            else if (s == 6)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("         6. Soru==>                 1920'de TBMM açıldıktan sonra çıkarılan ilk kanun olan “Ağnam Resmi Kanunu” hangisiyle ilgilidir?                                     ");
                Console.WriteLine("");                               
                Console.WriteLine("                                                             A)Hayvan vergisi           B)Asker kaçakları                        ");
                Console.WriteLine("                                                                                                                                                                ");
                Console.WriteLine("                                                             C)Miras düzenlemesi        D)Orduya erzak yardımı                                                   ");
                string cevap = Console.ReadLine();
                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.ReadKey();
                    Console.Clear();
                    kazan10000();


                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan5000();

                }
            }

            else if (s == 7)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("       6. Soru==>                      Descartes, hangisini “ruhun oturduğu yer” sözüyle tanımlamıştır? ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Gözyaşı bezi                      B)Öd kesesi                             ");
                Console.WriteLine("");
                Console.WriteLine("                                                          C)Epifiz bezi                       D)Aşil tendonu                                                ");
                string cevap = Console.ReadLine();
                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine("                                                                       TEBRİKLER!!!");
                    Console.WriteLine("");                                          
                    Console.WriteLine("                                                                       DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.ReadKey();
                    Console.Clear();
                    kazan10000();


                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");
                    Console.ReadKey();
                    Console.Clear();

                    kazan5000();

                }
            }

            else if (s == 8)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("      6. Soru==>                         V. yüzyıla ait “Apicius”, Batı dünyasınca hangi alanda bilinen en eski kitaptır?        ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Yemek kitabı                     B)Çocuk kitabı                                         ");

                Console.WriteLine("");
                Console.WriteLine("                                                          C)Büyü kitabı                       D)Avcılık kitabı                                                   ");
                string cevap = Console.ReadLine();
                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.ReadKey();
                    Console.Clear();
                    kazan10000();


                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan5000();

                }
            }

            else if (s == 9)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("          6. Soru==>                    Eski Yunancadan gelen “jimnastik” kelimesinin kökeni olan “gymnos” ne demektir?          ");
                Console.WriteLine("");                                     
                Console.WriteLine("                                                                 A)Çıplak                  B)Yalnız                                           ");
                Console.WriteLine("");                                     
                Console.WriteLine("                                                                 C)Kum                     D)Genç                                          ");
                string cevap = Console.ReadLine();
                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("                                                                         TEBRİKLER!!!");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                         DOĞRU CEVAP!!!");
                    Console.WriteLine("");
                    Console.ReadKey();
                    Console.Clear();
                    kazan10000();


                }
                else
                {
                    Console.WriteLine("                                                                         YANLIŞ CEVAP!!!!");
                    Console.WriteLine("");

                    Console.ReadKey();
                    Console.Clear();

                    kazan5000();

                }
            }

            else



            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("          6. Soru==>    İnsanlarla diyalog kurarak yeni bilgileri öğrenmek üzere tasarlanan robot “Kirobo”, görevlilerin “Noel Baba’dan ne istersin?” sorusuna ne yanıt vermiştir?                                             ");
                Console.WriteLine("");
                Console.WriteLine("                                                          A)Oyuncak roket istiyorum                  B)Arkadaş istiyorum                                          ");
                Console.WriteLine("");
                Console.WriteLine("                                                          C)Noel Baba yoktur                         D)Para istiyorum                                                     ");
                string cevap = Console.ReadLine();
                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("                                                                                     TEBRİKLER!!!");
                    Console.WriteLine("                                                                                   ");
                    Console.WriteLine("                                                                                     DOĞRU CEVAP!!!");
                    Console.WriteLine("                                                                                    ");
                    Console.ReadKey();
                    Console.Clear();
                    kazan10000();


                }
                else
                {
                    Console.WriteLine("                                                                                     YANLIŞ CEVAP!!!!");
                    Console.WriteLine("                                                                                     ");

                    Console.ReadKey();
                    Console.Clear();

                    kazan5000();

                }

            }



        }


        static void baraj2000()
        {

            Console.WriteLine("\n\n\n");

            Console.WriteLine("     ██╗  ██╗ █████╗ ██╗   ██╗██████╗ ███████╗████████╗████████╗██╗███╗   ██╗");
            Console.WriteLine("     ██║ ██╔╝██╔══██╗╚██╗ ██╔╝██╔══██╗██╔════╝╚══██╔══╝╚══██╔══╝██║████╗  ██║");
            Console.WriteLine("     █████╔╝ ███████║ ╚████╔╝ ██████╔╝█████╗     ██║      ██║   ██║██╔██╗ ██║");
            Console.WriteLine("     ██╔═██╗ ██╔══██║  ╚██╔╝  ██╔══██╗██╔══╝     ██║      ██║   ██║██║╚██╗██║");
            Console.WriteLine("     ██║  ██╗██║  ██║   ██║   ██████╔╝███████╗   ██║      ██║   ██║██║ ╚████║");
            Console.WriteLine("     ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═════╝ ╚══════╝   ╚═╝      ╚═╝   ╚═╝╚═╝  ╚═══╝");
            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                                                                          ██╗  ██╗ █████╗ ██╗   ██╗██████╗ ███████╗████████╗████████╗██╗███╗   ██╗");
            Console.WriteLine("                                                                                                                          ██║ ██╔╝██╔══██╗╚██╗ ██╔╝██╔══██╗██╔════╝╚══██╔══╝╚══██╔══╝██║████╗  ██║");
            Console.WriteLine("                                                                                                                          █████╔╝ ███████║ ╚████╔╝ ██████╔╝█████╗     ██║      ██║   ██║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                          ██╔═██╗ ██╔══██║  ╚██╔╝  ██╔══██╗██╔══╝     ██║      ██║   ██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                          ██║  ██╗██║  ██║   ██║   ██████╔╝███████╗   ██║      ██║   ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                          ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═════╝ ╚══════╝   ╚═╝      ╚═╝   ╚═╝╚═╝  ╚═══╝");
            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                                                                                                                          ██╗  ██╗ █████╗ ██╗   ██╗██████╗ ███████╗████████╗████████╗██╗███╗   ██╗");
            Console.WriteLine("                                                                                                                          ██║ ██╔╝██╔══██╗╚██╗ ██╔╝██╔══██╗██╔════╝╚══██╔══╝╚══██╔══╝██║████╗  ██║");
            Console.WriteLine("                                                                                                                          █████╔╝ ███████║ ╚████╔╝ ██████╔╝█████╗     ██║      ██║   ██║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                          ██╔═██╗ ██╔══██║  ╚██╔╝  ██╔══██╗██╔══╝     ██║      ██║   ██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                          ██║  ██╗██║  ██║   ██║   ██████╔╝███████╗   ██║      ██║   ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                          ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═════╝ ╚══════╝   ╚═╝      ╚═╝   ╚═╝╚═╝  ╚═══╝");
            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("     ██╗  ██╗ █████╗ ██╗   ██╗██████╗ ███████╗████████╗████████╗██╗███╗   ██╗");
            Console.WriteLine("     ██║ ██╔╝██╔══██╗╚██╗ ██╔╝██╔══██╗██╔════╝╚══██╔══╝╚══██╔══╝██║████╗  ██║");
            Console.WriteLine("     █████╔╝ ███████║ ╚████╔╝ ██████╔╝█████╗     ██║      ██║   ██║██╔██╗ ██║");
            Console.WriteLine("     ██╔═██╗ ██╔══██║  ╚██╔╝  ██╔══██╗██╔══╝     ██║      ██║   ██║██║╚██╗██║");
            Console.WriteLine("     ██║  ██╗██║  ██║   ██║   ██████╔╝███████╗   ██║      ██║   ██║██║ ╚████║");
            Console.WriteLine("     ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═════╝ ╚══════╝   ╚═╝      ╚═╝   ╚═╝╚═╝  ╚═══╝");
            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("     ██╗  ██╗ █████╗ ██╗   ██╗██████╗ ███████╗████████╗████████╗██╗███╗   ██╗");
            Console.WriteLine("     ██║ ██╔╝██╔══██╗╚██╗ ██╔╝██╔══██╗██╔════╝╚══██╔══╝╚══██╔══╝██║████╗  ██║");
            Console.WriteLine("     █████╔╝ ███████║ ╚████╔╝ ██████╔╝█████╗     ██║      ██║   ██║██╔██╗ ██║");
            Console.WriteLine("     ██╔═██╗ ██╔══██║  ╚██╔╝  ██╔══██╗██╔══╝     ██║      ██║   ██║██║╚██╗██║");
            Console.WriteLine("     ██║  ██╗██║  ██║   ██║   ██████╔╝███████╗   ██║      ██║   ██║██║ ╚████║");
            Console.WriteLine("     ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═════╝ ╚══════╝   ╚═╝      ╚═╝   ╚═╝╚═╝  ╚═══╝");
            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                                                                          ██╗  ██╗ █████╗ ██╗   ██╗██████╗ ███████╗████████╗████████╗██╗███╗   ██╗");
            Console.WriteLine("                                                                                                                          ██║ ██╔╝██╔══██╗╚██╗ ██╔╝██╔══██╗██╔════╝╚══██╔══╝╚══██╔══╝██║████╗  ██║");
            Console.WriteLine("                                                                                                                          █████╔╝ ███████║ ╚████╔╝ ██████╔╝█████╗     ██║      ██║   ██║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                          ██╔═██╗ ██╔══██║  ╚██╔╝  ██╔══██╗██╔══╝     ██║      ██║   ██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                          ██║  ██╗██║  ██║   ██║   ██████╔╝███████╗   ██║      ██║   ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                          ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═════╝ ╚══════╝   ╚═╝      ╚═╝   ╚═╝╚═╝  ╚═══╝");
            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                                                                                                                          ██╗  ██╗ █████╗ ██╗   ██╗██████╗ ███████╗████████╗████████╗██╗███╗   ██╗");
            Console.WriteLine("                                                                                                                          ██║ ██╔╝██╔══██╗╚██╗ ██╔╝██╔══██╗██╔════╝╚══██╔══╝╚══██╔══╝██║████╗  ██║");
            Console.WriteLine("                                                                                                                          █████╔╝ ███████║ ╚████╔╝ ██████╔╝█████╗     ██║      ██║   ██║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                          ██╔═██╗ ██╔══██║  ╚██╔╝  ██╔══██╗██╔══╝     ██║      ██║   ██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                          ██║  ██╗██║  ██║   ██║   ██████╔╝███████╗   ██║      ██║   ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                          ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═════╝ ╚══════╝   ╚═╝      ╚═╝   ╚═╝╚═╝  ╚═══╝");
            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("     ██╗  ██╗ █████╗ ██╗   ██╗██████╗ ███████╗████████╗████████╗██╗███╗   ██╗");
            Console.WriteLine("     ██║ ██╔╝██╔══██╗╚██╗ ██╔╝██╔══██╗██╔════╝╚══██╔══╝╚══██╔══╝██║████╗  ██║");
            Console.WriteLine("     █████╔╝ ███████║ ╚████╔╝ ██████╔╝█████╗     ██║      ██║   ██║██╔██╗ ██║");
            Console.WriteLine("     ██╔═██╗ ██╔══██║  ╚██╔╝  ██╔══██╗██╔══╝     ██║      ██║   ██║██║╚██╗██║");
            Console.WriteLine("     ██║  ██╗██║  ██║   ██║   ██████╔╝███████╗   ██║      ██║   ██║██║ ╚████║");
            Console.WriteLine("     ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═════╝ ╚══════╝   ╚═╝      ╚═╝   ╚═╝╚═╝  ╚═══╝");
            System.Threading.Thread.Sleep(150);
            Console.Clear();


            int sayı = 10;


            while (sayı > 0)
            {



                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("                                                                  ██╗  ██╗ █████╗ ██╗   ██╗██████╗ ███████╗████████╗████████╗██╗███╗   ██╗");
                Console.WriteLine("                                                                  ██║ ██╔╝██╔══██╗╚██╗ ██╔╝██╔══██╗██╔════╝╚══██╔══╝╚══██╔══╝██║████╗  ██║");
                Console.WriteLine("                                                                  █████╔╝ ███████║ ╚████╔╝ ██████╔╝█████╗     ██║      ██║   ██║██╔██╗ ██║");
                Console.WriteLine("                                                                  ██╔═██╗ ██╔══██║  ╚██╔╝  ██╔══██╗██╔══╝     ██║      ██║   ██║██║╚██╗██║");
                Console.WriteLine("                                                                  ██║  ██╗██║  ██║   ██║   ██████╔╝███████╗   ██║      ██║   ██║██║ ╚████║");
                Console.WriteLine("                                                                  ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═════╝ ╚══════╝   ╚═╝      ╚═╝   ╚═╝╚═╝  ╚═══╝");
                System.Threading.Thread.Sleep(50);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                                                                   ██╗  ██╗ █████╗ ██╗   ██╗██████╗ ███████╗████████╗████████╗██╗███╗   ██╗");
                Console.WriteLine("                                                                   ██║ ██╔╝██╔══██╗╚██╗ ██╔╝██╔══██╗██╔════╝╚══██╔══╝╚══██╔══╝██║████╗  ██║");
                Console.WriteLine("                                                                   █████╔╝ ███████║ ╚████╔╝ ██████╔╝█████╗     ██║      ██║   ██║██╔██╗ ██║");
                Console.WriteLine("                                                                   ██╔═██╗ ██╔══██║  ╚██╔╝  ██╔══██╗██╔══╝     ██║      ██║   ██║██║╚██╗██║");
                Console.WriteLine("                                                                   ██║  ██╗██║  ██║   ██║   ██████╔╝███████╗   ██║      ██║   ██║██║ ╚████║");
                Console.WriteLine("                                                                   ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═════╝ ╚══════╝   ╚═╝      ╚═╝   ╚═╝╚═╝  ╚═══╝");
                System.Threading.Thread.Sleep(50);

                sayı--;

            }


            up:
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("                                                                        YENİDEN DENEMEK İÇİN '1', ÇIKMAK İÇİN '2' TUŞUNA BASINIZ");
            string son = Console.ReadLine();

            if (son == "1")
            {
                System.Diagnostics.Process.Start(Environment.GetCommandLineArgs()[0]);
                Environment.Exit(0);


            }

            else if (son == "2")
            {
                Environment.Exit(0);
            }

            else
                Console.Clear();
                goto up;
                                                                        







        }
        static void kazan500()
        {


            Console.WriteLine("\n\n\n");

            Console.WriteLine("            ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗            ");
            Console.WriteLine("            ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝            ");
            Console.WriteLine("            █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║                 ");
            Console.WriteLine("            ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║                 ");
            Console.WriteLine("            ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗            ");
            Console.WriteLine("            ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝            ");
            Console.WriteLine("     ███████╗ ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗   ");
            Console.WriteLine("     ██╔════╝██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║   ");
            Console.WriteLine("     ███████╗██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║   ");
            Console.WriteLine("     ╚════██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║   ");
            Console.WriteLine("     ███████║╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║   ");
            Console.WriteLine("     ╚══════╝ ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝   ");
            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                          ███████╗ ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                          ██╔════╝██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                          ███████╗██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                          ╚════██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                          ███████║╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                          ╚══════╝ ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                          ███████╗ ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                          ██╔════╝██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                          ███████╗██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                          ╚════██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                          ███████║╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                          ╚══════╝ ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");
            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("            ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("            ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("            █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("            ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("            ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("            ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("     ███████╗ ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ██╔════╝██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("     ███████╗██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("     ╚════██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("     ███████║╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("     ╚══════╝ ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("           ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("           ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("           █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("           ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("           ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("           ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("     ███████╗ ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ██╔════╝██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("     ███████╗██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("     ╚════██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("     ███████║╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("     ╚══════╝ ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                          ███████╗ ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                          ██╔════╝██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                          ███████╗██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                          ╚════██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                          ███████║╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                          ╚══════╝ ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                           ███████╗ ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                           ██╔════╝██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                           ███████╗██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                           ╚════██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                           ███████║╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                           ╚══════╝ ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("           ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("           ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("           █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("           ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("           ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("           ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("     ███████╗ ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ██╔════╝██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("     ███████╗██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("     ╚════██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("     ███████║╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("     ╚══════╝ ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();


            int sayı = 10;


            while (sayı > 0)
            {



                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("                                                                        ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
                Console.WriteLine("                                                                        ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
                Console.WriteLine("                                                                        █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
                Console.WriteLine("                                                                        ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
                Console.WriteLine("                                                                        ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
                Console.WriteLine("                                                                        ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
                Console.WriteLine("                                                                  ███████╗ ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
                Console.WriteLine("                                                                  ██╔════╝██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
                Console.WriteLine("                                                                  ███████╗██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
                Console.WriteLine("                                                                  ╚════██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
                Console.WriteLine("                                                                  ███████║╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
                Console.WriteLine("                                                                  ╚══════╝ ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

                System.Threading.Thread.Sleep(50);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                                                                         ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
                Console.WriteLine("                                                                         ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
                Console.WriteLine("                                                                         █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
                Console.WriteLine("                                                                         ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
                Console.WriteLine("                                                                         ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
                Console.WriteLine("                                                                         ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
                Console.WriteLine("                                                                   ███████╗ ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
                Console.WriteLine("                                                                   ██╔════╝██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
                Console.WriteLine("                                                                   ███████╗██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
                Console.WriteLine("                                                                   ╚════██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
                Console.WriteLine("                                                                   ███████║╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
                Console.WriteLine("                                                                   ╚══════╝ ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

                System.Threading.Thread.Sleep(50);

                sayı--;

            }


        up:
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("                                                                        YENİDEN DENEMEK İÇİN '1', ÇIKMAK İÇİN '2' TUŞUNA BASINIZ");
            string son = Console.ReadLine();

            if (son == "1")
            {
                System.Diagnostics.Process.Start(Environment.GetCommandLineArgs()[0]);
                Environment.Exit(0);


            }

            else if (son == "2")
            {
                Environment.Exit(0);
            }

            else
                Console.Clear();
            goto up;








        }
        static void kazan1000()
        {

            Console.WriteLine("\n\n\n");

Console.WriteLine("              ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗                                 ");
Console.WriteLine("              ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝                                 ");
Console.WriteLine("              █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║                                      ");
Console.WriteLine("              ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║                                      ");
Console.WriteLine("              ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗                                 ");
Console.WriteLine("              ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝                                 ");
Console.WriteLine("      ██╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗                      ");
Console.WriteLine("     ███║██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║                      ");
Console.WriteLine("     ╚██║██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║                      ");
Console.WriteLine("      ██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║                      ");
Console.WriteLine("      ██║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║                      ");
Console.WriteLine("      ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝                      ");
            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                       ██╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                      ███║██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                      ╚██║██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                       ██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                       ██║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                       ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                      ██╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                     ███║██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                     ╚██║██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                      ██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                      ██║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                      ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");
            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("               ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("               ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("               █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("               ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("               ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("               ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("      ██╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ███║██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("     ╚██║██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("      ██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("      ██║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("      ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("      ██╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ███║██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("     ╚██║██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("      ██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("      ██║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("      ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                       ██╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                      ███║██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                      ╚██║██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                       ██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                       ██║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                       ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                       ██╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                      ███║██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                      ╚██║██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                       ██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                       ██║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                       ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("             ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("             ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("             █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("             ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("             ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("             ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("      ██╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ███║██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("     ╚██║██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("      ██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("      ██║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("      ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();


            int sayı = 10;


            while (sayı > 0)
            {



                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("                                                                        ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
                Console.WriteLine("                                                                        ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
                Console.WriteLine("                                                                        █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
                Console.WriteLine("                                                                        ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
                Console.WriteLine("                                                                        ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
                Console.WriteLine("                                                                        ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
                Console.WriteLine("                                                               ██╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
                Console.WriteLine("                                                              ███║██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
                Console.WriteLine("                                                              ╚██║██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
                Console.WriteLine("                                                               ██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
                Console.WriteLine("                                                               ██║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
                Console.WriteLine("                                                               ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

                System.Threading.Thread.Sleep(50);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                                                                         ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
                Console.WriteLine("                                                                         ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
                Console.WriteLine("                                                                         █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
                Console.WriteLine("                                                                         ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
                Console.WriteLine("                                                                         ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
                Console.WriteLine("                                                                         ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
                Console.WriteLine("                                                                ██╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
                Console.WriteLine("                                                               ███║██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
                Console.WriteLine("                                                               ╚██║██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
                Console.WriteLine("                                                                ██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
                Console.WriteLine("                                                                ██║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
                Console.WriteLine("                                                                ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

                System.Threading.Thread.Sleep(50);

                sayı--;

            }


        up:
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("                                                                        YENİDEN DENEMEK İÇİN '1', ÇIKMAK İÇİN '2' TUŞUNA BASINIZ");
            string son = Console.ReadLine();

            if (son == "1")
            {
                System.Diagnostics.Process.Start(Environment.GetCommandLineArgs()[0]);
                Environment.Exit(0);


            }

            else if (son == "2")
            {
                Environment.Exit(0);
            }

            else
                Console.Clear();
            goto up;








        }
        static void kazan2000()
        {

            Console.WriteLine("\n\n\n");

            Console.WriteLine("                 ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗            ");
            Console.WriteLine("                 ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝            ");
            Console.WriteLine("                 █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║                 ");
            Console.WriteLine("                 ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║                 ");
            Console.WriteLine("                 ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗            ");
            Console.WriteLine("                 ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝            ");
            Console.WriteLine("     ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("      █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("     ██╔═══╝ ████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("     ███████╗╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("     ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");


            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                  ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                  ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                   █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                  ██╔═══╝ ████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                  ███████╗╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                  ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                  ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                  ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                   █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                  ██╔═══╝ ████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                  ███████╗╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                  ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");
            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("     ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("      █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("     ██╔═══╝ ████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("     ███████╗╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("     ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                 ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                 ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                 █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                 ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                 ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                 ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("     ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("      █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("     ██╔═══╝ ████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("     ███████╗╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("     ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                 ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                 ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                  █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                 ██╔═══╝ ████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                 ███████╗╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                 ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                 ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                 ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                  █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                 ██╔═══╝ ████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                 ███████╗╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                 ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                 ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                 ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                 █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                 ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                 ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                 ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("     ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("      █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("     ██╔═══╝ ████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("     ███████╗╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("     ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();


            int sayı = 10;


            while (sayı > 0)
            {



                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("                                                                        ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
                Console.WriteLine("                                                                        ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
                Console.WriteLine("                                                                        █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
                Console.WriteLine("                                                                        ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
                Console.WriteLine("                                                                        ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
                Console.WriteLine("                                                                        ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
                Console.WriteLine("                                                         ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
                Console.WriteLine("                                                         ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
                Console.WriteLine("                                                          █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
                Console.WriteLine("                                                         ██╔═══╝ ████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
                Console.WriteLine("                                                         ███████╗╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
                Console.WriteLine("                                                         ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

                System.Threading.Thread.Sleep(50);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                                                                         ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
                Console.WriteLine("                                                                         ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
                Console.WriteLine("                                                                         █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
                Console.WriteLine("                                                                         ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
                Console.WriteLine("                                                                         ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
                Console.WriteLine("                                                                         ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
                Console.WriteLine("                                                          ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
                Console.WriteLine("                                                          ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
                Console.WriteLine("                                                           █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
                Console.WriteLine("                                                          ██╔═══╝ ████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
                Console.WriteLine("                                                          ███████╗╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
                Console.WriteLine("                                                          ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

                System.Threading.Thread.Sleep(50);

                sayı--;

            }


        up:
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("                                                                        YENİDEN DENEMEK İÇİN '1', ÇIKMAK İÇİN '2' TUŞUNA BASINIZ");
            string son = Console.ReadLine();

            if (son == "1")
            {
                System.Diagnostics.Process.Start(Environment.GetCommandLineArgs()[0]);
                Environment.Exit(0);


            }

            else if (son == "2")
            {
                Environment.Exit(0);
            }

            else
                Console.Clear();
            goto up;








        }
        static void kazan3000()
        {

            Console.WriteLine("\n\n\n");

            Console.WriteLine("                 ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗            ");
            Console.WriteLine("                 ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝            ");
            Console.WriteLine("                 █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║                 ");
            Console.WriteLine("                 ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║                 ");
            Console.WriteLine("                 ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗            ");
            Console.WriteLine("                 ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝            ");
            Console.WriteLine("      ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗   ");
            Console.WriteLine("      ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║   ");
            Console.WriteLine("       █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║   ");
            Console.WriteLine("       ╚═══██╗████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║   ");
            Console.WriteLine("      ██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║   ");
            Console.WriteLine("      ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝   ");      
            
            
            
         
         
         
         
         
         
            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                 ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                 ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                  █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                  ╚═══██╗████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                 ██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                 ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                 ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                 ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                  █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                  ╚═══██╗████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                 ██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                 ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");
            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("     ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("      █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("      ╚═══██╗████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("     ██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("     ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("     ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("      █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("      ╚═══██╗████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("     ██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("     ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                 ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                 ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                  █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                  ╚═══██╗████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                 ██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                 ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                  ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                  ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                   █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                   ╚═══██╗████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                  ██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                  ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("     ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("      █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("      ╚═══██╗████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("     ██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("     ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();


            int sayı = 10;


            while (sayı > 0)
            {



                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("                                                                        ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
                Console.WriteLine("                                                                        ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
                Console.WriteLine("                                                                        █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
                Console.WriteLine("                                                                        ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
                Console.WriteLine("                                                                        ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
                Console.WriteLine("                                                                        ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
                Console.WriteLine("                                                         ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
                Console.WriteLine("                                                         ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
                Console.WriteLine("                                                          █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
                Console.WriteLine("                                                          ╚═══██╗████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
                Console.WriteLine("                                                         ██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
                Console.WriteLine("                                                         ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

                System.Threading.Thread.Sleep(50);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                                                                         ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
                Console.WriteLine("                                                                         ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
                Console.WriteLine("                                                                         █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
                Console.WriteLine("                                                                         ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
                Console.WriteLine("                                                                         ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
                Console.WriteLine("                                                                         ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
                Console.WriteLine("                                                          ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
                Console.WriteLine("                                                          ╚════██╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
                Console.WriteLine("                                                           █████╔╝██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
                Console.WriteLine("                                                           ╚═══██╗████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
                Console.WriteLine("                                                          ██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
                Console.WriteLine("                                                          ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

                System.Threading.Thread.Sleep(50);

                sayı--;

            }


        up:
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("                                                                        YENİDEN DENEMEK İÇİN '1', ÇIKMAK İÇİN '2' TUŞUNA BASINIZ");
            string son = Console.ReadLine();

            if (son == "1")
            {
                System.Diagnostics.Process.Start(Environment.GetCommandLineArgs()[0]);
                Environment.Exit(0);


            }

            else if (son == "2")
            {
                Environment.Exit(0);
            }

            else
                Console.Clear();
            goto up;








        }
        static void kazan5000()
        {


            Console.WriteLine("\n\n\n");

            Console.WriteLine("                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗            ");
            Console.WriteLine("                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝            ");
            Console.WriteLine("                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║                 ");
            Console.WriteLine("                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║                 ");
            Console.WriteLine("                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗            ");
            Console.WriteLine("                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝            ");
            Console.WriteLine("     ███████╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗   ");
            Console.WriteLine("     ██╔════╝██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║   ");
            Console.WriteLine("     ███████╗██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║   ");
            Console.WriteLine("     ╚════██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║   ");
            Console.WriteLine("     ███████║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║   ");
            Console.WriteLine("     ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝   ");
            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                 ███████╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                 ██╔════╝██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                 ███████╗██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                 ╚════██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                 ███████║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                 ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                 ███████╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                 ██╔════╝██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                 ███████╗██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                 ╚════██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                 ███████║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                 ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");
            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("     ███████╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ██╔════╝██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("     ███████╗██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("     ╚════██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("     ███████║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("     ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("     ███████╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ██╔════╝██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("     ███████╗██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("     ╚════██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("     ███████║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("     ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                 ███████╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                 ██╔════╝██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                 ███████╗██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                 ╚════██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                 ███████║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                 ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                                 ███████╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                                 ██╔════╝██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                                 ███████╗██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                                 ╚════██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                                 ███████║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                                 ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("     ███████╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ██╔════╝██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("     ███████╗██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("     ╚════██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("     ███████║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("     ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();


            int sayı = 10;


            while (sayı > 0)
            {



                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("                                                                        ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
                Console.WriteLine("                                                                        ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
                Console.WriteLine("                                                                        █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
                Console.WriteLine("                                                                        ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
                Console.WriteLine("                                                                        ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
                Console.WriteLine("                                                                        ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
                Console.WriteLine("                                                         ███████╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
                Console.WriteLine("                                                         ██╔════╝██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
                Console.WriteLine("                                                         ███████╗██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
                Console.WriteLine("                                                         ╚════██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
                Console.WriteLine("                                                         ███████║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
                Console.WriteLine("                                                         ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

                System.Threading.Thread.Sleep(50);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                                                                         ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
                Console.WriteLine("                                                                         ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
                Console.WriteLine("                                                                         █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
                Console.WriteLine("                                                                         ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
                Console.WriteLine("                                                                         ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
                Console.WriteLine("                                                                         ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
                Console.WriteLine("                                                          ███████╗ ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
                Console.WriteLine("                                                          ██╔════╝██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
                Console.WriteLine("                                                          ███████╗██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
                Console.WriteLine("                                                          ╚════██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
                Console.WriteLine("                                                          ███████║╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
                Console.WriteLine("                                                          ╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

                System.Threading.Thread.Sleep(50);

                sayı--;

            }


        up:
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("                                                                        YENİDEN DENEMEK İÇİN '1', ÇIKMAK İÇİN '2' TUŞUNA BASINIZ");
            string son = Console.ReadLine();

            if (son == "1")
            {
                System.Diagnostics.Process.Start(Environment.GetCommandLineArgs()[0]);
                Environment.Exit(0);


            }

            else if (son == "2")
            {
                Environment.Exit(0);
            }

            else
                Console.Clear();
            goto up;








        }
        static void kazan10000()
        {

            Console.WriteLine("\n\n\n");

            Console.WriteLine("                    ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗            ");
            Console.WriteLine("                    ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝            ");
            Console.WriteLine("                    █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║                 ");
            Console.WriteLine("                    ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║                 ");
            Console.WriteLine("                    ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗            ");
            Console.WriteLine("                    ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝            ");
            Console.WriteLine("      ██╗ ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗   ");
            Console.WriteLine("     ███║██╔═████╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║   ");
            Console.WriteLine("     ╚██║██║██╔██║██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║   ");
            Console.WriteLine("      ██║████╔╝██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║   ");
            Console.WriteLine("      ██║╚██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║   ");
            Console.WriteLine("      ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝   ");
            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                             ██╗ ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                            ███║██╔═████╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                            ╚██║██║██╔██║██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                             ██║████╔╝██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                             ██║╚██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                             ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                             ██╗ ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                            ███║██╔═████╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                            ╚██║██║██╔██║██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                             ██║████╔╝██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                             ██║╚██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                             ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");
            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                    ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                    ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                    █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                    ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                    ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                    ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("      ██╗ ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ███║██╔═████╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("     ╚██║██║██╔██║██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("      ██║████╔╝██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("      ██║╚██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("      ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                     ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                     ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                     █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                     ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                     ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                     ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("      ██╗ ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ███║██╔═████╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("     ╚██║██║██╔██║██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("      ██║████╔╝██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("      ██║╚██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("      ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                             ██╗ ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                            ███║██╔═████╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                            ╚██║██║██╔██║██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                             ██║████╔╝██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                             ██║╚██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                             ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("\n\n\n");

            Console.WriteLine("                                                                                                                                ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                                                                                                                                ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                                                                                                                                █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                                                                                                                                ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                                                                                                                                ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                                                                                                                                ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("                                                                                                             ██╗ ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("                                                                                                            ███║██╔═████╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("                                                                                                            ╚██║██║██╔██║██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("                                                                                                             ██║████╔╝██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("                                                                                                             ██║╚██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("                                                                                                             ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                      ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
            Console.WriteLine("                      ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
            Console.WriteLine("                      █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
            Console.WriteLine("                      ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
            Console.WriteLine("                      ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
            Console.WriteLine("                      ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
            Console.WriteLine("      ██╗ ██████╗  ██████╗  ██████╗  ██████╗     ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
            Console.WriteLine("     ███║██╔═████╗██╔═████╗██╔═████╗██╔═████╗    ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
            Console.WriteLine("     ╚██║██║██╔██║██║██╔██║██║██╔██║██║██╔██║    ██████╔╝██║   ██║███████║██╔██╗ ██║");
            Console.WriteLine("      ██║████╔╝██║████╔╝██║████╔╝██║████╔╝██║    ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
            Console.WriteLine("      ██║╚██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██║     ╚██████╔╝██║  ██║██║ ╚████║");
            Console.WriteLine("      ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

            System.Threading.Thread.Sleep(150);
            Console.Clear();


            int sayı = 10;


            while (sayı > 0)
            {



                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("                                                                        ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
                Console.WriteLine("                                                                        ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
                Console.WriteLine("                                                                        █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
                Console.WriteLine("                                                                        ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
                Console.WriteLine("                                                                        ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
                Console.WriteLine("                                                                        ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
                Console.WriteLine("                                                            ██╗ ██████╗  ██████╗  ██████╗  ██████╗    ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
                Console.WriteLine("                                                           ███║██╔═████╗██╔═████╗██╔═████╗██╔═████╗   ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
                Console.WriteLine("                                                           ╚██║██║██╔██║██║██╔██║██║██╔██║██║██╔██║   ██████╔╝██║   ██║███████║██╔██╗ ██║");
                Console.WriteLine("                                                            ██║████╔╝██║████╔╝██║████╔╝██║████╔╝██║   ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
                Console.WriteLine("                                                            ██║╚██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝   ██║     ╚██████╔╝██║  ██║██║ ╚████║");
                Console.WriteLine("                                                            ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝    ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

                System.Threading.Thread.Sleep(50);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                                                                         ██╗  ██╗ █████╗ ███████╗ █████╗ ███╗   ██╗ ██████╗         ");
                Console.WriteLine("                                                                         ██║ ██╔╝██╔══██╗╚══███╔╝██╔══██╗████╗  ██║██╔════╝         ");
                Console.WriteLine("                                                                         █████╔╝ ███████║  ███╔╝ ███████║██╔██╗ ██║██║              ");
                Console.WriteLine("                                                                         ██╔═██╗ ██╔══██║ ███╔╝  ██╔══██║██║╚██╗██║██║              ");
                Console.WriteLine("                                                                         ██║  ██╗██║  ██║███████╗██║  ██║██║ ╚████║╚██████╗         ");
                Console.WriteLine("                                                                         ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝         ");
                Console.WriteLine("                                                            ██╗ ██████╗  ██████╗  ██████╗  ██████╗    ██████╗ ██╗   ██╗ █████╗ ███╗   ██╗");
                Console.WriteLine("                                                           ███║██╔═████╗██╔═████╗██╔═████╗██╔═████╗   ██╔══██╗██║   ██║██╔══██╗████╗  ██║");
                Console.WriteLine("                                                           ╚██║██║██╔██║██║██╔██║██║██╔██║██║██╔██║   ██████╔╝██║   ██║███████║██╔██╗ ██║");
                Console.WriteLine("                                                            ██║████╔╝██║████╔╝██║████╔╝██║████╔╝██║   ██╔═══╝ ██║   ██║██╔══██║██║╚██╗██║");
                Console.WriteLine("                                                            ██║╚██████╔╝╚██████╔╝╚██████╔╝╚██████╔╝   ██║     ╚██████╔╝██║  ██║██║ ╚████║");
                Console.WriteLine("                                                            ╚═╝ ╚═════╝  ╚═════╝  ╚═════╝  ╚═════╝    ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝");

                System.Threading.Thread.Sleep(50);

                sayı--;

            }


        up:
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("                                                                        YENİDEN DENEMEK İÇİN '1', ÇIKMAK İÇİN '2' TUŞUNA BASINIZ");
            string son = Console.ReadLine();

            if (son == "1")
            {
                System.Diagnostics.Process.Start(Environment.GetCommandLineArgs()[0]);
                Environment.Exit(0);


            }

            else if (son == "2")
            {
                Environment.Exit(0);
            }

            else
                Console.Clear();
            goto up;








        }
 


    }
}
