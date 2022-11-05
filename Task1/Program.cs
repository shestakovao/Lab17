using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccounts<int> bankAccounts1 = new BankAccounts<int>();
            bankAccounts1.Input();
            Console.WriteLine(bankAccounts1.GetInfo());

            BankAccounts<string> bankAccounts2 = new BankAccounts<string>();
            bankAccounts2.Input();
            Console.WriteLine(bankAccounts2.GetInfo());

            Console.ReadKey();
        }
    }
}
