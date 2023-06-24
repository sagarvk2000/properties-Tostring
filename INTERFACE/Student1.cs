using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using constructor and Tostring method
namespace METHODS
{
    public class Student1
    {
        private int maths, chemistry, physics;
        private double total, percent;
        public Student1(int maths, int chemistry, int physics)
        {
            this.maths = maths;
            this.chemistry = chemistry;
            this.physics = physics;
        }
        public void Calculate()
        {
            total = maths + chemistry + physics;
            percent = (total / 300) * 100;
        }
        public override string ToString()
        {
            return $"The Total is ={total}\nPercent is ={percent}";
        }
    }
}
