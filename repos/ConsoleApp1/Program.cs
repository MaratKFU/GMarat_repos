using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, World!");
            //1
            Console.WriteLine("(1)");
            Console.WriteLine(2.7);

            Console.WriteLine();

            //2
            Console.WriteLine("(2)");
            Console.WriteLine(50);
            Console.WriteLine(10);

            Console.WriteLine();

            //3
            Console.WriteLine("(3)");
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);

            Console.WriteLine();

            //4
            Console.WriteLine("(4)");
            Console.WriteLine("Введите целое число");

            int a4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваше число + 10: {a4 + 10}");

            Console.WriteLine();

            //5
            Console.WriteLine("(5)");
            Console.WriteLine("Введите сторону квадрата:");

            double a5 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Площадь квадрата равна: {a5 * 4}");

            Console.WriteLine();

            //6
            Console.WriteLine("(6)");
            Console.WriteLine("Введите радиус окружности:");

            int a6 = Convert.ToInt32(Console.ReadLine());
            double pi = 3.1415;
            Console.WriteLine($"Длина окружности: {2 * a6 * pi}");
            Console.WriteLine($"Площадь круга: {a6 * pi * pi}");

            Console.WriteLine();
            
            //7
            Console.WriteLine("(7)");
            Console.WriteLine("Введите значение угла в градусах");

            double a7 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"Значение косинуса для вашего угла равно: {Math.Cos(a7 * Math.PI / 180)}");

            Console.WriteLine();

            //8
            Console.WriteLine("(8)");
            double a8 = Convert.ToDouble(Console.ReadLine());
            double b8 = Convert.ToDouble(Console.ReadLine());
            double h8 = Convert.ToDouble(Console.ReadLine());
            double c8 = Math.Abs(a8 - b8) / 2;

            Console.WriteLine(a8 + b8 + 2 * Math.Sqrt((c8 * c8 + h8 * h8)));

            Console.WriteLine();

            //9
            Console.WriteLine("(9)");
            Console.WriteLine("Введите стоимость 1 кг конфет:");
            double a9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость 1 кг печенья:");
            double b9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость 1 кг яблок:");
            double c9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сколько кг конфет купили:");
            double x9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сколько кг печенья купили:");
            double y9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сколько кг яблок купили:");
            double z9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a9 * x9 + b9 * y9 + c9 * z9);

            Console.WriteLine();

            //10
            Console.WriteLine("(10)");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("    Труд");
            Console.WriteLine("         Май");

            Console.WriteLine();

            //11
            Console.WriteLine("(11)");
            try
            {
                string x11 = Console.ReadLine().Replace('.', ',');
                string y11 = Console.ReadLine().Replace('.', ',');
                double a11 = Convert.ToDouble(x11);
                double b11 = Convert.ToDouble(y11);
                (a11, b11) = (b11, a11);
                Console.WriteLine($"{a11}, {b11}");
            }
            catch (Exception)
            {
                Console.WriteLine("Некорректный ввод!");
            }

            Console.WriteLine();

            //12
            Console.WriteLine("(12)");
            Console.WriteLine("Выберите фигуру:");
            Console.WriteLine("1 - Треугольник");
            Console.WriteLine("2 - Четырёхугольник");
            Console.WriteLine("3 - Круг");
            int a12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Что будем считать?:");
            Console.WriteLine("1 - Площадь");
            Console.WriteLine("2 - Периметр");
            int b12 = Convert.ToInt32(Console.ReadLine());
            if (a12 == 1)
            {
                Console.WriteLine("Введите стороны треугольника:");
                double x12 = Convert.ToDouble(Console.ReadLine());
                double y12 = Convert.ToDouble(Console.ReadLine());
                double z12 = Convert.ToDouble(Console.ReadLine());
                if (b12 == 1) {
                    double p12 = (x12 + y12 + z12) / 2;
                    Console.WriteLine(Math.Sqrt(p12 * (p12 - x12) * (p12 - y12) * (p12 - z12)));
                }
                if (b12 == 2) {
                    Console.WriteLine(x12 + y12 + z12);
                }

            }
            if (a12 == 2)
            {
                if (b12 == 1) {
                    Console.WriteLine("Введите диагонали четырёхугольника и угол между ними:");
                    double n12 = Convert.ToDouble(Console.ReadLine());
                    double m12 = Convert.ToDouble(Console.ReadLine());
                    double angle12 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(n12 * m12 * Math.Sin(angle12) / 2);
                }
                if (b12 == 2) {
                    Console.WriteLine("Введите стороны четырёхугольника:");
                    double x12 = Convert.ToDouble(Console.ReadLine());
                    double y12 = Convert.ToDouble(Console.ReadLine());
                    double z12 = Convert.ToDouble(Console.ReadLine());
                    double w12 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(x12 + y12 + z12 + w12);
                }
            }
            if (a12 == 3)
            {
                Console.WriteLine("Введите радиус окружности:");
                double r12 = Convert.ToDouble(Console.ReadLine());
                if (b12 == 1) {
                    Console.WriteLine(r12 * r12 * 3.1415);
                }
                if (b12 == 2) {
                    Console.WriteLine(2 * r12 * 3.1415);
                }
            }
            
            Console.WriteLine();

            //13
            Console.WriteLine("(13)");
            double a13 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {a13}");

            Console.WriteLine();

            //14
            Console.WriteLine("(14)");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");

            Console.WriteLine();

            //15
            Console.WriteLine("(15)");
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(-1000, 1000));
            Console.WriteLine(rnd.Next(-1000, 1000));
            Console.WriteLine(rnd.Next(-1000, 1000));
            Console.WriteLine(rnd.Next(-1000, 1000));
            
            Console.WriteLine();

            //16
            Console.WriteLine("(16)");
            Console.WriteLine("Введите коэффициенты квадратного уравнения:");
            double a16 = Convert.ToDouble(Console.ReadLine());
            double b16 = Convert.ToDouble(Console.ReadLine());
            double c16 = Convert.ToDouble(Console.ReadLine());
            double D16 = b16 * b16 - 4 * a16 * c16;
            if (D16 < 0) {
                Console.WriteLine("Уравнение не имеет действительных корней");
            }
            if (D16 == 0) {
                Console.WriteLine($"x={-b16 / (2 * a16)}");
            }
            if (D16 > 0){
                Console.WriteLine($"x1={(-b16 + Math.Sqrt(D16)) / (2 * a16)},x2={(-b16 - Math.Sqrt(D16)) / (2 * a16)}");
            }
            
            Console.WriteLine();

            //17
            Console.WriteLine("(17)");
            int a17 = Convert.ToInt32(Console.ReadLine());
            int b17 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((a17 + b17) / 2);
            Console.WriteLine(Math.Sqrt(a17 * b17));

            Console.WriteLine();

            //18
            Console.WriteLine("(18)");
            Console.WriteLine("Введите координаты первой точки");
            double x1_18 = Convert.ToDouble(Console.ReadLine());
            double y1_18 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки");
            double x2_18 = Convert.ToDouble(Console.ReadLine());
            double y2_18 = Convert.ToDouble(Console.ReadLine());
            double a18 = Math.Abs(x1_18 - x2_18);
            double b18 = Math.Abs(y1_18 - y2_18);
            Console.WriteLine(Math.Sqrt(a18 * a18 + b18 * b18));

            Console.WriteLine();

            //19
            Console.WriteLine("(19)");
            double a19 = Convert.ToDouble(Console.ReadLine());
            double b19 = Convert.ToDouble(Console.ReadLine());
            double c19 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите тип(1 или 2):");
            int n19 = Convert.ToInt32(Console.ReadLine());
            if (n19 == 1)
            {
                double d19 = b19;
                b19 = c19;
                c19 = a19;
                a19 = d19;
            }
            if (n19 == 2)
            {
                double d19 = b19;
                b19 = a19;
                a19 = c19;
                c19 = d19;
            }

            Console.WriteLine();
            
            //20
            Console.WriteLine("(20)");
            int t20 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Floor(Convert.ToDecimal(t20 / 3600)));
            Console.WriteLine(Math.Floor(Convert.ToDecimal((t20 % 3600) / 60)));
            Console.WriteLine(t20 % 60);

            Console.WriteLine();
            
            //21
            Console.WriteLine("(21)");
            Console.WriteLine(4);

            Console.WriteLine();

            //22
            Console.WriteLine("(22)");
            int a22 = Convert.ToInt32(Console.ReadLine());
            int b22 = a22 % 10;
            a22 = a22 / 10 + b22 * 100;
            Console.WriteLine(a22);

            Console.WriteLine();
            
            //23
            Console.WriteLine("(23)");
            int a23 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((a23 % 1000)/100);
            Console.WriteLine((a23 % 10000)/1000);

            Console.WriteLine();
            
            //24
            Console.WriteLine("(24)");
            int n24 = Convert.ToInt32(Console.ReadLine());
            int a24 = n24 / 1000;
            int b24 = (n24 / 100) % 10;
            int c24 = (n24 / 10) % 10;
            int d24 = n24 % 10;
            n24 = d24 * 1000 + c24 * 100 + b24 * 10 + a24;
            Console.WriteLine(n24);
            n24 = b24 * 1000 + a24 * 100 + d24 * 10 + c24;
            Console.WriteLine(n24);
            n24 = a24 * 1000 + c24 * 100 + b24 * 10 + d24;
            Console.WriteLine(n24);
            n24 = c24 * 1000 + d24 * 100 + a24 * 10 + b24;
            Console.WriteLine(n24);

            Console.WriteLine();

            //25
            Console.WriteLine("(25)");
            int a25 = Convert.ToInt32(Console.ReadLine());
            int n25 = a25 % 10;
            a25 = a25 / 10 + n25 * 100;
            Console.WriteLine(a25);

            Console.WriteLine();

            //26
            Console.WriteLine("(26)");
            int h26 = Convert.ToInt32(Console.ReadLine());
            int m26 = Convert.ToInt32(Console.ReadLine());
            int s26 = Convert.ToInt32(Console.ReadLine());
            int a26 = (h26 * 3600 + m26 * 60 + s26) % 43200;
            int deg26 = a26 / 120;
            int min26 = (a26 % 120) / 2;
            int sec26 = (a26 % 2) * 30;
            Console.WriteLine($"{deg26}°{min26}'{sec26}\"");
            
            Console.WriteLine();

            //27
            Console.WriteLine("(27)");
            int y27 = Convert.ToInt32(Console.ReadLine());
            int hours27 = y27 / 30;
            int mins27 = (y27 * 2) % 60;
            int deg27 = mins27 * 6;

            Console.WriteLine(deg27);
            Console.WriteLine($"{hours27}:{mins27}");

            Console.WriteLine();

            //28
            Console.WriteLine("(28)");
            double a28 = Convert.ToDouble(Console.ReadLine());
            double b28 = Convert.ToDouble(Console.ReadLine());
            double c28 = Convert.ToDouble(Console.ReadLine());
            if ((Math.Abs(a28) < Math.Abs(b28)) & (Math.Abs(a28) < Math.Abs(c28)))
            {
                Console.WriteLine(a28);
            }
            else
            {
                if ((Math.Abs(b28) < Math.Abs(a28)) & (Math.Abs(b28) < Math.Abs(c28)))
                {
                    Console.WriteLine(b28);
                }
                else
                {
                    Console.WriteLine(c28);
                }
            }
            
            Console.WriteLine();

            //29
            Console.WriteLine("(29)");
            double a29 = Convert.ToDouble(Console.ReadLine());
            double b29 = Convert.ToDouble(Console.ReadLine());
            double c29 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Min(Math.Min(a29, b29), c29) + Math.Max(Math.Max(a29, b29), c29));

            Console.WriteLine();
            
            //30
            Console.WriteLine("(30)");
            int a30 = Convert.ToInt32(Console.ReadLine());
            int count30 = 0;
            if (Convert.ToInt32(Math.Sqrt(a30)) * Convert.ToInt32(Math.Sqrt(a30)) == a30){
                count30++;
            }
            for (int i30 = 1; i30 < Math.Sqrt(a30); i30++)
            {
                if (a30 % i30 == 0)
                {
                    count30 += 2;
                }
            }
            Console.WriteLine(count30);

            Console.WriteLine();
            
            //31
            Console.WriteLine("(31)");
            Console.WriteLine("Укажите коэффициенты кубического уравнения:");
            int a31 = Convert.ToInt32(Console.ReadLine());
            int b31 = Convert.ToInt32(Console.ReadLine());
            int c31 = Convert.ToInt32(Console.ReadLine());
            int d31 = Convert.ToInt32(Console.ReadLine());
            for (int x31 = -100; x31 < 101; x31++)
            {
                if (a31 * x31 * x31 * x31 + b31 * x31 * x31 + c31 * x31 + d31 == 0) {
                    Console.WriteLine(x31);
                }
            }

            Console.WriteLine();

            //32
            Console.WriteLine("(32)");
            Console.WriteLine("Укажите первый и второй элемент прогрессии:");

            int a32 = Convert.ToInt32(Console.ReadLine());
            int b32 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите номер нужного элемента:");
            int n32 = Convert.ToInt32(Console.ReadLine());
            int d32 = b32 - a32;
            Console.WriteLine(a32 + d32 * (n32 - 1));

            Console.WriteLine();
            
            //33
            Console.WriteLine("(33)");
            Console.WriteLine("1 - да, 0 - нет");
            Console.WriteLine("Вы пенсионер?");
            bool a33 = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Вы студент?");
            bool b33 = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Вы трудоустроены?");
            bool c33 = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            if ((a33 || b33) && !(a33 && b33)){
                if (!c33)
                {
                    Console.WriteLine("Кредит одобрен");
                }
                else
                {
                    Console.WriteLine("В выдаче кредита отказано");
                }
            }
            else
            {
                if (a33 && b33)
                {
                    Console.WriteLine("В выдаче кредита отказано");
                }
            }
            //34
            Console.WriteLine("(34)");
            Console.WriteLine("Введите своё имя:");
            string s34 = Console.ReadLine();
            Console.WriteLine(s34);
            Console.WriteLine($"Привет, {s34}");

            Console.WriteLine();
            
            //35
            Console.WriteLine("(35)");
            Console.ReadLine();
            Console.WriteLine("Здравствуйте, как вас зовут?");
            string s35 = Console.ReadLine();
            Console.WriteLine($"привет, {s35}");
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("но могу показать");

            Console.WriteLine();
            
            //36
            Random rnd36 = new Random();
            Console.WriteLine("(36)");
            int[] arr36 = new int[12];
            Console.WriteLine("Выберите тип ввода:");
            Console.WriteLine("1 - рандом");
            Console.WriteLine("2 - вручную");
            string s36 = Console.ReadLine();
            if (s36 == "1") { 
                for (int i = 0; i < arr36.Length; i++)
                {
                    arr36[i] = rnd36.Next(0, 10);
                }
            }
            else
            {
                for (int i = 0; i < arr36.Length; i++)
                {
                    arr36[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int a36 = 0;
            int b36 = 0;
            for (int i = 1; i < arr36.Length; i+=2)
            {
                a36 += arr36[i];
            }
            for (int i = 0; i < arr36.Length; i += 2)
            {
                b36 += arr36[i];
            }
            int c36 = 3 * a36 + b36;
            Console.WriteLine($"Контрольная цифра равна {10 - c36 % 10}");

            Console.WriteLine();

        }
    }
}
