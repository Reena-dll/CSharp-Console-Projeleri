using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KeyWord
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.CursorVisible = false;


            Console.Title="KeyWords";
            Console.BackgroundColor = ConsoleColor.DarkBlue;                                         
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            words();

        }

      static void words()
        {
            for (;;)
            {
                Console.SetWindowSize(120, 30);

Console.WriteLine("                :::    ::: :::::::::: :::   ::: :::       :::  ::::::::  :::::::::  :::::::::   ::::::::  ");
Console.WriteLine("                :+:   :+:  :+:        :+:   :+: :+:       :+: :+:    :+: :+:    :+: :+:    :+: :+:    :+: ");
Console.WriteLine("                +:+  +:+   +:+         +:+ +:+  +:+       +:+ +:+    +:+ +:+    +:+ +:+    +:+ +:+        ");
Console.WriteLine("                +#++:++    +#++:++#     +#++:   +#+  +:+  +#+ +#+    +:+ +#++:++#:  +#+    +:+ +#++:++#++ ");
Console.WriteLine("                +#+  +#+   +#+           +#+    +#+ +#+#+ +#+ +#+    +#+ +#+    +#+ +#+    +#+        +#+ ");
Console.WriteLine("                #+#   #+#  #+#           #+#     #+#+# #+#+#  #+#    #+# #+#    #+# #+#    #+# #+#    #+# ");
Console.WriteLine("                ###    ### ##########    ###      ###   ###    ########  ###    ### #########   ########  \n");

                Console.SetCursorPosition(68, 26);
                Console.WriteLine("╔╗ ╦ ╦  ╦═╗╔═╗╔═╗╦ ╦╦    ╔═╗╔═╗╔╦╗╦╦╔═╔═╗╔═╗╦  ╦ ╦");
                Console.SetCursorPosition(68, 27);
                Console.WriteLine("╠╩╗╚╦╝  ╠╦╝║╣ ╚═╗║ ║║    ╚═╗╠═╣ ║║║╠╩╗║ ║║ ╦║  ║ ║");
                Console.SetCursorPosition(68, 28);
                Console.WriteLine("╚═╝ ╩   ╩╚═╚═╝╚═╝╚═╝╩═╝  ╚═╝╩ ╩═╩╝╩╩ ╩╚═╝╚═╝╩═╝╚═╝");





                int basamak, sayışifre;

                Random rnd = new Random();
                Console.SetCursorPosition(0, 10);

                Console.Write("=>Oluşturulacak şifrenin basamak sayısını giriniz :");
                basamak = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.Write("=>Kaç Şifre üretilsin..?");
                sayışifre = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.Write("=>Oluşturulacak dosyanın ismini yazınız...");
                string dosyaadı = Console.ReadLine();
                Console.WriteLine("");


                string dosya = @"..\..\"+dosyaadı+".txt";
                FileStream fs1 = new FileStream(dosya, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs1);

                Console.Write("=>Büyük harfleri kullanmak için '1'e:\n=>Küçük harfleri kullanmak için'2'ye:\n=>Rakamları kullanmak için '3'e basınız...");
                string tür = Console.ReadLine();

                if (tür == "1")
                {

                    for (int i = 0; i <= sayışifre; i++)
                    {
                        for (int a = 0; a < basamak; a++)
                        {
                            int sayı = rnd.Next(65, 91);
                            sw.Write((char)sayı);

                        }
                        sw.WriteLine("");
                    }

                    sw.Close();

                    Console.WriteLine("=>Dosyanız ana dizinde oluşturuldu...\n\n");

                   

                   


                    Console.Write("=>Yeni şifre doyası oluşturmak ister misiniz..?(e/h)");
                    string onay = Console.ReadLine();
                    Console.WriteLine("");


                    if (onay == "e" || onay == "E")
                    { Console.Clear(); }
                    else
                        break;

                }

                if (tür == "2")
                {

                    for (int i = 0; i <= sayışifre; i++)
                    {
                        for (int a = 0; a < basamak; a++)
                        {
                            int sayı = rnd.Next(97, 123);
                            sw.Write((char)sayı);

                        }
                        sw.WriteLine("");
                    }

                    sw.Close();

                    Console.WriteLine("=>Dosyanız ana dizinde oluşturuldu...\n\n");


                    Console.Write("=>Yeni şifre doyası oluşturmak ister misiniz..?(e/h)");
                    string onay = Console.ReadLine();
                    Console.WriteLine("");

                    if (onay == "e" || onay == "E")
                    { Console.Clear(); }
                    else
                        break;

                }

                if (tür == "3")
                {

                    for (int i = 0; i <= sayışifre; i++)
                    {
                        for (int a = 0; a < basamak; a++)
                        {
                            int sayı = rnd.Next(0, 10);
                            sw.Write(sayı);

                        }
                        sw.WriteLine("");
                    }

                    sw.Close();

                    Console.WriteLine("=>Dosyanız ana dizinde oluşturuldu...\n\n");


                    Console.Write("=>Yeni şifre doyası oluşturmak ister misiniz..?(e/h)");
                    string onay = Console.ReadLine();
                    Console.WriteLine("");

                    if (onay == "e" || onay == "E")
                    { Console.Clear(); }
                    else
                        break;

                }

                else;

            }

            
            Environment.Exit(0);

        }

        
    }
}
