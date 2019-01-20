namespace BankAccount
{
    public class BankAccount
    {
        private int id;
        private decimal balance;

        public BankAccount(int id)
        {
            this.Id = id;
            this.Balance = 0;
        }


        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (this.Balance < amount)
            {
                System.Console.WriteLine("Insufficient balance");
            }
            else
            {
                this.Balance -= amount;
            }
        }
        public override string ToString()
        {
            return $"Account ID{this.Id}, balance {this.Balance:F2}";
        }
    }
}