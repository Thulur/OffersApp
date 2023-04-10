using OffersApp.Offers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OffersApp.Endpoints
{
    class OfferGatherer
    {
        public static void Init()
        {
            EndpointManager.Instance.RegisterEndpoint<EdekaEndpoint>();
        }

        public static async Task<IList<IOffer>> Gather()
        {
            var offers = new List<IOffer>();
            foreach (var endpoint in EndpointManager.Instance.Endpoints)
            {
                var newOffers = await endpoint.GetOffers();
                offers.AddRange(newOffers);
            }

            return offers;
        }
    }
}
