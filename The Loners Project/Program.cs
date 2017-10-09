using System;
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
            Intro();
            Console.ReadLine();
        }

    
        static void Kamer1()
        {
            string path = @"Data/";
            string name = "kamer1.txt" ;
            File.ReadAllLines(path + name);
        }
        static void Kamer2()
        {
            string path = @"Data/";
            string name = "kamer2.txt";
            File.ReadAllLines(path + name);
        }
        static void Kamer3()
        {
            string path = @"Data/";
            string name = "kamer3.txt";
            File.ReadAllLines(path + name);
        }
        static void Kamer4()
        {
            string path = @"Data/";
            string name = "kamer4.txt";
            File.ReadAllLines(path + name);
        }

        static void Inventory()
        {
            string path = @"Data/";
            string name = "inventory.txt";
            File.ReadAllLines(path + name);
        }

        static void Intro()
        {
            string IntroText = "Welcome to the escape room";
            var varIntroText = "";
            for (int i = 0; i < IntroText.Length; i++)
            {
                varIntroText += IntroText[i];
                Console.Clear();
                Console.WriteLine(varIntroText);
                Thread.Sleep(50);
            }
            Thread.Sleep(1000);


            string IntroRules = "There are some keywords u will need to use for this escape room :";
            var varIntroRules = "";
            for (int i = 0; i < IntroRules.Length; i++)
            {
                varIntroRules += IntroRules[i];
                Console.Clear();
                Console.WriteLine(varIntroRules);
                Thread.Sleep(50);
            }

            string KeyWordInspect = "Inspect";
            var varKeyWordInspect = "";
            for (int i = 0; i < KeyWordInspect.Length; i++)
            {
                varKeyWordInspect += KeyWordInspect[i];
                Console.Clear();
                Console.WriteLine(IntroRules);
                Console.WriteLine(varKeyWordInspect);
                Thread.Sleep(50);
            }

            string KeyWordSearch = "Search";
            var varKeyWordSearch = "";
            for (int i = 0; i < KeyWordSearch.Length; i++)
            {
                varKeyWordSearch += KeyWordSearch[i];
                Console.Clear();
                Console.WriteLine(IntroRules);
                Console.WriteLine(varKeyWordInspect);
                Console.WriteLine(varKeyWordSearch);
                Thread.Sleep(50);
            }

            string KeyWordUse = "Use";
            var varKeyWordUse = "";
            for (int i = 0; i < KeyWordUse.Length; i++)
            {
                varKeyWordUse += KeyWordUse[i];
                Console.Clear();
                Console.WriteLine(IntroRules);
                Console.WriteLine(varKeyWordInspect);
                Console.WriteLine(varKeyWordSearch);
                Console.WriteLine(varKeyWordUse);
                Thread.Sleep(50);
            }

            string KeyWordBack = "Use";
            var varKeyWordBack = "";
            for (int i = 0; i < KeyWordBack.Length; i++)
            {
                varKeyWordBack += KeyWordBack[i];
                Console.Clear();
                Console.WriteLine(IntroRules);
                Console.WriteLine(varKeyWordInspect);
                Console.WriteLine(varKeyWordSearch);
                Console.WriteLine(varKeyWordUse);
                Console.WriteLine(varKeyWordBack);
                Thread.Sleep(50);
            }
        }
    }
}
