using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijital_Saat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;



            while (true)
            {

                

                Console.Title = "Dijital Saat";
                Console.SetWindowSize(143, 20);
                Console.CursorVisible = false;
                string s1, s2, d1, d2, sn1, sn2;
                DateTime dt = DateTime.Now;
                string zaman = Convert.ToString(dt);

                Console.SetCursorPosition(0, 18);
                Console.WriteLine("{0:D}", dt);

                Console.SetCursorPosition(92, 17);
                Console.WriteLine("╔╗ ╦ ╦  ╦═╗╔═╗╔═╗╦ ╦╦    ╔═╗╔═╗╔╦╗╦╦╔═╔═╗╔═╗╦  ╦ ╦");
                Console.SetCursorPosition(92, 18);
                Console.WriteLine("╠╩╗╚╦╝  ╠╦╝║╣ ╚═╗║ ║║    ╚═╗╠═╣ ║║║╠╩╗║ ║║ ╦║  ║ ║");
                Console.SetCursorPosition(92, 19);
                Console.WriteLine("╚═╝ ╩   ╩╚═╚═╝╚═╝╚═╝╩═╝  ╚═╝╩ ╩═╩╝╩╩ ╩╚═╝╚═╝╩═╝╚═╝");



                Console.SetCursorPosition(63, 17);
                Console.WriteLine("╦ ╦╦ ╦╔═╗╔╦╗╔═╗╦ ╦");
                Console.SetCursorPosition(63, 18);
                Console.WriteLine("║║║╠═╣╠═╣ ║ ║  ╠═╣");
                Console.SetCursorPosition(63, 19);
                Console.WriteLine("╚╩╝╩ ╩╩ ╩ ╩ ╚═╝╩ ╩");

                s1 = Convert.ToString(zaman[11]);
                s2 = Convert.ToString(zaman[12]);
                d1 = Convert.ToString(zaman[14]);
                d2 = Convert.ToString(zaman[15]);
                sn1 = Convert.ToString(zaman[17]);
                sn2 = Convert.ToString(zaman[18]);

                                                                      //12:12:56
                if (s1 == "0")
                    resim0(0);
                else if (s1 == "1")
                    resim1(0);
                else if (s1 == "2")
                    resim2(0);
                else if (s1 == "3")
                    resim3(0);
                else if (s1 == "4")
                    resim4(0);
                else if (s1 == "5")
                    resim5(0);
                else if (s1 == "6")
                    resim6(0);
                else if (s1 == "7")
                    resim7(0);
                else if (s1 == "8")
                    resim8(0);
                else if (s1 == "9")
                    resim9(0);

                if (s2 == "0")
                    resim0(20);
                else if (s2 == "1")
                    resim1(20);
                else if (s2 == "2")
                    resim2(20);
                else if (s2 == "3")
                    resim3(20);
                else if (s2 == "4")
                    resim4(20);
                else if (s2 == "5")
                    resim5(20);
                else if (s2 == "6")
                    resim6(20);
                else if (s2 == "7")
                    resim7(20);
                else if (s2 == "8")
                    resim8(20);
                else if (s2 == "9")
                    resim9(20);

                resimnokta(42);

                if (d1 == "0")
                    resim0(50);
                else if (d1 == "1")
                    resim1(50);
                else if (d1 == "2")
                    resim2(50);
                else if (d1 == "3")
                    resim3(50);
                else if (d1 == "4")
                    resim4(50);
                else if (d1 == "5")
                    resim5(50);
                else if (d1 == "6")
                    resim6(50);
                else if (d1 == "7")
                    resim7(50);
                else if (d1 == "8")
                    resim8(50);
                else if (d1 == "9")
                    resim9(50);

                if (d2 == "0")
                    resim0(70);
                else if (d2 == "1")
                    resim1(70);
                else if (d2 == "2")
                    resim2(70);
                else if (d2 == "3")
                    resim3(70);
                else if (d2 == "4")
                    resim4(70);
                else if (d2 == "5")
                    resim5(70);
                else if (d2 == "6")
                    resim6(70);
                else if (d2 == "7")
                    resim7(70);
                else if (d2 == "8")
                    resim8(70);
                else if (d2 == "9")
                    resim9(70);

                resimnokta(92);

                if (sn1 == "0")
                    resim0(100);
                else if (sn1 == "1")
                    resim1(100);
                else if (sn1 == "2")
                    resim2(100);
                else if (sn1 == "3")
                    resim3(100);
                else if (sn1 == "4")
                    resim4(100);
                else if (sn1 == "5")
                    resim5(100);
                else if (sn1 == "6")
                    resim6(100);
                else if (sn1 == "7")
                    resim7(100);
                else if (sn1 == "8")
                    resim8(100);
                else if (sn1 == "9")
                    resim9(100);

                if (sn2 == "0")
                    resim0(121);
                else if (sn2 == "1")
                    resim1(121);
                else if (sn2 == "2")
                    resim2(121);
                else if (sn2 == "3")
                    resim3(121);
                else if (sn2 == "4")
                    resim4(121);
                else if (sn2 == "5")
                    resim5(121);
                else if (sn2 == "6")
                    resim6(121);
                else if (sn2 == "7")
                    resim7(121);
                else if (sn2 == "8")
                    resim8(121);
                else if (sn2 == "9")
                    resim9(121);
                System.Threading.Thread.Sleep(1000);
                Console.Clear();

            }


        }

        static void resim0(int a)
        {
            Console.SetCursorPosition(a, 0);
            Console.WriteLine("     000000000     ");
            Console.SetCursorPosition(a, 1);
            Console.WriteLine("   00:::::::::00   ");
            Console.SetCursorPosition(a, 2);
            Console.WriteLine(" 00:::::::::::::00 ");
            Console.SetCursorPosition(a, 3);
            Console.WriteLine("0:::::::000:::::::0");
            Console.SetCursorPosition(a, 4);
            Console.WriteLine("0::::::0   0::::::0");
            Console.SetCursorPosition(a, 5);
            Console.WriteLine("0:::::0     0:::::0");
            Console.SetCursorPosition(a, 6);
            Console.WriteLine("0:::::0     0:::::0");
            Console.SetCursorPosition(a, 7);
            Console.WriteLine("0:::::0 000 0:::::0");
            Console.SetCursorPosition(a, 8);
            Console.WriteLine("0:::::0 000 0:::::0");
            Console.SetCursorPosition(a, 9);
            Console.WriteLine("0:::::0     0:::::0");
            Console.SetCursorPosition(a, 10);
            Console.WriteLine("0:::::0     0:::::0");
            Console.SetCursorPosition(a, 11);
            Console.WriteLine("0::::::0   0::::::0");
            Console.SetCursorPosition(a, 12);
            Console.WriteLine("0:::::::000:::::::0");
            Console.SetCursorPosition(a, 13);
            Console.WriteLine(" 00:::::::::::::00 ");
            Console.SetCursorPosition(a, 14);
            Console.WriteLine("   00:::::::::00   ");
            Console.SetCursorPosition(a, 15);
            Console.WriteLine("     000000000     ");



        }
        static void resim1(int a)
        {
            Console.SetCursorPosition(a, 0);
            Console.WriteLine("        1111111  ");
            Console.SetCursorPosition(a, 1);
            Console.WriteLine("       1::::::1  ");
            Console.SetCursorPosition(a, 2);
            Console.WriteLine("      1:::::::1  ");
            Console.SetCursorPosition(a, 3);
            Console.WriteLine("      111:::::1  ");
            Console.SetCursorPosition(a, 4);
            Console.WriteLine("         1::::1  ");
            Console.SetCursorPosition(a, 5);
            Console.WriteLine("         1::::1  ");
            Console.SetCursorPosition(a, 6);
            Console.WriteLine("         1::::1  ");
            Console.SetCursorPosition(a, 7);
            Console.WriteLine("         1::::l  ");
            Console.SetCursorPosition(a, 8);
            Console.WriteLine("         1::::l  ");
            Console.SetCursorPosition(a, 9);
            Console.WriteLine("         1::::l  ");
            Console.SetCursorPosition(a, 10);
            Console.WriteLine("         1::::l  ");
            Console.SetCursorPosition(a, 11);
            Console.WriteLine("         1::::l  ");
            Console.SetCursorPosition(a, 12);
            Console.WriteLine("      111::::::11");
            Console.SetCursorPosition(a, 13);
            Console.WriteLine("      1::::::::::");
            Console.SetCursorPosition(a, 14);
            Console.WriteLine("      1::::::::::");
            Console.SetCursorPosition(a, 15);
            Console.WriteLine("      11111111111");

        }
        static void resim2(int a)
        {
            Console.SetCursorPosition(a, 0);
            Console.WriteLine(" 222222222222222      ");
            Console.SetCursorPosition(a, 1);
            Console.WriteLine("2:::::::::::::::22    ");
            Console.SetCursorPosition(a, 2);
            Console.WriteLine("2::::::222222:::::2   ");
            Console.SetCursorPosition(a, 3);
            Console.WriteLine("2222222     2:::::2   ");
            Console.SetCursorPosition(a, 4);
            Console.WriteLine("            2:::::2   ");
            Console.SetCursorPosition(a, 5);
            Console.WriteLine("            2:::::2   ");
            Console.SetCursorPosition(a, 6);
            Console.WriteLine("         2222::::2    ");
            Console.SetCursorPosition(a, 7);
            Console.WriteLine("    22222::::::22     ");
            Console.SetCursorPosition(a, 8);
            Console.WriteLine("  22::::::::222       ");
            Console.SetCursorPosition(a, 9);
            Console.WriteLine(" 2:::::22222          ");
            Console.SetCursorPosition(a, 10);
            Console.WriteLine("2:::::2               ");
            Console.SetCursorPosition(a, 11);
            Console.WriteLine("2:::::2               ");
            Console.SetCursorPosition(a, 12);
            Console.WriteLine("2:::::2       222222  ");
            Console.SetCursorPosition(a, 13);
            Console.WriteLine("2::::::2222222:::::2  ");
            Console.SetCursorPosition(a, 14);
            Console.WriteLine("2::::::::::::::::::2  ");
            Console.SetCursorPosition(a, 15);
            Console.WriteLine("22222222222222222222  ");


        }
        static void resim3(int a)
        {
            Console.SetCursorPosition(a, 0);
            Console.WriteLine("  333333333333333   ");
            Console.SetCursorPosition(a, 1);
            Console.WriteLine(" 3:::::::::::::::33 ");
            Console.SetCursorPosition(a, 2);
            Console.WriteLine(" 3::::::33333::::::3");
            Console.SetCursorPosition(a, 3);
            Console.WriteLine(" 3333333     3:::::3");
            Console.SetCursorPosition(a, 4);
            Console.WriteLine("             3:::::3");
            Console.SetCursorPosition(a, 5);
            Console.WriteLine("             3:::::3");
            Console.SetCursorPosition(a, 6);
            Console.WriteLine("     33333333:::::3 ");
            Console.SetCursorPosition(a, 7);
            Console.WriteLine("     3:::::::::::3  ");
            Console.SetCursorPosition(a, 8);
            Console.WriteLine("     33333333:::::3 ");
            Console.SetCursorPosition(a, 9);
            Console.WriteLine("             3:::::3");
            Console.SetCursorPosition(a, 10);
            Console.WriteLine("             3:::::3");
            Console.SetCursorPosition(a, 11);
            Console.WriteLine("             3:::::3");
            Console.SetCursorPosition(a, 12);
            Console.WriteLine("23333333     3:::::3");
            Console.SetCursorPosition(a, 13);
            Console.WriteLine("23::::::33333::::::3");
            Console.SetCursorPosition(a, 14);
            Console.WriteLine("23:::::::::::::::33 ");
            Console.SetCursorPosition(a, 15);
            Console.WriteLine("2 333333333333333   ");



        }
        static void resim4(int a)
        {

            Console.SetCursorPosition(a, 0);
            Console.WriteLine("       444444444  ");
            Console.SetCursorPosition(a, 1);
            Console.WriteLine("      4::::::::4  ");
            Console.SetCursorPosition(a, 2);
            Console.WriteLine("     4:::::::::4  ");
            Console.SetCursorPosition(a, 3);
            Console.WriteLine("    4::::44::::4  ");
            Console.SetCursorPosition(a, 4);
            Console.WriteLine("   4::::4 4::::4  ");
            Console.SetCursorPosition(a, 5);
            Console.WriteLine("  4::::4  4::::4  ");
            Console.SetCursorPosition(a, 6);
            Console.WriteLine(" 4::::4   4::::4  ");
            Console.SetCursorPosition(a, 7);
            Console.WriteLine("4::::444444::::444");
            Console.SetCursorPosition(a, 8);
            Console.WriteLine("4::::::::::::::::4");
            Console.SetCursorPosition(a, 9);
            Console.WriteLine("4444444444:::::444");
            Console.SetCursorPosition(a, 10);
            Console.WriteLine("          4::::4  ");
            Console.SetCursorPosition(a, 11);
            Console.WriteLine("          4::::4  ");
            Console.SetCursorPosition(a, 12);
            Console.WriteLine("          4::::4  ");
            Console.SetCursorPosition(a, 13);
            Console.WriteLine("        44::::::44");
            Console.SetCursorPosition(a, 14);
            Console.WriteLine("        4::::::::4");
            Console.SetCursorPosition(a, 15);
            Console.WriteLine("        4444444444");

        }
        static void resim5(int a)
        {
            Console.SetCursorPosition(a, 0);
            Console.WriteLine("555555555555555555");
            Console.SetCursorPosition(a, 1);
            Console.WriteLine("5::::::::::::::::5");
            Console.SetCursorPosition(a, 2);
            Console.WriteLine("5::::::::::::::::5");
            Console.SetCursorPosition(a, 3);
            Console.WriteLine("5:::::555555555555");
            Console.SetCursorPosition(a, 4);
            Console.WriteLine("5:::::5           ");
            Console.SetCursorPosition(a, 5);
            Console.WriteLine("5:::::5           ");
            Console.SetCursorPosition(a, 6);
            Console.WriteLine("5:::::5555555555  ");
            Console.SetCursorPosition(a, 7);
            Console.WriteLine("5:::::::::::::::5 ");
            Console.SetCursorPosition(a, 8);
            Console.WriteLine("555555555555:::::5");
            Console.SetCursorPosition(a, 9);
            Console.WriteLine("            5:::::");
            Console.SetCursorPosition(a, 10);
            Console.WriteLine("            5:::::");
            Console.SetCursorPosition(a, 11);
            Console.WriteLine("5555555     5:::::");
            Console.SetCursorPosition(a, 12);
            Console.WriteLine("5::::::55555::::::");
            Console.SetCursorPosition(a, 13);
            Console.WriteLine(" 55:::::::::::::55");
            Console.SetCursorPosition(a, 14);
            Console.WriteLine("   55:::::::::55  ");
            Console.SetCursorPosition(a, 15);
            Console.WriteLine("     555555555    ");

        }
        static void resim6(int a)
        {
            Console.SetCursorPosition(a, 0);
            Console.WriteLine("          66666666   ");
            Console.SetCursorPosition(a, 1);
            Console.WriteLine("         6::::::6    ");
            Console.SetCursorPosition(a, 2);
            Console.WriteLine("        6::::::6     ");
            Console.SetCursorPosition(a, 3);
            Console.WriteLine("       6::::::6      ");
            Console.SetCursorPosition(a, 4);
            Console.WriteLine("      6::::::6       ");
            Console.SetCursorPosition(a, 5);
            Console.WriteLine("     6::::::6        ");
            Console.SetCursorPosition(a, 6);
            Console.WriteLine("    6::::::6         ");
            Console.SetCursorPosition(a, 7);
            Console.WriteLine("   6::::::::66666    ");
            Console.SetCursorPosition(a, 8);
            Console.WriteLine("  6::::::::::::::66  ");
            Console.SetCursorPosition(a, 9);
            Console.WriteLine(" 56::::::66666:::::6 ");
            Console.SetCursorPosition(a, 10);
            Console.WriteLine(" 56:::::6     6:::::6");
            Console.SetCursorPosition(a, 11);
            Console.WriteLine(" 56:::::6     6:::::6");
            Console.SetCursorPosition(a, 12);
            Console.WriteLine(" 56::::::66666::::::6");
            Console.SetCursorPosition(a, 13);
            Console.WriteLine("   66:::::::::::::66 ");
            Console.SetCursorPosition(a, 14);
            Console.WriteLine("     66:::::::::66   ");
            Console.SetCursorPosition(a, 15);
            Console.WriteLine("       666666666     ");
        }
        static void resim7(int a)
        {
            Console.SetCursorPosition(a, 0);
            Console.WriteLine(" 7777777777777777777");
            Console.SetCursorPosition(a, 1);
            Console.WriteLine(" ::::::::::::::::::7");
            Console.SetCursorPosition(a, 2);
            Console.WriteLine(" ::::::::::::::::::7");
            Console.SetCursorPosition(a, 3);
            Console.WriteLine(" 77777777777:::::::7");
            Console.SetCursorPosition(a, 4);
            Console.WriteLine("           7::::::7 ");
            Console.SetCursorPosition(a, 5);
            Console.WriteLine("          7::::::7  ");
            Console.SetCursorPosition(a, 6);
            Console.WriteLine("         7::::::7   ");
            Console.SetCursorPosition(a, 7);
            Console.WriteLine("        7::::::7    ");
            Console.SetCursorPosition(a, 8);
            Console.WriteLine("       7::::::7     ");
            Console.SetCursorPosition(a, 9);
            Console.WriteLine("      7::::::7      ");
            Console.SetCursorPosition(a, 10);
            Console.WriteLine("     7::::::7       ");
            Console.SetCursorPosition(a, 11);
            Console.WriteLine("    7::::::7        ");
            Console.SetCursorPosition(a, 12);
            Console.WriteLine("   7::::::7         ");
            Console.SetCursorPosition(a, 13);
            Console.WriteLine("  7::::::7          ");
            Console.SetCursorPosition(a, 14);
            Console.WriteLine(" 7::::::7           ");
            Console.SetCursorPosition(a, 15);
            Console.WriteLine("77777777            ");

        }
        static void resim8(int a)
        {
            Console.SetCursorPosition(a, 0);
            Console.WriteLine("     888888888     ");
            Console.SetCursorPosition(a, 1);
            Console.WriteLine("   88:::::::::88   ");
            Console.SetCursorPosition(a, 2);
            Console.WriteLine(" 88:::::::::::::88 ");
            Console.SetCursorPosition(a, 3);
            Console.WriteLine("8::::::88888::::::8");
            Console.SetCursorPosition(a, 4);
            Console.WriteLine("8:::::8     8:::::8");
            Console.SetCursorPosition(a, 5);
            Console.WriteLine("8:::::8     8:::::8");
            Console.SetCursorPosition(a, 6);
            Console.WriteLine(" 8:::::88888:::::8 ");
            Console.SetCursorPosition(a, 7);
            Console.WriteLine("  8:::::::::::::8  ");
            Console.SetCursorPosition(a, 8);
            Console.WriteLine(" 8:::::88888:::::8 ");
            Console.SetCursorPosition(a, 9);
            Console.WriteLine("8:::::8     8:::::8");
            Console.SetCursorPosition(a, 10);
            Console.WriteLine("8:::::8     8:::::8");
            Console.SetCursorPosition(a, 11);
            Console.WriteLine("8:::::8     8:::::8");
            Console.SetCursorPosition(a, 12);
            Console.WriteLine("8::::::88888::::::8");
            Console.SetCursorPosition(a, 13);
            Console.WriteLine(" 88:::::::::::::88 ");
            Console.SetCursorPosition(a, 14);
            Console.WriteLine("   88:::::::::88   ");
            Console.SetCursorPosition(a, 15);
            Console.WriteLine("     888888888     ");
        }
        static void resim9(int a)
        {
            Console.SetCursorPosition(a, 0);
            Console.WriteLine("     999999999     ");
            Console.SetCursorPosition(a, 1);
            Console.WriteLine("   99:::::::::99   ");
            Console.SetCursorPosition(a, 2);
            Console.WriteLine(" 99:::::::::::::99 ");
            Console.SetCursorPosition(a, 3);
            Console.WriteLine("9::::::99999::::::9");
            Console.SetCursorPosition(a, 4);
            Console.WriteLine("9:::::9     9:::::9");
            Console.SetCursorPosition(a, 5);
            Console.WriteLine("9:::::9     9:::::9");
            Console.SetCursorPosition(a, 6);
            Console.WriteLine(" 9:::::99999::::::9");
            Console.SetCursorPosition(a, 7);
            Console.WriteLine("  99::::::::::::::9");
            Console.SetCursorPosition(a, 8);
            Console.WriteLine("    99999::::::::9 ");
            Console.SetCursorPosition(a, 9);
            Console.WriteLine("         9::::::9  ");
            Console.SetCursorPosition(a, 10);
            Console.WriteLine("        9::::::9   ");
            Console.SetCursorPosition(a, 11);
            Console.WriteLine("       9::::::9    ");
            Console.SetCursorPosition(a, 12);
            Console.WriteLine("      9::::::9     ");
            Console.SetCursorPosition(a, 13);
            Console.WriteLine("     9::::::9      ");
            Console.SetCursorPosition(a, 14);
            Console.WriteLine("    9::::::9       ");
            Console.SetCursorPosition(a, 15);
            Console.WriteLine("   99999999        ");

        }

        static void resimnokta(int a)
        {
            Console.SetCursorPosition(a, 4);
            Console.WriteLine("::::::");
            Console.SetCursorPosition(a, 5);
            Console.WriteLine("::::::");
            Console.SetCursorPosition(a, 6);
            Console.WriteLine("::::::");
            Console.SetCursorPosition(a, 7);
            Console.WriteLine("      ");
            Console.SetCursorPosition(a, 8);
            Console.WriteLine("      ");
            Console.SetCursorPosition(a, 9);
            Console.WriteLine("      ");
            Console.SetCursorPosition(a, 10);
            Console.WriteLine("::::::");
            Console.SetCursorPosition(a, 11);
            Console.WriteLine("::::::");
            Console.SetCursorPosition(a, 12);
            Console.WriteLine("::::::");


        }



    }



}
