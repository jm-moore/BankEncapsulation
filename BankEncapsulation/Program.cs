using BankEncapsulation;

Console.WriteLine("What is your name?");
var name = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"Hello {name}, would you like to open an account? Please type yes or no:");

var openNewAccount = Console.ReadLine();
if (openNewAccount == "yes")
{
    var newAccount = new BankAccount();
    Console.WriteLine();
    Console.WriteLine("Let's put some money into your account - Enter an amount to deposit:");
    newAccount.Deposit(double.Parse(Console.ReadLine()));
    Console.WriteLine();
    Console.WriteLine("Awesome! Your account has been created. Would you like to make a withdrawal, another deposit, or sign out?");
    var option = Console.ReadLine();
    Console.WriteLine();
    if (option == "withdrawal")
    {
        Console.WriteLine("How much would you like to withdrawal?");
        var withdrawalAmount = double.Parse(Console.ReadLine());
        newAccount.Withdrawal(withdrawalAmount);
        Console.WriteLine();
        Console.WriteLine($"Your money has been withdrawn! Your new balance is {newAccount.GetBalance()}.");
    }
    else if (option == "deposit")
    {
        Console.WriteLine("How much would you like to deposit?");
        var depositAmount = double.Parse(Console.ReadLine());
        newAccount.Deposit(depositAmount);
        Console.WriteLine();
        Console.WriteLine($"You money has been deposited! Your new balance is {newAccount.GetBalance()}.");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("You're all set! Have a great day!");
    }
    
}
else
{
    Console.WriteLine();
    Console.WriteLine($"Have a great day!");
}


//BankAccount Josh = new BankAccount();
//Josh.Deposit(2500.00);
//Josh.Withdrawal(125.00);

//Console.WriteLine(Josh.GetBalance());
