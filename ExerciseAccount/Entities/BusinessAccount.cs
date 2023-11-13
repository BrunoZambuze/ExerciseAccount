using System;
namespace ExerciseAccount.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        //Construtor
        public BusinessAccount()
        {
        }
                                                                                            //Construtores da classe Account
        public BusinessAccount(int number, string holder, double balance, double loanlimit) : base(number, holder, balance)
        {
            LoanLimit = loanlimit;
        }

        //Função de empréstimo
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
