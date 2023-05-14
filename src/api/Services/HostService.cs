using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace EchoIp.Services;

internal class HostService : IHostService
{
    public string HostName => Dns.GetHostName();

    public string HostIp => Dns.GetHostAddresses(HostName, AddressFamily.InterNetwork)
                                .First()
                                .ToString();
}
