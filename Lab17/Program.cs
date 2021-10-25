using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class Accaunt<T>
        {
            private T number;
            private double balance;
            private string owner;
        }
        static void Input<T>(T number, double balance, string owner)
        {
            Console.WriteLine("Номер счета:");
            number = ;

            Console.WriteLine("Баланс:");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ФИО владельца:");
            owner = Console.ReadLine();

        }
        static void OutPut<T>(T number, double balance, string owner)
        {
            Console.WriteLine("Номер счета {0}", number);
            Console.WriteLine("Баланс {0}", balance);
            Console.WriteLine("Владелец {0}", owner);
        }

    }
}
