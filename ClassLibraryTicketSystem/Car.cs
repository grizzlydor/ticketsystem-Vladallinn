using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace ClassLibraryTicketSystem
{
    
    public class Car : Machine
    {
        
        public bool Brobizz { get; set; }
        
        public double Discount { get; set; }
        
        
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
        
        public DateTime Date { get; set; }

        
        public Car(string licenseplate) : base(licenseplate)
        {
           
        }

        public Car(bool broobriz) : base(broobriz)
        {
            Brobizz = broobriz;
        }

        public Car(bool broobrizz, DateTime date) : base (broobrizz, date)
        {
            
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
        
        /// <summary>
        /// This method is checking discount. 
        /// </summary>
        /// <returns>Price</returns>
        public double DiscountPrice()
        {
            var price = Price();
            if (Brobizz is true)
            {
                return price - (price * 5 / 100);
            }
            return price;
        }

        /// <summary>
        /// The method is taking normal price and making discount for weekend and after making discount for Brobizz. 
        /// </summary>
        /// <returns></returns>
        public double WeekendDiscount()
        {
            var price = Price();
            DateTime d = DateTime.Now;
            d = new DateTime(2021, 9, 25);
            if (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday)
            {
                var result =  price - (price * 20 / 100);
                if (Brobizz is true)
                {
                    return result - (result * 5 / 100);
                }

                return result;
            }
            return price - (price * 5 / 100); 
        }
    }

}
