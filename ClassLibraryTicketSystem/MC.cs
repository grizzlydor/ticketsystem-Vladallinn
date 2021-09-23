using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// 
    /// </summary>
    public class MC : Machine
    {
        //private string Licenseplate { get; set; }
        //private DateTime date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="brobrizz"></param>
        /// <param name="discount"></param>
        /// <param name="date"></param>
        /// <param name="license"></param>
        public MC(bool brobrizz, double discount, DateTime date, string license ) : base (brobrizz, date, license, discount)
        {
                
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="licenseplate"></param>
        public MC(string licenseplate) : base(licenseplate)
        {
                
        }

        public MC(bool brobrizz) : base(brobrizz)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public MC()
        {
                
        }
        

        /// <summary>
        /// Method is override from Car class. Method is returning fixed amount.
        /// </summary>
        /// <returns>125</returns>
        public override double Price()
        {
            return 125.0;
        }

        /// <summary>
        /// Method is override. Method is returning string.
        /// </summary>
        /// <returns>MC</returns>
        public override string VehicleType()
        {
            return "MC";
        }

        /// <summary>
        /// Method which counts discount for customer. 
        /// </summary>
        /// <param name="price">The whole price for the service.</param>
        /// <param name="discount">The discount for this service.</param>
        /// <returns></returns>
        public double DiscountPrice()
        {
            //MC dibo = new MC();

            //var price = dibo.Price();
            var price = Price();
            if (Brobizz is true)
            {
                return price - (price * 5 / 100);
            }
            return price;
        }

    }
}
