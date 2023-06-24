using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////using ToString method
            //Emp e1 = new Emp("sagar",30000);
            //e1.CalculateSalary();
            //Console.WriteLine(e1);

            //using constructor
            //Product p1 = new Product(101, "amazon", 3000, 0.3);
            //p1.Discount();
            //p1.Display();
            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(p1.Display());

            Student s1 = new Student();
            s1.rollno = 19;  // call to set accessor
            s1.name = "sagar";
            s1.percentage = 88.23;
            Console.WriteLine(s1.PrintSD());

            //Student1 s2 = new Student1(66,56,55);
            //s2.Calculate();
            //Console.WriteLine(s2.ToString());

            //using properties (set/get) and object initilizer syntax
            //Product1 p1=new Product1 { Id = 1,Name="m/c",OrigPrice=3000,DisPer=0.3 };
            //p1.Discount();
            //p1.Display();
            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(p1.Display());
        }
    }
}
