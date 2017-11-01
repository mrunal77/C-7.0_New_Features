using System;

namespace NewFeatureCSharp7
{
    public class Employee
    {
        int _ENo;
        string _Name, _Job;
        double _Salary;

        public Employee(int eno,string name, string job, double salary)
        {
            _ENo = eno;
            _Name = name;
            _Job = job;
            _Salary = salary;
        }
        public void Deconstruct(out int eno,out string name,out string job,out double salary)
        {
            eno = _ENo;
            name = _Name;
            job = _Job;
            salary = _Salary;
        }
    }
    class DconstructorDemo
    {
        static void Main()
        {
            Employee emp = new Employee(1001,"Mrunal","Engineer",18000.00);
            (int Eno, string Name, string Job, double Salary) = emp;
            var (eno, name, job, salary) = emp;
            Console.WriteLine(eno+name+job+salary+"\n ");
            Console.WriteLine("Employee Id: "+Eno);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Job: " + Job);
            Console.WriteLine("Employee Salary: " + Salary);
            Console.ReadLine();
        }
    }
}
