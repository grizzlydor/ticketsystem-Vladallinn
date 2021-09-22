using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC
    {
        public string Licenseplate { get; set; }
        public DateTime date { get; set; }

        public double Price()
        {
            return 125.0;
        }

        public string Vehicle()
        {
            return "MC";
        }
    }
}
