
using System.Threading.Channels;
using ByteBankADM.Employees;

namespace ByteBankADM
{
    public abstract class Program
    {
        public static void Main(string[] args)
        {
            
            var manager = new Manager("Camila", "987.654.321-10", 5000.0);
          

           
            manager.ShowEmployeeInfo();
            
            
        }
    }
}

