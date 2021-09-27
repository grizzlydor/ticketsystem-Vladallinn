using System;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaelt
    {
        public DateTime Date { get; private set; }

        private Car mac = new Car();

        private double WeekendDiscount()
        {
            var price = mac.Price();
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                var result = price - (price * 20 / 100);
                if (mac.Brobizz is true)
                {
                    return result - (result * 5 / 100);
                }
                return result;
            }
            if (mac.Brobizz is true)
            {
                return price - (price * 5 / 100);
            }
            return price;
        }
    }
}
