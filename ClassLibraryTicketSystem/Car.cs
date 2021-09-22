using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace ClassLibraryTicketSystem
{
    public abstract class Car
    {
        public bool Brobizz { get; set; }
        public double Discount { get; set; }
        public string Licenseplate
        {
            get => Licenseplate;
            set
            {
                if (value.Length > 7 || value.Length < 0)
                {
                    throw new ArgumentException($"Can not be less than 1 and more than 7 characters. You entered: {value}");
                }
                Licenseplate = value;
            }
        }
        public DateTime Date { get; set; }


        public Car(bool broobrizz, DateTime date, string license, double discount)
        {
            Brobizz = broobrizz;
            Date = date;
            Licenseplate = license;
            Discount = discount;
        }

        public Car()
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

        public virtual double DiscountPrice(double price, double discount)
        {
            if (Brobizz == true)
            {
                return price - (price * discount / 100);
            }
            return price;
        }

        public virtual string CheckLicense()
        {
           return Licenseplate = "1234567890";
        }
    }

}
