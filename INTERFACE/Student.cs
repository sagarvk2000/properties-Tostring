using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.	Create class Student, with roll no , name , percentage auto implemented properties.
//Use property initialize syntax to assign the values. Print the student details

namespace METHODS
{
    public class Student
    {
        public int rollno { get; set; }
        public string name { get; set; }
        public double percentage { get; set; }
        public string PrintSD()
        {
            return $"Student is roll no is={rollno}\nname is= {name}\npercentage is ={percentage}";
        }

        
        

    }
}
