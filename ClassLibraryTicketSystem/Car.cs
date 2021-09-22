using System;

namespace ClassLibraryTicketSystem
{
    public abstract class Car
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }


        //public Car(string licenseplate, DateTime date)
        //{
        //    Licenseplate = licenseplate;
        //    Date = date;
        //}

        public virtual double Price()
        {
            return 240.0;
        }

        public virtual string VehicleType()
        {
            return "Car";
        }
        
    }

}
