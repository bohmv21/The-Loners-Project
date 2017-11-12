using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Collections;
using System.Media;
using System.Runtime.InteropServices;

namespace Escape_room
{
    class Program
    {
        public static SortedList<string, bool> ListInventory = new SortedList<string, bool>();
        public static int SafeUnlocked = 0;

        static void Main(string[] args)
        {
            ListInventory.Add("note ", false);
            ListInventory.Add("old key ", true);
            ListInventory.Add("golden key ", false);
            ListInventory.Add("rusty key ", true);
            ListInventory.Add("id ", false);
            ListInventory.Add("flashlight ", false);
            ListInventory.Add("your moms toy ", false);
            ListInventory.Add("dairy ", false);
            Console.SetWindowSize(150, 40);
            //intro2();
            //huis();
            //Intro();
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

                    case "inspect cabinet":
                        closetOpen();
                        Mainswitch2();
                        break;

                    case "back":
                        Kamer1();
                        break;

                    case "help":
                        help();
                        Kamer1();
                        break;

                    case "use note":
                        if (ListInventory["note "])
                        {
                            note();
                        }
                        break;
                    case "use id":
                        if (ListInventory["id "])
                        {
                           id();
                        }
                        break;
                    case "enter door":
                        Kamer2Switch();
                        break;

                    default:
                        Console.WriteLine("Please enter help to look at functions");
                        break;

                }
            } while (x == 1);
        }

        static void Mainswitch2()
        {
            int x = 1;

            do
            {
                string Line = Convert.ToString(Console.ReadLine());
                switch (Line.ToLower())
                {
                    case "search pillow":   
                        note();
                        foreach (KeyValuePair<string, bool> kvp in ListInventory.ToList())
                        {
                            if (kvp.Key == "note ")
                            {
                                ListInventory[kvp.Key] = true;
                            }
                        }
                        break;
                    case "search cabinet":
                        OldKey();
                        foreach (KeyValuePair<string, bool> kvp in ListInventory.ToList())
                        {
                            if (kvp.Key == "old key ")
                            {
                                ListInventory[kvp.Key] = true;
                            }
                        }
                        break;

                    case "back":
                        x = 0;
                        Kamer1();
                        break;

                    case "help":
                        help();
                        Kamer1();
                        break;


                    default:
                        Console.WriteLine("Please enter help to look at functions");
                        break;
                }

            } while (x == 1);
        }

        static void Kamer2Switch()
        {
            if (SafeUnlocked == 1)
            {
                kamer2secretdoor();
            }
            else
            {
                Kamer2();
            }
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

                    case "use note":
                        if (ListInventory["note "])
                        {
                            note();
                        }
                        break;
                    case "use id":
                        if (ListInventory["id "])
                        {
                            id();
                        }
                        break;

                    case "enter right door":
                        if(ListInventory["old key "])
                        {
                            Kamer4Switch();
                        }
                        else { Console.WriteLine("U need an old key to open this door"); }
                        break;
                    case "enter left door":
                        if(ListInventory["rusty key "])
                        {
                            Kamer6Switch();
                        }
                        else { Console.WriteLine("U need a rusty key to open this door"); }
                        break;
                    case "enter hatch":
                        if (SafeUnlocked == 1)
                        {
                            Kamer5Switch();
                        }
                        else
                        {
                            Console.WriteLine("Please enter help to look at functions");
                        }
                        break;

                    case "back":
                        x = 0;
                        Mainswitch();
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
                        id();
                        foreach (KeyValuePair<string, bool> kvp in ListInventory.ToList())
                        {
                            if (kvp.Key == "id ")
                            {
                                ListInventory[kvp.Key] = true;
                            }
                        }
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

                    case "use note":
                        if (ListInventory["note "])
                        {
                            note();
                        }
                        break;
                    case "use id":
                        if (ListInventory["id "])
                        {
                            id();
                        }
                        break;

                    case "back":
                        x = 0;
                        Kamer2Switch();
                        break;
                    case "inspect ghost":

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

        static void Kamer4Switch()
        {
            if(SafeUnlocked == 1)
            {
                kamer4secretdoor();
            }
            else
            {
                Kamer4();
            }
            int x = 1;
            do
            {
                string Line = Convert.ToString(Console.ReadLine());
                switch (Line.ToLower())
                {
                    case "inspect painting":
                        SafeSwitch();
                        break;

                    case "inspect desk":
                        Diary();
                        if (SafeUnlocked == 1)
                        {
                            kamer4secretdoor();
                        }
                        else
                        {
                            Kamer4();
                        }
                        break;

                    case "back":
                        x = 0;
                        Kamer2Switch();
                        break;

                    case "help":
                        help();
                        Kamer4();
                        break;
                    case "use note":
                        if (ListInventory["note "])
                        {
                            note();
                        }
                        break;
                    case "use id":
                        if (ListInventory["id "])
                        {
                            id();
                        }
                        break;
                        
                    case "enter door":
                        if (SafeUnlocked == 1)
                        {
                            Kamer3Switch();
                        } else
                        {
                            Console.WriteLine("Please enter help to look at functions");
                        }
                        break;

                    default:
                        Console.WriteLine("Please enter help to look at functions");
                        break;

                }
            } while (x == 1);
        }

        static void SafeSwitch()
        {
            Safe();
            int x = 1;
            int IDInspect = 0;
            Console.WriteLine("The safe seems to be locked with a 4 digit code");
            do
            {
                Console.Write("Enter 4 Digit code :");
                string Line = Convert.ToString(Console.ReadLine());
                switch(Line.ToLower())
                {
                    // All Inspect cases

                    case "1910":
                        SafeUnlocked = 1;
                        Console.Beep();
                        x = 1;
                        var sound = new System.Media.SoundPlayer();
                        sound.SoundLocation = @"Data/door.wav";
                        sound.PlaySync();
                        Kamer4Switch();
                        break;

                    case "use note":
                        if (ListInventory["note "])
                        {
                            note();
                        }
                        break;
                    case "use id":
                        IDInspect = 1;
                        if (ListInventory["id "])
                        {
                            id();
                        }
                        break; 

                    //Back Case
                    case "back":
                        if (IDInspect == 1)
                        {
                            IDInspect = 0;
                            ChestLock();
                        }
                        else
                        {
                            x = 0;
                            Kamer4Switch();
                        }
                        break;

                    //Help case
                    case "help":
                        help();
                        Safe();
                        break;

                    //Default case
                    default:
                        Console.WriteLine("The code u entered is wrong please try again");
                        break;
                } 
            } while (x == 1);
        }

        static void Kamer5Switch()
        {
            Kamer5lightsoff();
            int x = 1;
            do
            {
                string Line = Convert.ToString(Console.ReadLine());
                switch (Line.ToLower())
                {
                    case "inspect chest":
                        ChestSwitch();
                        break;

                    case "inspect gravestone":
                        gravestone();
                        kamer5Switch2();
                        break;

                        case "back":
                        x = 0;
                        Kamer4Switch();
                        break;

                    case "help":
                        help();
                        Kamer5lightsoff();
                        break;
                    case "use note":
                        if (ListInventory["note "])
                        {
                            note();
                        }
                        break;
                    case "use id":
                        if (ListInventory["id "])
                        {
                            id();
                        }
                        break;
                    case "enter door":
                        break;

                    default:
                        Console.WriteLine("Please enter help to look at functions");
                        break;

                }
            } while (x == 1);
        }

        static void ChestSwitch()
        {
            ChestLock();
            int x = 1;
            int IDInspect = 0;
            Console.WriteLine("The Chest seems to be locked with a 3 digit code");
            do
            {
                Console.Write("Enter 3 Digit code :");
                string Line = Convert.ToString(Console.ReadLine());
                switch (Line.ToLower())
                {
                    // All Inspect cases
                    case "164":
                        foreach (KeyValuePair<string, bool> kvp in ListInventory.ToList())
                        {
                            if (kvp.Key == "rusty key ")
                            {
                                ListInventory[kvp.Key] = true;
                            }
                        }
                        RustyKey();
                        break;
                    case "use note":
                        if (ListInventory["note "])
                        {
                            note();
                        }
                        break;
                    case "use id":
                        IDInspect = 1;
                        if (ListInventory["id "])
                        {
                            id();
                        }
                        break;

                    //Back Case
                    case "back":
                        if (IDInspect == 1)
                        {
                            IDInspect = 0;
                            ChestLock();
                        }
                        else
                        {
                            x = 0;
                            Kamer5Switch();
                        }
                        break;

                    //Help case
                    case "help":
                        help();
                        ChestLock();
                        break;

                    //Default case
                    default:
                        Console.WriteLine("The code u entered is wrong please try again");
                        break;
                }
            } while (x == 1);
        }

        static void kamer5Switch2()
        {
            gravestone();
            int x = 1;
            do
            {
                string Line = Convert.ToString(Console.ReadLine());
                switch (Line.ToLower())
                {
                    
                    case "back":
                        x = 0;
                        Kamer5Switch();
                        break;

                    case "help":
                        help();
                        gravestone();
                        break;
                    case "use note":
                        if (ListInventory["note "])
                        {
                            note();
                        }
                        break;
                    case "use id":
                        if (ListInventory["id "])
                        {
                            id();
                        }
                        break;
                    case "enter door":
                        break;

                    default:
                        Console.WriteLine("Please enter help to look at functions");
                        break;

                }
            } while (x == 1);

        }

        static void Kamer6Switch()
        {
            Kamer6();
            int x = 1;
            do
            {
                string Line = Convert.ToString(Console.ReadLine());
                switch (Line.ToLower())
                {
                    case "back":
                        x = 0;
                        Kamer2Switch();
                        break;

                    case "help":
                        help();
                        Kamer6();
                        break;
                    case "use note":
                        if (ListInventory["note "])
                        {
                            note();
                        }
                        break;
                    case "use id":
                        if (ListInventory["id "])
                        {
                            id();
                        }
                        break;
                    case "enter door":
                        if (ListInventory["golden key "])
                        {
                            Ending();
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("You need a golden key to leave the building.");
                        }
                        break;

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

            string IntroRules = "You wake up in a room in a mansion and you don't remember anything except your name (Elizabeth Albert)." + "\r\n" + "You must escape or else you're going to die." + "\r\n" + 
   "Try to find the story behind this mansion." + "\r\n" + "Good luck!" + "\r\n" + "You will need it.";
            

            for (int i = 0; i < IntroRules.Length; i++)
            {
                Console.Write(IntroRules[i]);
                Thread.Sleep(50);
            }
            Console.ReadLine();


        }

        static void intro2()
        {
            string path = @"Data/";
            string name = "titlescreen.txt";
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
            InventroyUI();
        }

        static void Kamer2()
        {
            string path = @"Data/";
            string name = "Kamer2.txt";
            string room = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(room);
            InventroyUI();

        }

        static void Kamer3()
        {
            string path = @"Data/";
            string name = "Kamer3.txt";
            string room = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(room);
            InventroyUI();
        }

        static void Kamer4()
        {
            string path = @"Data/";
            string name = "kamer4.txt";
            string room = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(room);
            InventroyUI();

        }

        static void kamer2secretdoor()
        {
            string path = @"Data/";
            string name = "kamer2secretroom.txt";
            string zoom = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(zoom);
            InventroyUI();
        }

        static void kamer4secretdoor()
        {
            string path = @"Data/";
            string name = "kamer4secretroom.txt";
            string zoom = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(zoom);
            InventroyUI();
        }

        static void Kamer5lightsoff()
        {
            string path = @"Data/";
            string name = "kamer5lightsoff.txt";
            string room = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(room);
            InventroyUI();

        }

        static void Kamer5lightson()
        {
            string path = @"Data/";
            string name = "kamer5lightson.txt";
            string room = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(room);
            InventroyUI();

        }

        static void Kamer6()
        {
            string path = @"Data/";
            string name = "kamer6.txt";
            string room = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(room);
            InventroyUI();

        }

        static void pillow()
        {
            string path = @"Data/";
            string name = "Pillow.txt";
            string zoom = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(zoom);
        }

        static void Safe()
        {
            string path = @"Data/";
            string name = "safe.txt";
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

        static void Chest()
        {
            string path = @"Data/";
            string name = "safe.txt";
            string zoom = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(zoom);

        }

        static void ChestLock()
        {
            string path = @"Data/";
            string name = "lock.txt";
            string zoom = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(zoom);

        }

        static void OldKey()
        {
            string path = @"Data/";
            string name = "oldkey.txt";
            string zoom = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(zoom);

        }

        static void RustyKey()
        {
            string path = @"Data/";
            string name = "rustykey.txt";
            string zoom = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(zoom);

        }

        static void GoldenKey()
        {
            string path = @"Data/";
            string name = "goldenkey.txt";
            string zoom = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(zoom);

        }

        static void id()
        {
            string path = @"Data/";
            string name = "idandbadge.txt";
            string zoom = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(zoom);
        }

        static void Diary()
        {
            string path = @"Data/";
            string name = "diary.txt";
            string zoom = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(zoom);

            Console.WriteLine("Press 'ENTER' to continue");
            do
            {
            }
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter));
        }

        static void Ending()
        {
            string path = @"Data/";
            string name = "ending.txt";
            string zoom = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(zoom);

            Console.WriteLine("Press 'ENTER' to continue");
            do
            {
            }
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter));
        }

        static void closetOpen()
        {
            string path = @"Data/";
            string name = "closetOpen.txt";
            string zoom = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(zoom);
            var sound = new System.Media.SoundPlayer();
            sound.SoundLocation = @"Data/cabinet.wav";
            sound.PlaySync();
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

            string KeyWordHelp = "To get items you first need to inspect them and then search them." + "\r\n";
            for (int i = 0; i < KeyWordHelp.Length; i++)
            {
                Console.Write(KeyWordHelp[i]);
                Thread.Sleep(50);
            }
            Console.ReadLine();
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

        static void gravestone()
        {
            string path = @"Data/";
            string name = "gravestone.txt";
            string zoom = File.ReadAllText(path + name);
            Console.Clear();
            Console.Write(zoom);
        }

        static void InventroyUI()
        {
            string cunt = "";
            foreach (KeyValuePair<string, bool> kvp in ListInventory)
            {
                if (kvp.Value)
                {
                    cunt = cunt + kvp.Key;
                }
            }

            var CursorPos = Console.CursorTop;
            Console.SetCursorPosition(0, CursorPos);
            Console.Write("│                                                                                                    |\n");
            Console.Write("│ Inventory:                                                                                         │\n");
            Console.Write("│                                                                                                    │\n");
            Console.Write("│                                                                                                    │\n");
            Console.Write("│____________________________________________________________________________________________________|\n");

            Console.SetCursorPosition(2, CursorPos + 2);
            Console.Write(cunt);
            Console.SetCursorPosition(0, CursorPos + 5);
            
        }
    }
}
