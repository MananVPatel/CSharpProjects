//Manan Patel
//CMPSC 302
//02/09/2016
//Activity 08


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace act8
{
    //checks the part No.
    class partValidator
    {
        //if the part No. passed in is valid return a bool value
        public bool isValid(string input)
        {
            //part no. pattern
            string pattern = "^[CVKJ]-[98][0-9]{4}-[0-9]{2}[157]!?$"; 

            Regex r = new Regex(pattern);
            bool OK;

            //if input(part no.) matches the pattern, return true 
            if(r.IsMatch(input))
            {
                OK = true;
            }
            else
            {
                //otherwise return false;
                OK = false;
            }

           
            return OK;

        }
    }
}
