using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.1
            Console.WriteLine("(2.1)");
            Console.WriteLine("Как вас зовут?");
            string s2_1 =  Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {s2_1}");

            Console.WriteLine();

            //2.2
            Console.WriteLine("(2.2)");
            Console.WriteLine("Введите два целых числа:");
            int a2_2 = Convert.ToInt32(Console.ReadLine());
            int b2_2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(a2_2 / b2_2);
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Делить на ноль нельзя!");
            }

            Console.WriteLine();
         
            //DZ_2.1
            
            Console.WriteLine("(DZ_2.1)");
            char s_DZ_2_1 = Convert.ToChar(Console.ReadLine());
            if (s_DZ_2_1 == 'z' || s_DZ_2_1 == 'Z')
            {
                Console.WriteLine("К сожалению, не существует буквы, следующей за буквой z");
            }
            else
            {
                int n_DZ_2_1 = s_DZ_2_1;
                n_DZ_2_1++;
                s_DZ_2_1 = (char)n_DZ_2_1;
                Console.WriteLine(s_DZ_2_1);
            }

            Console.WriteLine();

            //DZ_2.2
            
            Console.WriteLine("(DZ_2.2)");
            Console.WriteLine("Введите коэффициенты квадратного уравнения");
            Console.Write("a=");
            double a_DZ_2_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b_DZ_2_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c=");
            double c_DZ_2_2 = Convert.ToDouble(Console.ReadLine());
            double D_DZ_2_2 = b_DZ_2_2 * b_DZ_2_2 - 4 * a_DZ_2_2 * c_DZ_2_2;
            if (D_DZ_2_2 < 0)
            {
                Console.WriteLine("У данного уравнения не существует действительных решений");
            }
            if (D_DZ_2_2 == 0)
            {
                Console.WriteLine($"x = {-b_DZ_2_2 / (2 * a_DZ_2_2)}");
            }
            if (D_DZ_2_2 > 0)
            {
                Console.WriteLine($"x1 = {(-b_DZ_2_2 + Math.Sqrt(D_DZ_2_2)) / (2 * a_DZ_2_2)}");
                Console.WriteLine($"x2 = {(-b_DZ_2_2 - Math.Sqrt(D_DZ_2_2)) / (2 * a_DZ_2_2)}");
            }

        }
    }
}
