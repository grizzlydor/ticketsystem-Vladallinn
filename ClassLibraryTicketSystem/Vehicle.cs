using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class Vehicle 
    {
        //this is my changes to the code
        //added this comment
        protected bool Brobizz { get; set; }
        private double Discount { get; set; }
        public string Licenseplate
        {
            get => Licenseplate;
            set
            {
                if (value.Length > 7 && value.Length < 0)
                {
                    throw new ArgumentException($"Can not be less than 1 and more than 7 characters. You entered: {value}");
                }
                Licenseplate = value;
            }
        }
        private DateTime Date { get; set; }

        
        protected Vehicle(string licenseplate)
        {
            Licenseplate = licenseplate;
        }

        protected Vehicle(bool brobizz)
        {
            Brobizz = brobizz;

        }

        protected Vehicle(bool brobizz, double discount)
        {
            Brobizz = brobizz;
            Discount = discount;
        }

        protected Vehicle(bool broobrizz, DateTime date)
        {
            Brobizz = broobrizz;
            Date = date;
        }

        protected Vehicle()
        {

        }

        /// <summary>
        /// Method is virtual and can be override. Method is returning fixed amount. 
        /// </summary>
        /// <returns>240.0</returns>
        public virtual double Price()
        {
            return 240.0;
        }
        /// <summary>
        /// Method is virtual and can be override. Method is returning string.
        /// </summary>
        /// <returns>Car</returns>
        public virtual string VehicleType()
        {
            return "Car";
        }
        /// <summary>
        /// Method is virtual and can be override. Method is returning double.
        /// </summary>
        /// <param name="price"></param>
        /// <param name="discount"></param>
        /// <returns></returns>
        public virtual double DiscountPrice(double price, double discount)
        {
            if (Brobizz == true)
            {
                return price - (price * discount / 100);
            }
            return price;
        }
    }
}

