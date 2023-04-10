using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffersApp.Offers
{
    internal interface IOffer
    {
        [JsonIgnore]
        string Infos { get; }

        double Price { get; set; }

        double Percentage { get; set; }

        DateTime StartDate { get; set; }

        DateTime EndDate { get; set; }
    }
}
