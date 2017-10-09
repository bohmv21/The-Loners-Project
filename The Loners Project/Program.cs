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

            string IntroKeyWords = "Inspect";
            var varIntroKeyWords = "";
            for (int i = 0; i < IntroKeyWords.Length; i++)
            {
                varIntroKeyWords += IntroKeyWords[i];
                Console.Clear();
                Console.WriteLine(IntroRules);
                Console.WriteLine(varIntroKeyWords);
                Thread.Sleep(50);
            }
            Console.ReadLine();
            Console.WriteLine("");
        }
    }
}
