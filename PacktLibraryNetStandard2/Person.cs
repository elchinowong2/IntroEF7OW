using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


namespace PacktLibraryNetStandard2
{
    public class Person
    {
        private void asd() {

            var employees = new List<Employee> 
            {
               new Employee("John Doe", 1230),
               new Employee("Lucy Novak", 670),
               new Employee("Robin Brown",2300),
               new Employee("Joe Draker", 1190),
               new Employee("Janet Doe", 980)
            };
            employees.Sort();
            employees.ForEach(employees => Console.WriteLine(employees));

        }

        record Employee(string Name, int Salary) : IComparable<Employee>
        {
            public int CompareTo(Employee other)
            {
                // return other.Salary.CompareTo(this.Salary);
                if (this.Salary < other.Salary)
                {
                    return 1;
                }
                else if (this.Salary > other.Salary)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
