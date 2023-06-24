using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.	Create class Employee. Add fields like id, name, basic salary, HRA, TA, PF. Accept the value of id, name & basic salary from constructor. Calculate the employee gross salary& display employee details using ToString() method
//a.HRA - 40 % of basic salary
//b.	TA – 20% of basic salary
//c.	PF -12 % of basic salary

namespace METHODS
{
    public class Emp
    {
        protected int empid;
        protected string name;
        protected double basicSal, totalSal, grossSal, hra, ta, pf;
        private static int count;

        public Emp(string name, double basicSal)
        {
            count++;
            empid = count;
            this.name = name;
            this.basicSal = basicSal;
        }

        public virtual void CalculateSalary()
        {
            hra = basicSal * 0.40;
            ta = basicSal * 0.20;
            
            pf = basicSal * 0.12;

            totalSal = hra + ta;

            grossSal = (totalSal) - pf;
        }
        public override string ToString()
        {
            return $"id = {empid} \nName = {name} \nGross = {grossSal}";
        }
    }
}

           

      
    

