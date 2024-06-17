using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_5_ConsoleApp1
{
    internal class Program
    {
        static string[] SplitText(string text)
        {
            return text.Split(' ');
        }
        static void Print(string[] words)
        {
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите длинное предложение");
            string text = Console.ReadLine();
            string[] words = SplitText(text);
            Print(words);
            Console.ReadKey();
        }
    }
}
