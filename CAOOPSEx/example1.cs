namespace CAOOPSEx
{
    class Bank
    {
        private double balance;

        public Bank(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposit: ${amount}");
            Console.WriteLine($"Balance is: ${balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient Funds");
                return;
            }

            balance -= amount;
            Console.WriteLine($"Withdraw: ${amount}");
            Console.WriteLine($"Balance is: ${balance}");
        }
    }

    class example1    
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bank!");

            Bank account = new Bank(2000);

            Console.WriteLine("Deposit()");
            Console.WriteLine("Enter an amount:");
            double depositAmount = double.Parse(Console.ReadLine());
            account.Deposit(depositAmount);

            Console.WriteLine("Withdraw()");
            Console.WriteLine("Enter an amount:");
            double withdrawAmount = double.Parse(Console.ReadLine());
            account.Withdraw(withdrawAmount);

            Console.WriteLine("Enter an amount less than Balance:");
            double withdrawLessAmount = double.Parse(Console.ReadLine());
            account.Withdraw(withdrawLessAmount);
        }
    }
}