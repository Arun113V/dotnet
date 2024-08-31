public class Manager : Employee
{
    private string _departmentName;

    public Manager(int empID, string empName, string location, string departmentName) : base(empID, empName, location)
    {
        _departmentName = departmentName; 

    }

    public string DepartmentName
    {
        set
        {
            _departmentName = value;
        }
        get
        {
            return _departmentName;
        }
    }

    public long GetTotalSalesOfTheYear()
    {
        return 10000;
    }

    public string GetFullDepartmentName()
    {
        return DepartmentName + " " + "at" + " " + base.Location;
    }

    public override string getHealthInsurance()
    {
        System.Console.WriteLine(base.getHealthInsurance());
        return "InsuranceAmountis" + 1000;
    }
}