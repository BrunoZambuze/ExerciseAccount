using System;

namespace ExerciseAccount.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        //Construtor
        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //Função para Saque
        public virtual void WithDraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        //Função para Depósito
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
