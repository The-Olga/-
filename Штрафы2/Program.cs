using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Штрафы2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ограничение по скорости: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Скорость машины: ");
            int d = int.Parse(Console.ReadLine());
            if (a <= 50)
            {
                if ((d - 20) <= a)
                {
                    Console.WriteLine("Штрафа не будет");
                }
                else
                {
                    Console.WriteLine("Штраф: 500 рублей ");
                }

            }
            if ((a <= 90) && (a > 50))
            {
                if ((d - 50) <= a)
                {
                    Console.WriteLine("Штрафа не будет");
                }
                else
                {
                    Console.WriteLine("Штраф: 1000 рублей ");
                }
            }
            if ((a <= 140) && (a > 90))
            {
                if ((d - 60) <= a)
                {
                    Console.WriteLine("Штрафа не будет");
                }
                else
                {
                    Console.WriteLine("Штраф: 1000 ");
                }
            }
            if(a>140)
            {
                Console.WriteLine("Вы разбились");
            }
            Console.ReadLine();
        }
    }
}
