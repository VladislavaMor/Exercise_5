using System;
using static System.Console;

namespace Exercise_5
{
    class Program
    {
        static string Reverse(string text)
        {
            string[] splitText = SplitText(text);
            string reversString = string.Empty;
            for (int i = splitText.Length - 1; i >= 0; i--)
            {
                reversString += splitText[i] + ' ';
            }
            GetReverse(reversString);
            return reversString;
        }

        private static void GetReverse(string text)
        {
            WriteLine("Предложение наоборот: ");
            WriteLine(text);
        }

        public static string[] SplitText(string txt)
        {
            string[] str = txt.Split(' ');
            return str;
        }
        static void Main(string[] args)

        {
            WriteLine("Введите предложение: ");
            string proposal = ReadLine();
            Reverse(proposal);


        }
    }








}

