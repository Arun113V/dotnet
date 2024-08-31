public class SalesMan : Employee
{
    private string _region;

    public SalesMan(int empId, string empName, string location, string region) : base(empId, empName, location)
    {
        this._region = region;
        
    }

    public string Region
    {
        set
        {
            _region = value;
        }
        get
        {
            return _region;
        }
    }

    public long GetSalesOfTheCurrentMonth()
    {
        return 1000;
    }

    public string GetSalesRegon()
    {
        return base.locationCountry();
    }

}
