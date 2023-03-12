using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Щасливий_квиток_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.Write("\t");
            for (int i = 1; i <= 999999; i++)
            {
                string input = i.ToString("D6");
                int[] mas = new int[6];
                int j = 0;
                foreach (char c in input)
                {
                    mas[j] = c - '0';
                    j++;
                }
                    
                int left = (mas[0] - '0' + mas[1] - '0' + mas[2] - '0');
                int right = (mas[3] - '0' + mas[4] - '0' + mas[5] - '0');
                if (left == right)
                {
                    counter++;
                    Console.Write(i.ToString("D6") + ";\t");
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("\t" + counter + "   Щасливих квиткiв");
            Console.ReadKey();
        }
    }
}
