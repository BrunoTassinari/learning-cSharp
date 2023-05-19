namespace ByteBankADM.Employees
{
    public class Manager: Employee
    {

        public Manager(string name, string cpf, double salary)
        {
            this.Name = name;
            this.Cpf = cpf;
            this.Salary = salary;
            
        }
        
        public override double ShowBonus ()
        {
            return this.Salary + (this.Salary * 1);
        }

        public override void ShowEmployeeInfo()
        {
            Console.WriteLine($"Manager name: {this.Name}");
            Console.WriteLine($"Manager cpf: {this.Cpf}");
            Console.WriteLine($"Manager salary: {this.Salary}");
            Console.WriteLine($"Manager bonus: {this.ShowBonus()}");
        }

        public override void IncreaseSalary()
        {
            this.Salary *= 1.15;
        }
    }
}