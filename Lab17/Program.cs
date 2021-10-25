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
            Accaunt<int> accaunt1 = new Accaunt<int>(10205, 50000.54, "Володин Алексей Анатольевич");
            Console.WriteLine("Номер счета: {0}. Баланс: {1}. Владелец: {2}", accaunt1.Number, accaunt1.Balance, accaunt1.Owner);
            Accaunt<string> accaunt2 = new Accaunt<string>("F45cc8087", 5.11, "Володин Алексей Анатольевич");
            Console.WriteLine("Номер счета: {0}. Баланс: {1}. Владелец: {2}", accaunt2.Number, accaunt2.Balance, accaunt2.Owner);
            Console.ReadKey();
        }

        class Accaunt<T>
        {
            private T number;
            private double balance;
            private string owner;
            public T Number { get; }
            public double Balance { get; }
            public string Owner { get; }

            public Accaunt(T number, double balance, string owner)
            {
                this.Number = number;
                this.Balance = balance;
                this.Owner = owner;
            }
        }
    }
}
