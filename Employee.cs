class Employee
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Position;
    public decimal Salary;
     public void SetSalary(decimal salary)
    {
        Salary=salary;
        System.Console.WriteLine("Set a new Salary: "+ salary);
    }
    public void GetSalary()
    {
        
    }
}