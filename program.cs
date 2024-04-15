using System;

namespace _2_2P
{
    public class Program
    {
        public static void Main()
        {
            Account account = new Account("Jake's Account", 20000);
            account.Print(); // Print initial details
            account.Deposit(100); // Deposit 100
            account.Print(); // Print details after deposit
            account.Withdraw(5000); // Withdraw 5000
            account.Print(); // Print details after withdrawal

            Account myAccount = new Account("Yang's Account", 10000); // Add Yang's account
            myAccount.Print(); // Print Yang's account details
            myAccount.Deposit(5000); // Deposit 5000 to Yang's account
            myAccount.Print(); // Print details after deposit
            myAccount.Deposit(10000); // Deposit 10000 more
            myAccount.Print(); // Print details after deposit
            myAccount.Withdraw(5000); // Withdraw 5000
            myAccount.Print(); // Print details after withdrawal
        }
    }
}
