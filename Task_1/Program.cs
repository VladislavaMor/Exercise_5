using System;
using static System.Console;

namespace Exercise_5
{
    class Program
    {
        static string[] SplitText(string text)
        {
            char[] chars = text.ToCharArray();
            int count = 0;
            /// Подсчет количества пробелов в тексте
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    count++;
                }
            }

            string[] str = new string[count + 1];
            int indexStart = 0;
            int t = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    str[t++] = text.Substring(indexStart, i- indexStart);
                    indexStart = ++i;                   
                }
                else if (i == text.Length-1) str[t] = text.Substring(indexStart);
            }

            //string[] str = text.Split(' ');  
            return str;
        }

        static void GetSplitText(string[] str)
        {
            WriteLine("Слова в предложении после разделения: ");
            foreach (string e in str)
                {
                    WriteLine(e);
                }
        }
        static void Main(string[] args)
        
        {
            WriteLine("Введите предложение: ");
            string proposal = ReadLine();
            string[] newText = SplitText(proposal);
            GetSplitText(newText);


        }
    }








}
