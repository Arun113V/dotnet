public class Employee
{

    private int _empID;
    private string _empName;
    private string _location;

    public Employee(int empID, string empName, string location)
    {
        this._empID = empID;
        this._empName = empName;
        this._location = location;
    }

    public int EmpId
    {
        set
        {
            _empID = value;
        }
        get
        {
            return _empID;
        }
    }
    public string EmpName
    {
        set
        {
            _empName = value;
        }
        get
        {
            return _empName;
        }
    }
    public string Location
    {
        set
        {
            _location = value;
        }
        get
        {
            return _location;
        }
    }

    public string locationCountry()
    {
        return "India";
    }

    public virtual string getHealthInsurance()
    {
        return "InsuranceAmountis" + 500;
    }
}
