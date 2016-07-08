// Manan Patel
// CMPSC 302
// Activity 20
// 4/5/2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act20
{
    class Products
    {
        //private variables
        private string _partNo;
        private string _partDesc;
        private string _partQuantity; 
        private decimal _partPrice;


        //empty constructor
        public Products()
        {

        }

        //constructor with parameters
        public Products(string pNo, string pDesc, string pQuan, decimal pPrice)
        {
            _partNo = pNo;
            _partDesc = pDesc;
            _partPrice = pPrice;
            _partQuantity = pQuan;
        }

        //setter and getters for each instance variable
        public string Number
        {
            get { return _partNo; }
            set { _partNo = value; }
        }

        public string Description
        {
            get { return _partDesc; }
            set { _partDesc = value; }
        }
        
        public string Quantity
        {
            get { return _partQuantity; }
            set { _partQuantity = value; }
        }

        public decimal Price
        {
            get { return _partPrice; }
            set { _partPrice = value; }
        }
    }
}
