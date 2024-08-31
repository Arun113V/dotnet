class Program
{
    static void Main ()
    {
        Employee emp1 = new Employee (101,"Scott","Hyderabad");
        System.Console.WriteLine(emp1.EmpId);
        System.Console.WriteLine(emp1.EmpName);
        System.Console.WriteLine(emp1.Location);
        System.Console.WriteLine(emp1.locationCountry());
        System.Console.WriteLine(emp1.getHealthInsurance());
        System.Console.WriteLine();
        
        // Manager class objects and values
        Manager mgr1 = new Manager (102,"Taylor","Bengaluru","Accounts");
        System.Console.WriteLine(mgr1.EmpId);
        System.Console.WriteLine (mgr1.EmpName);
        System.Console.WriteLine(mgr1.Location);
        System.Console.WriteLine (mgr1.DepartmentName);
        System.Console.WriteLine (mgr1.GetTotalSalesOfTheYear());   
        System.Console.WriteLine (mgr1.GetFullDepartmentName());
        System.Console.WriteLine(mgr1.getHealthInsurance());
        System.Console.WriteLine();

        SalesMan sales1 = new SalesMan(103,"Dixy","Shivamogga","South India");
        System.Console.WriteLine(sales1.EmpId);
        System.Console.WriteLine(sales1.EmpName);
        System.Console.WriteLine(sales1.Location);
        System.Console.WriteLine(sales1.Region);
        System.Console.WriteLine(sales1.GetSalesRegon());
        System.Console.WriteLine();
        

    }
}