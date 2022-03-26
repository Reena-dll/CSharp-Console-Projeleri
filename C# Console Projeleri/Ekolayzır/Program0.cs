using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{
    class Program
    {
        static void Main(string[] args)
        {

            eqo();
        }

        static void eqo()///////////////////////////////////////////////////////////////////////////////Ekolayzır DÜZ/////////////////////

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
                else if (a == 3) { Console.ForegroundColor = ConsoleColor.Black;
                    

                }
                else if (a == 4) { Console.ForegroundColor = ConsoleColor.Blue;
                    
                }
                else if (a == 5) { Console.ForegroundColor = ConsoleColor.Cyan;
                    

                }
                else if (a == 6) { Console.ForegroundColor = ConsoleColor.DarkBlue;
                    
                }
                else if (a == 7) { Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    
                }
                else if (a == 8) { Console.ForegroundColor = ConsoleColor.DarkYellow;
                   
                }
                else if (a == 9) { Console.ForegroundColor = ConsoleColor.White;
                    
                }
                else if (a == 10){ Console.ForegroundColor = ConsoleColor.DarkRed;
                    
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
                    int random = rnd.Next(1, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        



                        Console.SetCursorPosition(4, i); Console.Write("██");

                                                 
  


                    }
                }


                {
                    Random rnd = new Random();
                    int random = rnd.Next(4, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(8, i); Console.Write("██");
                    }
                }

                {
                    Random rnd = new Random();
                    int random = rnd.Next(8, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(12, i); Console.Write("██");
                    }
                }

                {
                    Random rnd = new Random();
                    int random = rnd.Next(5, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(16, i); Console.Write("██");
                    }
                }

                {
                    Random rnd = new Random();
                    int random = rnd.Next(2, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(20, i); Console.Write("██");
                    }
                }

                {
                    Random rnd = new Random();
                    int random = rnd.Next(1, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(24, i); Console.Write("██");
                    }
                }

                {
                    Random rnd = new Random();
                    int random = rnd.Next(2, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(28, i); Console.Write("██");
                    }
                }

                {
                    Random rnd = new Random();
                    int random = rnd.Next(7, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(32, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(5, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(36, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(4, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(40, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(3, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(44, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(1, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    {
                        Console.SetCursorPosition(48, i); Console.Write("██");

                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(4, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(52, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(3, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(56, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(7, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(60, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(5, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(64, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(2, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(68, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(4, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(72, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(6, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(76, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(3, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(80, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(5, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(84, i); Console.Write("██");
                    }
                }
                {
                    Random rnd = new Random();
                    int random = rnd.Next(4, 25);
                    for (int i = random; i < 25 && i > 0; i++)
                    { Console.SetCursorPosition(88, i); Console.Write("██");
                    }
                }


                System.Threading.Thread.Sleep(50);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

            }
        }

    }
}
