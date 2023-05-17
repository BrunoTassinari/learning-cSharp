namespace ByteBank;

public class Program
{
    public static void Main(string[] args)
    {
        Account account = new Account();
        account.account = "123";
        account.Agency= 12;
        account.Balance = 100.0;
        account.name = "Guilherme";


        Console.WriteLine(account.Agency);
    }
}