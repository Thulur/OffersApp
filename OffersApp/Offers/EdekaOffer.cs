using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffersApp.Offers
{
    internal class EdekaOffer : IOffer
    {
        public int Price { get; set; }
        public int Percentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public void Parse(string input)
        {
            throw new NotImplementedException();
        }
    }
}
