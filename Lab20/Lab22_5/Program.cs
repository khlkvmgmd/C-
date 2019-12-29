using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab22_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя файла: ");
            string file = Console.ReadLine();
            int x = 0, k = 0;
            if (File.Exists(file))
            {
                int count = File.ReadAllLines(file).Length;
                string[] s = new string[count];
                s = File.ReadAllLines(file);
                for (int i = 0; i < count; i++)
                {
                    for (int j = 0; j < s[i].Length; j++)
                    {
                        if (s[i][j] == ' ')
                        {
                            x++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (x == 5)
                    {
                        k++;
                    }
                    x = 0;
                }
            }
            Console.WriteLine("Количество обзацев: " + k);
        }
    }
}
