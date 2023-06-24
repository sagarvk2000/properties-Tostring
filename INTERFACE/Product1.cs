using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using properties (set/get) and object initilizer syntax
namespace METHODS
{
    public class Product1
    {
        private int id, origPrice;
        private double DisPrice, disPer, NewPrice;
        private string name;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int OrigPrice
        {
            set { origPrice = value; }
            get { return origPrice; }
        }
        public double DisPer
        {
            set { disPer = value; }
            get { return disPer; }
        }
        public void Discount()
        {
            DisPrice = OrigPrice * DisPer;
            NewPrice = OrigPrice - DisPrice;
        }
        public string Display()
        {
            return $"Original Price={OrigPrice},\nDiscounted Price={DisPrice}";

        }
        public override string ToString()
        {
            return $"Product Id={Id},\nProduct Name={Name},\nPrice is={OrigPrice},";
        }
    }
}
