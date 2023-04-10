using OffersApp.Offers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Windows;

namespace OffersApp.Endpoints
{
    class EdekaEndpoint : IEndpoint
    {
        static readonly HttpClient client = new();

        public string Url { get; } = "https://www.edeka.de/api/offers?limit=999";

        public async Task<IList<IOffer>> GetOffers()
        {
            var offers = new List<IOffer>();
            try
            {
                string responseJson = await client.GetStringAsync(Url);
                var response = JsonConvert.DeserializeObject<EdekaResponse>(responseJson);
                offers.AddRange(response.Offers);
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Keine Antwort", "Es gibt keine Rückgabewerte!", MessageBoxButton.OK);
            }

            return offers;
        }
    }
}
