using System;
using System.Collections.Generic;
using System.Text;

namespace PacktLibraryNetStandard2
{
    public class Employee
    {
        public string name { get; set; }
        public int entero { get; set; }
        public Employee(string _name , int _entero) {
            name = _name;
            entero = _entero;
        }
        
    }
}
