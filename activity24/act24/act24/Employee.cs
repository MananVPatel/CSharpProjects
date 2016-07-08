//Manan Patel
//Activity 4
//4/19/2016
//CMPSC 302


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act24
{
    class Employee
    {
        //private instance variables
        private string _name;
        private int _number;
        

        //empty constructor
        public Employee()
        {
            _name = null;
            _number = 0;
        }

        //parameterized constructor
        public Employee(string name, int number)
        {
            _name = name;
            _number = number;
        }

        //getters and setters for instance variables
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int number
        {
            get { return _number; }
            set { _number = value; }
        }

    }
}
