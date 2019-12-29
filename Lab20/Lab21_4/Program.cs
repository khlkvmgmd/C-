using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text, vowels = "АаУуОоЫыИиЭэЯяЮюЕеЁё";
            Console.Write("Введите строку: ");
            text = Console.ReadLine();
            int count = 0;
            foreach (char symbol in text)
            {
                if (vowels.Contains(symbol.ToString()))
                {
                    count++;
                }
            }
            Console.WriteLine("Количество гласных в этой строке равно: {0}", count);
        }
    }
}
