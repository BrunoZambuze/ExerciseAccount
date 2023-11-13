using System;
namespace ExerciseAccount.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        //Construtor
        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestrate) : base (number, holder, balance)
        {
            InterestRate = interestrate;
        }
        
        //Função para atualizar o saldo da conta baseado taxa de juros inserido
        public void updateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //Função para sacar sem descontar os 5 reais
        public override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Balance -= 2;
        }
    }
}
