public class Account
{
    private decimal _balance;
    private string _name;


    // properties - provide read-only access to the private fields _balance 
    public decimal Balance {
        get { return _balance; }
    }

    // properties - provide read-only access to the private _name 
    public string Name {
        get { return _name; }
    }

    //  constructor - initializes these fields when a new Account object is created
    public Account(string name, decimal startingBalance) {
        _name = name;
        _balance = startingBalance;
    }

    public void Deposit(decimal amountToAdd) {
        _balance += amountToAdd;
    }

    public void Withdraw(decimal amountToWithdraw) {
        _balance -= amountToWithdraw;
    }


    public void Print() {
        Console.WriteLine($"Account Name: {Name}, Balance: {Balance}");
    }
}
