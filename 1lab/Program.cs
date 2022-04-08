using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erofeev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите a: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Введите b: ");
                float b = float.Parse(Console.ReadLine());
                Console.Write("Введите с: ");
                float c = float.Parse(Console.ReadLine());

                Console.WriteLine(new string('-', 40));

                ErofeevLog.I().log($"{a}^2 + {b}x + {c} = 0");
                ErofeevLog.I().log("Корни уравнения: " + string.Join("; ", new Quadratic().solve(a, b, c)));
            }
            catch (ErofeevException ex)
            {
                ErofeevLog.I().log("Ошибка: " + ex);
            }
            catch (Exception ex)
            {
                ErofeevLog.I().log("Ошибка: " + ex.Message);
            }

            ErofeevLog.I().write();

            Console.ReadKey();






        //    try
        //    {
        //        Quadratic quadratic = new Quadratic();
        //        ErofeevLog.I().log("Enter 3 params: a, b, c");
        //        ErofeevLog.I().write().ToString();
        //        float a = Convert.ToSingle(Console.ReadLine());
        //        float b = Convert.ToSingle(Console.ReadLine());
        //        float c = Convert.ToSingle(Console.ReadLine());

        //        ErofeevLog.I().log("Your equation is " + a + "x^2" + b + "x" + c + " = 0");

        //        var i = quadratic.solve(a, b, c);
        //        for (int k = 0; k < i.Count; k++)
        //        {
        //            ErofeevLog.I().log("The root is " + i[k]);
        //        }
        //    }
        //    catch (ErofeevException ex)
        //    {
        //        Console.WriteLine(ex);
        //    }
        //    ErofeevLog.I().write();
        //    Console.ReadLine();
        }
    }
}
