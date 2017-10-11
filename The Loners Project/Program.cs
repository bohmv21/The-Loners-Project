﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Escape_room
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 40);
            //huis();
            Thread.Sleep(2000);
            // Intro();
            Mainswitch();

        }


        static void Mainswitch()
        {
            Kamer1();
            int x = 1;
            do
            {
                string Line = Convert.ToString(Console.ReadLine());
                switch (Line.ToLower())
                {
                    case "inspect pillow":
                        pillow();
                        Mainswitch2();
                        break;

                    case "back":
                        Kamer1();
                        break;

                    case "help":
                        help();
                        break;

                    case "enter left door":
                        Kamer2Switch();
                        break;

                    case "enter right door":
                        Kamer3();
                        break;

                    case "":
                        break;

                    default:
                        Console.WriteLine("Please enter help to look at functions");
                        break;
                }
            } while (x == 1);
        }

        static void Mainswitch2()
        {
            Kamer1();
            int x = 1;
            do
            {
                string Line = Convert.ToString(Console.ReadLine());
                switch (Line.ToLower())
                {
                    case "search pillow":
                        note();
                        break;

                    case "back":
                        x = 0;
                        Kamer1();
                        break;

                    case "help":
                        help();
                        break;

                    case "gsdg":
                        break;

                    default:
                        Console.WriteLine("Please enter help to look at functions");
                        break;
                }
            } while (x == 1);
        }

        static void Kamer2Switch()
        {
            Kamer2();
            int x = 1;
            do
            {
                string Line = Convert.ToString(Console.ReadLine());
                switch (Line.ToLower())
                {                   
                    case "inspect body":
                        body();
                        Kamer2Switch2();
                        break;

                    case "back":
                        x = 0;
                        Kamer1();
                        break;

                    case "help":
                        help();
                        Kamer2();
                        break;

                    default:
                        Console.WriteLine("Please enter help to look at functions");
                        break;
                }
            } while (x == 1);
        }

        static void Kamer2Switch2()
        {
            int x = 1;
            do
            {
                string Line = Convert.ToString(Console.ReadLine());
                switch (Line.ToLower())
                {
                    case "search pocket":
                        pocket();
                        break;

                    case "back":
                        x = 0;
                        Kamer2();
                        break;

                    case "help":
                        x = 0;
                        help();
                        Kamer2();
                        break;

                    default:
                        Console.WriteLine("Please enter help to look at functions");
                        break;
                }
            } while (x == 1);
        }

        static void Kamer3Switch()
        {
            Kamer3();
            int x = 1;
            do
            {
                string Line = Convert.ToString(Console.ReadLine());
                switch (Line.ToLower())
                {
                    case "inspect":
                        break;

                    case "back":
                        x = 0;
                        Kamer1();
                        break;

                    case "help":
                        help();
                        Kamer3();
                        break;

                    default:
                        Console.WriteLine("Please enter help to look at functions");
                        break;
                }
            } while (x == 1);
        }

        static void huis()
        {
            string path = @"Data/";
            string name = "landhuis.txt";
            string zoom = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(zoom);
        }

        static void Kamer1()
        {
            string path = @"Data/";
            string name = "Kamer1.txt";
            string room = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(room);

        }

        static void Kamer2()
        {
            string path = @"Data/";
            string name = "Kamer2.txt";
            string room = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(room);
        }

        static void Kamer3()
        {
            string path = @"Data/";
            string name = "Kamer3.txt";
            string room = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(room);
        }

        static void Kamer4()
        {
            string path = @"Data/";
            string name = "kamer4.txt";
            File.ReadAllLines(path + name);
        }

        static void pillow()
        {
            string path = @"Data/";
            string name = "Pillow.txt";
            string zoom = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(zoom);
        }

        static void body()
        {
            string path = @"Data/";
            string name = "pocket.txt";
            string zoom = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(zoom);

        }

        static void pocket()
        {
            string path = @"Data/";
            string name = "idandbadge.txt";
            string zoom = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(zoom);
        }

        static void Inventory()
        {
            string path = @"Data/";
            string name = "inventory.txt";
            File.ReadAllLines(path + name);
        }

        static void Intro()
        {
            Console.Clear();
            string IntroText = "Welcome to the escape room";
            for (int i = 0; i < IntroText.Length; i++)
            {
                Console.Write(IntroText[i]);
                Thread.Sleep(50);
            }
            Thread.Sleep(1000);
            Console.Clear();


            string IntroRules = "There are some keywords u will need to use for this escape room : " + "\r\n";
            for (int i = 0; i < IntroRules.Length; i++)
            {
                Console.Write(IntroRules[i]);
                Thread.Sleep(50);
            }


            string KeyWordInspect = "Inspect" + "\r\n";
            for (int i = 0; i < KeyWordInspect.Length; i++)
            {
                Console.Write(KeyWordInspect[i]);
                Thread.Sleep(50);
            }

            string KeyWordSearch = "Search" + "\r\n";
            for (int i = 0; i < KeyWordSearch.Length; i++)
            {
                Console.Write(KeyWordSearch[i]);
                Thread.Sleep(50);
            }

            string KeyWordUse = "Use" + "\r\n";
            for (int i = 0; i < KeyWordUse.Length; i++)
            {
                Console.Write(KeyWordUse[i]);
                Thread.Sleep(50);
            }

            string KeyWordBack = "Back" + "\r\n";
            for (int i = 0; i < KeyWordBack.Length; i++)
            {
                Console.Write(KeyWordBack[i]);
                Thread.Sleep(50);
            }

            string KeyWordEnter = "Enter" + "\r\n";
            for (int i = 0; i < KeyWordEnter.Length; i++)
            {
                Console.Write(KeyWordEnter[i]);
                Thread.Sleep(50);
            }
        }

        static void help()
        {
            Console.Clear();

            string title = "These are all the available commands" + "\r\n";
            for (int i = 0; i < title.Length; i++)
            {
                Console.Write(title[i]);
                Thread.Sleep(50);
            }
            string KeyWordInspect = "Inspect" + "\r\n";
            for (int i = 0; i < KeyWordInspect.Length; i++)
            {
                Console.Write(KeyWordInspect[i]);
                Thread.Sleep(50);
            }

            string KeyWordSearch = "Search" + "\r\n";
            for (int i = 0; i < KeyWordSearch.Length; i++)
            {
                Console.Write(KeyWordSearch[i]);
                Thread.Sleep(50);
            }

            string KeyWordUse = "Use" + "\r\n";
            for (int i = 0; i < KeyWordUse.Length; i++)
            {
                Console.Write(KeyWordUse[i]);
                Thread.Sleep(50);
            }

            string KeyWordBack = "Back" + "\r\n";
            for (int i = 0; i < KeyWordBack.Length; i++)
            {
                Console.Write(KeyWordBack[i]);
                Thread.Sleep(50);
            }

            string KeyWordEnter = "Enter" + "\r\n";
            for (int i = 0; i < KeyWordEnter.Length; i++)
            {
                Console.Write(KeyWordEnter[i]);
                Thread.Sleep(50);
            }

            string back = "Press 'ENTER' to continue";
            for (int i = 0; i < back.Length; i++)
            {
                Console.Write(back[i]);
                Thread.Sleep(50);
            }

            do
            {
            }
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter));
        }

        static void note()
        {
            string path = @"Data/";
            string name = "briefje1.txt";
            string zoom = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(zoom);
        }
    }
}
