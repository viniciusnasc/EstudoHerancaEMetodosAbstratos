using EstudoHeranca.Entities;
using System;
using System.Collections.Generic;

namespace EstudoHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new();

            list.Add(new SavingsAccount(1001, "Alex", 500, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500, 400));
            list.Add(new SavingsAccount(1003, "Bob", 500, 0.01));
            list.Add(new BusinessAccount(1004, "Ana", 500, 500));

            double sum = 0;

            foreach (Account act in list)
            {
                sum += act.Balance;
            }

            foreach (Account act in list)
            {
                act.Withdraw(10);
            }


        }
    }
}
