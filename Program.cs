using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_HW_SPM
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i;
            Console.Write("Введите натуральное число не меньше двух: ");
            a = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i * i <= a; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
