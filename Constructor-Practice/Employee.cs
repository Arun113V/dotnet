public class Employee
    {
        private int _employeeID;
        private string _employeeName;
        private string _job;

        public int EmployeeID 
        {
        set
        {
            if (value >= 100)
            {
                _employeeID = value;
            }
            
        }
            get { return _employeeID; }
        }
        public string EmployeeName
        {
            set
            {
                if (value.Length<=20)
                {
                _employeeName = value;
                }
            }
            get { return _employeeName; }
        }
    public string Job
    {
        set
        {
            if (value.Length <= 20)
            {
                _job = value;
            }
        }
        get { return _job; }
    }


    public static string companyname;
        public Employee(int employeeID, string employeeName, string job)
        {
            this.EmployeeID = employeeID;
            this.EmployeeName = employeeName;
            this.Job = job;
        }

        static Employee()
        {
            companyname = "ABC Company";
        }

}
