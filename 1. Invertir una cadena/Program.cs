using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static string Inverted(string word)
        {
            int i = word.Length - 1;
            string newWord = "";

            while (i >= 0)
            {
                newWord += word[i];
                i --;
            }
            return newWord;
        }
        static void Main(string[] args)
        {

            //Invertir cadena en c#
            do
            {
                Console.WriteLine("Enter your text or word");
                string word = Console.ReadLine();

                string reversedWord = Inverted(word);
                Console.WriteLine("Reversed Word: " + reversedWord);

                Console.WriteLine("Would you like to enter another word/text? --- yes/no");
                string response = Console.ReadLine().ToLower();
                Console.WriteLine("-----------------------------------------------------");

                if (response != "yes")
                    break;

            }
            while (true);

            Console.ReadKey();
        }
    }
}
