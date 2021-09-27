using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundBron
{
    public class OresundMc : Vehicle
    {
        protected bool Brobizz { get; set; }


        public OresundMc(bool brobizz)
        {
            Brobizz = brobizz;
        }

        public OresundMc()
        {

        }
        /// <summary>
        /// Method which return VehicleType by string.
        /// </summary>
        /// <returns>OresundMC</returns>
        public override string VehicleType()
        {
            return "OresundMc";
        }
        /// <summary>
        /// Method which was override from class Vehicle. Method is making discount.
        /// </summary>
        /// <param name="price">410</param>
        /// <param name="discount">0</param>
        /// <returns></returns>
        public override double DiscountPrice(double price, double discount)
        {
            OresundMc mc = new OresundMc(true);
            if (mc.Brobizz is true)
            {
                return 73;
            }
            return price;
        }
    }
}
