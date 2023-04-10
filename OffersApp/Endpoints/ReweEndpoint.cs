using OffersApp.Offers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffersApp.Endpoints
{
    class ReweEndpoint : IEndpoint
    {
        public string Url { get; } = "https://www.rewe.de/api/all-stationary-offers/";

        public Task<IList<IOffer>> GetOffers()
        {
            throw new NotImplementedException();
        }
    }
}
