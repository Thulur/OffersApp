using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffersApp.Offers
{
    internal class EdekaOffer : IOffer
    {

        [JsonIgnore]
        public double Price { get; set; }
        public double Percentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        public string Infos
        {
            get
            {
                return Title;
            }
        }
    }
}
