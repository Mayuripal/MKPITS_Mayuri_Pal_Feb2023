namespace WebApplication2.Models
{
    public class Employee
    {
        public int Empid;
        public string Empname;
        public string Designation;
        public int Salary;

        //constructor
        public Employee(int empid, string name, string designation, int salary)
        {
            Empid = empid;
            Empname = name;
            Designation = designation;
            Salary = salary;
        }

        //
       public int EmployeeId { get { return Empid; } }

        public string EmployeeName { get { return Empname; } }

        public string EmployeeDesignation { get { return Designation; } }

        public int EmployeeSalary { get { return Salary; } }


    }
}
