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
    //productionworker extends employee
    class ProductionWorker : Employee
    {
        //instance variables
        private int _shiftNum;
        private double _hourlyPayRate;

        //Empty Constructor
        public ProductionWorker()
        {
            _shiftNum = 0;
            _hourlyPayRate = 0.0;
        }
        
        //parameterized constructor
        public ProductionWorker(int shiftNum, double hourlyPayRate, string name, int number):base(name, number)
        {
            _shiftNum = shiftNum;
            _hourlyPayRate = hourlyPayRate;
        }
        
        //getters and setters
        public int shiftNum
        {
            get { return _shiftNum; }
            set { _shiftNum = value; }
        }
        public double hourlyPayRate
        {
            get { return _hourlyPayRate; }
            set { _hourlyPayRate = value; }
        }
    }
}
