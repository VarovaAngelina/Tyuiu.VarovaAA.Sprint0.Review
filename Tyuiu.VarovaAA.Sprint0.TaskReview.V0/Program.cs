using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VarovaAA.Sprint0.TaskReview.V0.Lib;
namespace Tyuiu.VarovaAA.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y, z;
            Console.WriteLine(" Введите значение переменной X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Введите значение переменной Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Введите значение переменной Z:");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("  ( x + y + z ) * 5 = " + DataService.Calc(x, y, z));

            Console.ReadLine();
        }
    }
}
