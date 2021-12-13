using System;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<int> acc = new Account<int>();
            Account<double> acc2 = new Account<double>();
            Account<decimal> acc3 = new Account<decimal>();
            acc.SetValues(12345, "FullName", 123);
            acc2.SetValues(123.23, "FullName2", 1000);
            acc3.SetValues((decimal)123.2344444, "FullName2", 1000);
            Console.WriteLine($"ФИО: {acc.GetName()}");
            Console.WriteLine($"Номер аккаунта: {acc.GetNumber()}");
            Console.WriteLine($"Баланс: {acc.GetBalance()}");
            Console.WriteLine();
            Console.WriteLine($"ФИО: {acc2.GetName()}");
            Console.WriteLine($"Номер аккаунта: {acc2.GetNumber()}");
            Console.WriteLine($"Баланс: {acc2.GetBalance()}");
            Console.WriteLine();
            Console.WriteLine($"ФИО: {acc3.GetName()}");
            Console.WriteLine($"Номер аккаунта: {acc3.GetNumber()}");
            Console.WriteLine($"Баланс: {acc3.GetBalance()}");
        }
    }
    class Account<T>
    {
        private T Number { get; set; }
        private string FullName { get; set; }
        private double Balance { get; set; }
        public void SetValues(T number, string name, double balance)
        {
            Number = number;
            FullName = name;
            Balance = balance;
        }
        public T GetNumber()
        {
            return Number;
        }
        public string GetName()
        {
            return FullName;
        }
        public double GetBalance()
        {
            return Balance;
        }
        
    }
   
}
