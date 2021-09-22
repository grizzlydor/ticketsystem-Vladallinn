using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC : Car
    {
        //public string Licenseplate { get; set; }
        //public DateTime date { get; set; }

        public MC()
        {

        }

        public MC(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;
        }

        public override double Price()
        {
            return 125.0;
        }

        public override string VehicleType()
        {
            return "MC";
        }
    }
}
