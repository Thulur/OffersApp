using Newtonsoft.Json;
using OffersApp.Offers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffersApp.Endpoints
{
    class EdekaResponse
    {
        [JsonProperty("national")]
        public bool National { get; set; }

        [JsonProperty("totalCount")]
        public int OfferCount { get; set; }

        [JsonProperty("offers")]
        public EdekaOffer[] Offers { get; set; }
    }
}
