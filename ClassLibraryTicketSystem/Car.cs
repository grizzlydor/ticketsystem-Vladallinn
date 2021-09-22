using System;

namespace ClassLibraryTicketSystem
{
    public class Car
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }


        //public Car(string licenseplate, DateTime date)
        //{
        //    Licenseplate = licenseplate;
        //    Date = date;
        //}

        public double Price()
        {
            return 240.0;
        }

        public string VehicleType()
        {
            return "Car";
        }
        
    }

}
