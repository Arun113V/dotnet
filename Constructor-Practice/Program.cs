class Program
{
        public static void Main()
        {
            System.Console.WriteLine("Below are the employee details");

            Employee employee1 = new Employee(101, "Robert", "Manager");
            Employee employee2 = new Employee(103, "Tim", "Director");
            Employee employee3 = new Employee(10, "David", "President");

            System.Console.WriteLine(Employee.companyname);
            System.Console.WriteLine("First Employee");
            System.Console.WriteLine(employee1.EmployeeID);
            System.Console.WriteLine(employee1.EmployeeName);
            System.Console.WriteLine(employee1.Job);
            System.Console.WriteLine();
            System.Console.WriteLine("Second Employee");
            System.Console.WriteLine(employee2.EmployeeID);
            System.Console.WriteLine(employee2.EmployeeName);
            System.Console.WriteLine(employee2.Job);
            System.Console.WriteLine();
            System.Console.WriteLine("Third Employee");
            System.Console.WriteLine(employee3.EmployeeID);
            System.Console.WriteLine(employee3.EmployeeName);
            System.Console.WriteLine(employee3.Job);
            System.Console.WriteLine();


        }
}