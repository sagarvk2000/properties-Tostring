using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.	Create class Product. Add fields like id, name and price. Create properties for each field.
//Use object initializer syntax initialize the object. Print product details using ToString()

//3.Use above Product class, create Discount method & accept the discount percentage. 
//Give discount to the price & Display actual price & discounted price
namespace METHODS
{
    public class Product
    {
        int Id, OrigPrice;
        double DisPrice, DisPer, NewPrice;
        string Name;
        public Product(int id, string name, int origPrice, double disPer)
        {
            this.Id = id;
            this.Name = name;
            this.OrigPrice = origPrice;
            //DisPrice = disPrice;
            this.DisPer = disPer;
            // NewPrice = newPrice;
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

