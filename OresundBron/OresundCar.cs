using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundBron
{
    public class OresundCar : Vehicle
    {
        protected bool Brobizz { get; set; }


        public OresundCar(bool brobizz)
        {
            Brobizz = brobizz;
        }

        public OresundCar()
        {
                
        }
        /// <summary>
        /// Method which return VehicleType by string.
        /// </summary>
        /// <returns>OresundCar</returns>
        public override string VehicleType()
        {
            return "OresundCar";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <param name="discount"></param>
        /// <returns></returns>
        public override double DiscountPrice(double price, double discount)
        {
            OresundCar car = new OresundCar(true);
            if (car.Brobizz is true)
            {
                return 161;
            }
            return price;
        }
    }
}
