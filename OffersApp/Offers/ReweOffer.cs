using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffersApp.Offers
{
    internal class ReweOffer : IOffer
    {
        public double Price { get; set; }
        public double Percentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Infos => throw new NotImplementedException();
    }
}
