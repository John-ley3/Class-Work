namespace Individual.Exercises.Classes
{
    public class Employee
    {
        public Employee(int employeeId, string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeId = employeeId;
            AnnualSalary = salary;
        }
        public int EmployeeId { get; }

        public string FirstName { get; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        public string Department { get; set; }

        public double AnnualSalary { get; private set; }

        public void RaiseSalary(double percent)
        {
            AnnualSalary += (AnnualSalary * (percent / 100));
        }
    }
}
