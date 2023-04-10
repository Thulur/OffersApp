using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffersApp.Offers
{
    internal interface IOffer
    {
        int Price { get; set; }

        int Percentage { get; set; }

        DateTime StartDate { get; set; }

        DateTime EndDate { get; set; }

        void Parse(string input);
    }
}
