using S11V146_Exception.Entities.Excpetion;

namespace S11V146_Exception.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainExcpetion("Valor do saque excede o limite da conta.");
            }
            else if(amount > Balance)
            {
                throw new DomainExcpetion("Sem saldo na conta");
            }
            else
            {
                Balance -= amount;
            }

           
        }
    }
}
