using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string data = Console.ReadLine();
            string newWord = string.Empty;
            string[] words = data.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder resultBuilder = new StringBuilder();
            foreach (string word in words)
            {
                newWord = word.Replace(word[0], '.');
                resultBuilder.AppendFormat("{0} ", newWord);
            }
            string result = resultBuilder.ToString();
            Console.WriteLine("Результат: {0}", result);
        }
    }
}
