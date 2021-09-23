﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class Machine 
    {
        
        /// <summary>
        /// 
        /// </summary>
        protected bool Brobizz { get; set; }
        /// <summary>
        /// 
        /// </summary>
        private double Discount { get; set; }
        /// <summary>
        /// 
        /// </summary>

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
        /// <summary>
        /// 
        /// </summary>
        private DateTime Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="broobrizz"></param>
        /// <param name="date"></param>
        /// <param name="licenseplate"></param>
        /// <param name="discount"></param>
        public Machine(bool broobrizz, DateTime date, string licenseplate, double discount)
        {
            Brobizz = broobrizz;
            Date = date;
            Licenseplate = licenseplate;
            Discount = discount;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="licenseplate"></param>
        public Machine(string licenseplate)
        {
            Licenseplate = licenseplate;
        }


        public Machine(bool brobizz)
        {
            Brobizz = brobizz;

        }

        /// <summary>
        /// 
        /// </summary>
        public Machine()
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
        /// 
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

