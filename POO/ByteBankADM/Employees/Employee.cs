namespace ByteBankADM.Employees
{
    public abstract class Employee
    {
        public static int TotalEmployees { get; protected set; }
        public string Name { get; set; }
        public string Cpf { get; protected set; }
        public double Salary { get; protected set; }
        public abstract double ShowBonus();
        public abstract void ShowEmployeeInfo();

        public abstract void IncreaseSalary();
    }
}


