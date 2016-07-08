// Manan Patel
// CMPSC 302
// Activity 16
// 3/22/2016


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity16
{
    public class Gradebook
    {
        //return the appropriate grade based on the value passed in
        public String LetterGrade(int value)
        {
            string grade;
            if (value >= 92 && value <= 100) grade = "A";
            else if (value >= 90 && value < 92) grade = "A-";
            else if (value >= 86 && value < 90) grade = "B+";
            else if (value >= 82 && value < 86) grade = "B";
            else if (value >= 80 && value < 82) grade = "B-";
            else if (value >= 76 && value < 80) grade = "C+";
            else if (value >= 70 && value < 76) grade = "C";
            else if (value >= 65 && value < 70) grade = "D";
            else if (value >= 0 && value < 65) grade = "F";
            else grade = "Letter Grade Invalid!";
            return grade;
        }
    }

    
}
