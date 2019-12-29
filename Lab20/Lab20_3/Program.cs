using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] > 'A' || s[i] == 'A') && (s[i] < 'Z' || s[i] == 'Z'))
                {
                    k++;
                }
            }
            Console.WriteLine("Количество прописных букв: " + k);
        }
    }
}
