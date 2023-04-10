using OffersApp.Offers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffersApp.Endpoints
{
    interface IEndpoint
    {
        string Url { get; }

        Task<IList<IOffer>> GetOffers();
    }
}
