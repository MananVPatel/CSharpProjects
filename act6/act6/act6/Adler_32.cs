//Manan Patel
//CMPSC 302
//2/2/2016
//11:31 AM 
//Activity 6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act6
{
    class Adler_32
    {
        //constant values for calculations
        const int MOD_ADLER = 65521;
        const int FACTOR = 65536;

        //local variables
        string _adlerNum;
        string hexNum;
        
        //return the adler number as a string
        public string adlerNumber()
        {
            return _adlerNum;
        }

        //constructor
        public Adler_32(string input)
        {
            //adler_32 algorthim
            long a = 1, b = 0;
            long adler;
            int i;

            //traverse through the entire string and calculate values 
            for(i = 0; i < input.Length; i++)
            {
                a += (int) input[i]; // cast the letter to int 
                b += a; // add a to b
            }
            //do modulo division for both a and b
            b = b % MOD_ADLER; 
            a = a % MOD_ADLER;
            //calculate the adler number
            adler = b * FACTOR + a;

            //convert adler number to hexadecimal and pass it as a string
            hexNum = adler.ToString("X");
            _adlerNum = hexNum;
        }
    }
}
