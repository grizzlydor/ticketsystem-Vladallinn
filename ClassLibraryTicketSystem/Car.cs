﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// 
    /// </summary>
    public class Car : Machine
    {
        /// <summary>
        /// 
        /// </summary>
        public bool Brobizz { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Discount { get; set; }
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
        public DateTime Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="broobrizz"></param>
        /// <param name="date"></param>
        /// <param name="licenseplate"></param>
        /// <param name="discount"></param>
        public Car(bool broobrizz, DateTime date, string licenseplate, double discount)
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
        public Car(string licenseplate)
        {
            Licenseplate = licenseplate;
        }

        public Car(bool broobriz) : base(broobriz)
        {
            Brobizz = broobriz;
        }
        /// <summary>
        /// 
        /// </summary>
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
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <param name="discount"></param>
        /// <returns></returns>
        public double DiscountPrice()
        {
            var price = Price();
            if (Brobizz is true)
            {
                return price - (price * 5 / 100);
            }
            return price;
        }
        
    }

}
