using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

enum BankAccountTypes
{
    Current = 100,
    Savings = 1000
}

public enum VUS
{
    KGU,
    KAI,
    KHTI 
}

public struct Worker()
{
    public string name = "Vasya";
    public VUS university = VUS.KGU;
    public void Output() 
    { 
        Console.WriteLine("Имя: {0}",name);
        Console.WriteLine("Универ: {0}",university);
    }
}

public struct BankAccount
{
    public long number;
    public string type;
    public int balance;
    public void Output()
    {
        Console.WriteLine($"номер: {number}");
        Console.WriteLine($"тип: {type}");
        Console.WriteLine($"баланс: {balance}");
    }

}
namespace ConsoleApp3
{
    internal class Program
    {

        static void Main(string []args)
        {
            //Упражнение 3.1
            Console.WriteLine("(Упражнение 3.1)");
            BankAccountTypes a = BankAccountTypes.Current;
            BankAccountTypes b = BankAccountTypes.Savings;
            Console.WriteLine((int)a);
            Console.WriteLine((int)b);
            
            Console.WriteLine();

            //Упражнение 3.2
            Console.WriteLine("(Упражнение 3.2)");
            BankAccount NewAccount = new BankAccount();
            NewAccount.number = 4019_1023_1223_1292;
            NewAccount.type = "Кредитка";
            NewAccount.balance = 10000;
            NewAccount.Output();

            Console.WriteLine();

            //Домашнее задание 3.1
            Console.WriteLine("(Домашнее задание 3.1)");
            Worker Default = new Worker();
            Default.Output();
            
            Console.WriteLine();

        }
    }
}
