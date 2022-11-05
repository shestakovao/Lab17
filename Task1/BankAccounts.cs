using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class BankAccounts<T>
    {
        private T AccountNumber { set; get; }
        private double Balance { set; get; }
        private string FullName { set; get; }

        public void Input() 
        {
            Console.WriteLine("Введите номер счёта");
            AccountNumber = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            Console.WriteLine("Введите ФИО владельца");
            FullName = Console.ReadLine();

            Console.WriteLine("Введите баланс счёта");
            Balance = Convert.ToDouble(Console.ReadLine()); 
        }

        public string GetInfo()
        {
            return $"{AccountNumber} {FullName} {Balance}";        
        }



    }
}
