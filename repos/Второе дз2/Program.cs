using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
namespace Zadachi
{
    internal class Program
    {
        public static bool Allcontains(string s, string patterns)
        {
            //Функция проверяет строку s на условие, состоит ли она только из символов, которые есть в строке patterns
            bool flag = true;
            for (int i = 0;i < s.Length; i++)
            {
                flag = flag && patterns.Contains(s[i]);
            }
            return flag;
        }
        /* ASCII code for letters
            Russian
            а - 1072
            я - 1103
            А - 1040
            Я - 1071
            English
            a - 97
            z - 122
            A - 65
            Z - 90
         */
        public static string SwapLetters(string s)
        {
            //Заменяет строчные буквы в строке s на заглавные, а заглавные на строчные, затем возвращает новую строку a
            string a = "";
            for (int i = 0; i < s.Length; i++) 
            {
                int ascii_code = (int)s[i];
                if ((ascii_code > 1071 && ascii_code < 1104) || (ascii_code > 96 && ascii_code < 123))
                {
                    ascii_code -= 32;
                    a += (char)ascii_code;
                    continue;
                }
                if ((ascii_code > 1039 && ascii_code < 1072) || (ascii_code > 64 && ascii_code < 91))
                {
                    ascii_code += 32;
                    a += (char)ascii_code;
                    continue;
                }
                else
                {
                    a += (char)ascii_code;
                }
            }

            return a;
        }
        
        public static int NumOfStrs(string s,string a)
        {
            //Функция принимает на вход две строки (s и a) и возвращает количество подстрок a в строке s
            int count = 0;
            int i = 0;
            int temp_i = 0;
            while (i < s.Length)
            {
                try
                {
                    while ((temp_i + i < s.Length) && (temp_i < a.Length) && (a[temp_i] == s[i + temp_i]))
                    {
                        temp_i++;
                    }
                }
                catch (Exception) { }
                if (temp_i == a.Length)
                {
                    count++;
                }
                temp_i = 0;
                i++;
            }
            return count;
        }
        public struct Drink()
        {
            public string name;
            public int alcoPercentage;

        }

        public struct Student()
        {
            public string secondName;
            public string firstName;
            public int id;
            public string birthday;
            public char alcoCateg;
            public Drink specificDrink;
            public double drinkVolume;//объём в литрах
            public double alcoVolume;//объём алкоголя в литрах


        }
        static void Main(string[] args)
        {/*
            //1
            Console.WriteLine("№1");
            Console.WriteLine($"Тип данных        Максимальное значение          Минимальное значение");
            Console.WriteLine($"char(ASCII сode)  {(int)char.MaxValue}                          {(int)char.MinValue}");
            Console.WriteLine($"char              {char.MaxValue}                          {char.MinValue}");
            Console.WriteLine($"byte              {byte.MaxValue}                            {byte.MinValue}");
            Console.WriteLine($"sbyte             {sbyte.MaxValue}                            {sbyte.MinValue}");
            Console.WriteLine($"short             {short.MaxValue}                          {short.MinValue}");
            Console.WriteLine($"ushort            {ushort.MaxValue}                          {ushort.MinValue}");
            Console.WriteLine($"int               {int.MaxValue}                     {int.MinValue}");
            Console.WriteLine($"uint              {uint.MaxValue}                     {uint.MinValue}");
            Console.WriteLine($"long              {long.MaxValue}            {long.MinValue}");
            Console.WriteLine($"float             {float.MaxValue}                  {float.MinValue}");
            Console.WriteLine($"double            {double.MaxValue}        {double.MinValue}");
            Console.WriteLine($"decimal           {decimal.MaxValue}  {decimal.MinValue}");
            Console.WriteLine();
            //2
            Console.WriteLine("№2");
            string letters = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNMйцукенгшщзхъфывапролджэячсмитьбюёЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЯЧСМИТЬБЮЁ";
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            while(!Allcontains(name, letters) || name == "")
            {
                Console.WriteLine("Некорректный ввод, введите заново");
                name = Console.ReadLine();

            }
            Console.WriteLine("Введите ваш город");
            string city = Console.ReadLine();
            while (!Allcontains(city, letters) || city == "")
            {
                Console.WriteLine("Некорректный ввод, введите заново");
                city = Console.ReadLine();
            }
            Console.WriteLine("Введите ваш возраст");
            */
            bool flag = true;
            /*
            int age = 0; 
                while (flag)
            {
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age > 135)
                    {
                        Console.WriteLine("Очень смешно, а теперь введите свой настоящий возраст :)");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод, введите заново");
                    continue;
                }
                flag = false;
            }
            Console.WriteLine("Придумайте PIN-код (он должен состоять из 4-8 цифр)");
            flag = true;
            string pin_code = "";
            while (flag)
            {
                try
                {
                    pin_code = Console.ReadLine();
                    int check_type = Convert.ToInt32(pin_code);

                    if (pin_code.Length < 4 || pin_code.Length > 8)
                    {
                        Console.WriteLine("Пин код должен состоять из 4-8 символов!");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Пин код может состоять только из цифр, попробуйте ещё раз");
                    continue;
                }
                flag = false;
            }
            Console.WriteLine();
            Console.WriteLine($"Ваше имя:{name}");
            Console.WriteLine($"Ваш город:{city}");
            Console.WriteLine($"Ваш возраст:{age}");
            Console.WriteLine($"Ваш PIN-код:{pin_code}");
            
            Console.WriteLine();

            //3
            Console.WriteLine("№3");
            Console.WriteLine("Введите любую строку");
            string stroka = Console.ReadLine();
            Console.WriteLine("Вот ваша строка, но регистры поменялись");
            Console.WriteLine(SwapLetters(stroka));
            
            Console.WriteLine();
            //4
            Console.WriteLine("№4");
            Console.WriteLine("Введите строку a");
            string strochka = Console.ReadLine();
            Console.WriteLine("Введите строку b");
            string podstrochka = Console.ReadLine();
            Console.WriteLine("Количество подстрок b в строке a");
            Console.WriteLine(NumOfStrs(strochka, podstrochka));
            
            Console.WriteLine();
            */
            //5
            Console.WriteLine("№5");
            Console.WriteLine("Введите обычную цену для вина");
            flag = true;
            float normPrice = 0;
            float salePrice = 0;
            float holidayPrice = 0;
            while (flag)
            {
                try
                {
                   normPrice = Convert.ToSingle(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод, введите вещественное число в десятичной системе счисления");
                    continue;
                }
                flag = false;
            }
            flag = true;
            Console.WriteLine("Введите размер скидки (в %)");
            while (flag)
            {
                try
                {
                    salePrice = Convert.ToSingle(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод, введите вещественное число в десятичной системе счисления");
                    continue;
                }
                flag = false;
            }

            Console.WriteLine("Введите цену на отпуск");
            flag = true;
            while (flag)
            {
                try
                {
                    holidayPrice = Convert.ToSingle(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод, введите вещественное число в десятичной системе счисления");
                    continue;
                }
                flag = false;
            }
            float economiya = normPrice * salePrice / 100;
            int numOfBottles = (int)(holidayPrice / economiya);
            if (numOfBottles * economiya < holidayPrice)
            {
                numOfBottles++;
            }
            Console.WriteLine("Всего бутылок нужно купить для того чтобы выгода покрыла расходы на отпуск:");
            Console.WriteLine(numOfBottles);

            Thread.Sleep(3000);//программа спит три секунды, после чего выдаёт ответ на 6 задачу(это сделано для понятности)

            Console.WriteLine();

            //6
            Console.WriteLine("№6");
            //1 Студент
            Student Ilya = new Student();
            Ilya.secondName = "Лавриненко";
            Ilya.firstName = "Илья";
            Ilya.id = 1;
            Ilya.birthday = "15.07.2006";
            Ilya.alcoCateg = 'a';
            Ilya.specificDrink.name = "Самогон";
            Ilya.specificDrink.alcoPercentage = 42;
            Ilya.drinkVolume = 0.2;
            Ilya.alcoVolume = Ilya.drinkVolume / 100 * Ilya.specificDrink.alcoPercentage;

            //2 Студент
            Student Damir = new Student();
            Damir.secondName = "Рахмедов";
            Damir.firstName = "Дамир";
            Damir.id = 2;
            Damir.birthday = "15.07.2006";
            Damir.alcoCateg = 'b';
            Damir.specificDrink.name = "Лимонно-имбирная водка";
            Damir.specificDrink.alcoPercentage = 40;
            Damir.drinkVolume = 0.1;
            Damir.alcoVolume = Damir.drinkVolume / 100 * Damir.specificDrink.alcoPercentage;
            
            //3 Студент
            Student Marat = new Student();
            Marat.secondName = "Гиндуллин";
            Marat.firstName = "Марат";
            Marat.id = 3;
            Marat.birthday = "18.04.2006";
            Marat.alcoCateg = 'd';
            Marat.specificDrink.name = "Вода";
            Marat.specificDrink.alcoPercentage = 0;
            Marat.drinkVolume = 0.5;
            Marat.alcoVolume = Marat.drinkVolume / 100 * Marat.specificDrink.alcoPercentage;
            
            //4 Студент
            Student Vitaliy = new Student();
            Vitaliy.secondName = "Аббасов";
            Vitaliy.firstName = "Виталий";
            Vitaliy.id = 4;
            Vitaliy.birthday = "01.06.2006";
            Vitaliy.alcoCateg = 'b';
            Vitaliy.specificDrink.name = "Егермейстер";
            Vitaliy.specificDrink.alcoPercentage = 40;
            Vitaliy.drinkVolume = 0.05;
            Vitaliy.alcoVolume = Vitaliy.drinkVolume / 100 * Vitaliy.specificDrink.alcoPercentage;
            
            //5 Студент
            Student Artem = new Student();
            Artem.secondName = "Савенко";
            Artem.firstName = "Артём";
            Artem.id = 5;
            Artem.birthday = "15.03.2006";
            Artem.alcoCateg = 'b';
            Artem.specificDrink.name = "Егермейстер";
            Artem.specificDrink.alcoPercentage = 40;
            Artem.drinkVolume = 0.15;
            Artem.alcoVolume = Artem.drinkVolume / 100 * Artem.specificDrink.alcoPercentage;
            
            //Все студенты
            double allVolume = Ilya.drinkVolume + Damir.drinkVolume + Marat.drinkVolume + Vitaliy.drinkVolume + Artem.drinkVolume;
            double allAlcoVolume = Ilya.alcoVolume + Damir.alcoVolume + Marat.alcoVolume + Vitaliy.alcoVolume + Artem.alcoVolume;
            Console.WriteLine("Имя     Фамилия      % от всего выпитого спирта       % от всего выпитого     Название напитка");
            Console.WriteLine();
            Console.WriteLine($"{Ilya.firstName}    {Ilya.secondName}   {Ilya.alcoVolume/ allAlcoVolume * 100}                 {Ilya.drinkVolume / allVolume * 100}                      {Ilya.specificDrink.name}");
            Console.WriteLine($"{Damir.firstName}   {Damir.secondName}     {Damir.alcoVolume / allAlcoVolume * 100}               {Damir.drinkVolume / allVolume * 100}                      {Damir.specificDrink.name}");
            Console.WriteLine($"{Marat.firstName}   {Marat.secondName}    {Marat.alcoVolume / allAlcoVolume * 100}                                {Marat.drinkVolume / allVolume * 100}                      {Marat.specificDrink.name}");
            Console.WriteLine($"{Vitaliy.firstName} {Vitaliy.secondName}      {Vitaliy.alcoVolume / allAlcoVolume * 100}                {Vitaliy.drinkVolume / allVolume * 100}                       {Vitaliy.specificDrink.name}");
            Console.WriteLine($"{Artem.firstName}   {Artem.secondName}      {Artem.alcoVolume / allAlcoVolume * 100}               {Artem.drinkVolume / allVolume * 100}                      {Artem.specificDrink.name}");
            Console.WriteLine();
            Console.WriteLine($"Всего выпито:{allVolume} литров");
            Console.WriteLine($"Всего спирта выпито:{allAlcoVolume} литров");

        }
    }
}
