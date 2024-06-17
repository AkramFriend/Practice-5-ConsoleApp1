using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Practice_5._1_ConsoleApp1
{
    internal class Program
    {
        
        static string SplitText(string text)
        {
            string[] word = text.Split(' ');
            string resultText = ReverseWord(word);
            return resultText;
        }
        static string ReverseWord(string[] text)
        {
            Array.Reverse(text);
            string reverseText = string.Join(" ", text);
            return reverseText;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Напиши ряд слов");
            string mytext = Console.ReadLine();
            mytext = SplitText(mytext);
            Console.WriteLine(mytext);
            Console.ReadLine(); 
        }
    }

}
   
