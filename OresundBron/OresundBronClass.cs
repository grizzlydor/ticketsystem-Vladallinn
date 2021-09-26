using System;
using ClassLibraryTicketSystem;
namespace OresundBron
{
    public class OresundBronClass
    {
        private Car mac = new Car(false);
        private MC Mc = new MC(true);
        
        
        //public OresundBronClass(bool brobrizz)
        //{
                
        //}
        

        public double GetPrice()
        {
            var car = mac.Price();
            var mc = Mc.Price();
             car = 410;
             mc = 210;
            if (mac.Brobizz == true)
            {
               return car = 161;
            }

            if (Mc.Brobizz == true)
            {
                return mc = 73;
            }

            return 0;
        }


    }
}
