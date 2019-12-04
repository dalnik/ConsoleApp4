using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Деление двух чисел");

            Console.Write("Введите первое число. M-> ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число. N-> ");
            int N = Convert.ToInt32(Console.ReadLine());

            
            

           

            if (M % N == 0) Console.WriteLine(M / N);
            else Console.WriteLine("Не делиться нацело");
            Console.ReadLine();
        }
    }
}
