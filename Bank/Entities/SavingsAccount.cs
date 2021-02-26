namespace Bank.Entities
{
    // Não pode ser herdada (sealed)
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        // Sobrescrita
        // Operação não pode ser sobrescrita mais em nenhuma outra subclasse (sealed)
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.00;
        }
    }
}
