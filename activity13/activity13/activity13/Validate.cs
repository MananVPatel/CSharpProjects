using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace activity13
{
    class Validate
    {
        //private variable
        private string _partNum;

        //constructor - intializes private variable
        public Validate(string ptNo)
        {
            _partNum = ptNo;
        }
        
        //checks to see if the string passed in is valid 
        public bool isValid()
        {
            bool OK = false;
            string pattern = @"^[268][0-9]{2}(?<pattern>(BX|MX|AY|DH))[0-9](\k<pattern>)[12][Z|Q|B|U]$";
            Regex r = new Regex(pattern);
            
            //if string passed in matched the pattern, return true
            if (r.IsMatch(_partNum))
            {
                OK = true;
            }
            return OK;
        }
    }
}
