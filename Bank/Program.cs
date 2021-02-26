using System;
using Bank.Entities;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando, instanciando, objetos
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            // UPCASTING 
            // Conversão de super classe para subclasse
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.00);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING (usado apenas quando for realmente necessário)
            // Conversão de subclasse em super classe
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);

            /*
             * Não mostra erro no IDE, mas da erro na execução
             => BusinessAccount acc5 = (BusinessAccount)acc3;
            */

            // temos que fazer um if para validar a conversão
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

            Console.WriteLine("================================================");
            // Sobreposição, palavras virtual, override e base


            Account acc10 = new Account(1001, "Alex", 500.00);
            Account acc20 = new SavingsAccount(1002, "Anna", 500.00, 0.01);

            acc10.Withdraw(10.00);
            acc20.Withdraw(10.00);

            Console.WriteLine(acc10.Balance);
            Console.WriteLine(acc20.Balance);


        }
    }
}
