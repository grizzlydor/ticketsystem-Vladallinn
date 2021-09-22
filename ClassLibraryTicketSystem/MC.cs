using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC : Car
    {
        //public string _licenseplate { get; set; }
        //public DateTime date { get; set; }

        //public MC(string licenseplate) : base(licenseplate)
        //{
        //    //_licenseplate = licenseplate;
        //}

        public MC(bool brobrizz, double discount, DateTime date, string license ) : base (brobrizz, date, license, discount)
        {
                
        }
        //public MC(string licenseplate /*DateTime date*/) : base (licenseplate, /*date*/)
        //{
        //    Licenseplate = licenseplate;
        //    //Date = date;
        //}

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


        public override double DiscountPrice(double price, double discount)
        {
            if (Brobizz == true)
            {
                return price - (price * discount / 100);
            }
            return price;
        }


    }
}
