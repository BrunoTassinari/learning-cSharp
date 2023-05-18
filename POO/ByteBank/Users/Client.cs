namespace ByteBank.Users;

public class Client
{
    public string Name;
    public string Cpf;
    public string Profession;

    public void showClientInfo()
    {
        Console.WriteLine($"Client name: {this.Name}");
        Console.WriteLine($"Client cpf: {this.Cpf}");
        Console.WriteLine($"Profession: {this.Profession}");
       
    }
}