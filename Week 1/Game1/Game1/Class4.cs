using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Cookie
    {
        public string Shape;
        public string Topping;
        public string Colour;
        public DateTime CreateDate;

        public Cookie(string shape, string topping, string colour, string createDate)
        {
            this.Shape = shape;
            this.Topping = topping;
            this.Colour = colour;
            this.CreateDate = DateTime.Parse(createDate);

        }

        public void ChangeTopping(string newTopping)
        {
            Topping = newTopping;
        }

        public bool outofdate(int date)
        {
            if (CreateDate > DateTime.Today.AddDays(-date))
            {
                return true;

            }
            return false;
        }

    }
  
  

}
