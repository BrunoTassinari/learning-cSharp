using ByteBank.Users;
using ByteBank.Accounts;

namespace ByteBank;

public class Program
{
    public static void Main(string[] args)
    {
        // Account account = new Account();
        // account.Agency = 123;
        // account.NumberAccount = "122313-XX";
        // account.Name = "John Doe";
        // account.Balance = 100.0;
        //
        // Account account2 = new Account();
        // account2.Agency = 1234;
        // account2.NumberAccount = "122313-34R";
        // account2.Name = "Jane Doe";
        // account2.Balance = 1000.0;
        //
        // account2.makeDeposit(800);
        // account2.makePayment(200);
        //
        // account2.transfer(300, account);
        //
        // account2.showDataAccount();
        
        Client client = new Client();
        client.Name = "Bruno";
        client.Cpf = "123.456.789-10";
        client.Profession = "Developer";
        
        Account account = new Account(123, "123-XX", client);
        Console.WriteLine(Account.TotalAccountsCreated);      
        
        Account account2 = new Account(123, "123-XX", client);
        Console.WriteLine(Account.TotalAccountsCreated);    
        
        account2.Balance = 1000;
        account2.Balance = -1;
    }
}