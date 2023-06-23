namespace Employee.Models
{
    public class Employee
    {
        public int empno;
        public string empname;
        public string designation;
        public int salary;

        //constructor
        public Employee(int id,string name,string dg,int amt)
        {
            empno = id;
            empname = name;
            designation = dg;
            salary = amt;
        }

        //creating property
        public int Empno
        {
            get { return empno; }
        }
        public string Empname
        {
            get { return empname; }
        }
        public string Designamtion
        {
            get { return designation; }
        }
        public int Salary
        {
            get { return salary; }
        }
    }
}
