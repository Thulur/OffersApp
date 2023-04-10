using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffersApp.Endpoints
{
    class EndpointManager
    {
        public static EndpointManager Instance { get; } = new EndpointManager();

        public IList<IEndpoint> Endpoints { get; } = new List<IEndpoint>();

        public void RegisterEndpoint<T>() where T : IEndpoint, new()
        {
            Endpoints.Add(new T());
        }
    }
}
