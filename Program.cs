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
            {                
                BankAccaunt<int> acc1 = new BankAccaunt<int>();
                acc1.SetInfo(12, 50000, "Романов Олег Игоревич");
                acc1.GetInfo();

                BankAccaunt<string> acc2 = new BankAccaunt<string>();
                acc2.SetInfo("13", 750000, "Костин Василий Иванович");
                acc2.GetInfo();

                BankAccaunt<string> acc3 = new BankAccaunt<string>();
                acc2.SetInfo("14", 500000, "Петров Фндрей Викторович");
                acc2.GetInfo();

                Console.ReadKey();
            }
        }

        class BankAccaunt<T>
        {
            private T AccountТumber;
            private double AccountBalance;
            private string FCs;

            public T AccNumber
            {
                set
                {
                    AccountТumber = value;
                }
                get
                {
                    return AccountТumber;
                }
            }

            public double Balance
            {
                set
                {
                    AccountBalance = value;
                }
                get
                {
                    return AccountBalance;
                }
            }

            public string FIO
            {
                set
                {
                    FCs = value;
                }
                get
                {
                    return FCs;
                }
            }

            public void SetInfo(T value, double balance, string fio)
            {
                AccountТumber = value;
                AccountBalance = balance;
                FCs = fio;
            }
            public void GetInfo()
            {
                Console.WriteLine("Счет № {0}: ", AccNumber);
                Console.WriteLine("Владелец : {0}", FIO);
                Console.WriteLine("Доступные средства: {0} руб.", Balance);
                Console.WriteLine("(-_-)(o_o)(O_o)(O_O)");
            }
        }
    }
}
