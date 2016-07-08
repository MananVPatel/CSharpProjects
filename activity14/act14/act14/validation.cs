using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace act14
{
    class validation
    {
        //private variable
        private string _PartNum;
        private bool _Suffix;

        //constructor - intialized the private variable

        public validation(String ptNo, bool suffix)
        {
            _PartNum = ptNo;
            _Suffix = suffix;
        }

        //checks to see if the string passed in is valid
        public bool isValid()
        {
            bool OK = false;
            string p1 = @"^(ER|JA|ME)-[73][0-9](?<third>[0-9])[0-9](?<fifth>[0-9])-(\k<third>)(\k<fifth>)[147]$";
            string p2 = @"^(ER|JA|ME)-[73][0-9](?<third>[0-9])[0-9](?<fifth>[0-9])-(\k<third>)(\k<fifth>)[147](?<suffix>[*])$";
            Regex r;
            if (_Suffix)
                r = new Regex(p2);
            else
                r = new Regex(p1);


            //if string passed in matched the pattern, return true
            if (r.IsMatch(_PartNum))
            {
                OK = true;
            }
            return OK;
        }
    }
}
