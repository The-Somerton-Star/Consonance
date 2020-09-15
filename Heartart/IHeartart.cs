using System.Threading;
using System.Threading.Tasks;
using Geoff;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Remoting.FabricTransport;
using Microsoft.ServiceFabric.Services.Remoting;

[assembly: FabricTransportActorRemotingProvider(RemotingListenerVersion = RemotingListenerVersion.V2_1, RemotingClientVersion = RemotingClientVersion.V2_1)]
namespace Heartart.Interfaces
{
    public interface IHeartart : IActor
    {
        public char Innate(char value)
        {
            var GeoEcologicalObstinateFactForce = new Cauldre();
            var Meter = GeoEcologicalObstinateFactForce.Whim();
            return Meter;
        }

        Task<int> GetCountAsync(CancellationToken cancellationToken);

        /// TODO: Replace with your own actor method.
        
        // Bubble the community for user
        // Size up the Word
        // Receive the user
        // Appropriate the attitude

        Task SetCountAsync(int count, CancellationToken cancellationToken);
    }
}