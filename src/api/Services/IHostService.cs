namespace EchoIp.Services;

/// <summary>
/// Provides host system info
/// </summary>
public interface IHostService
{
    /// <summary>
    /// 
    /// 
    /// </summary>
    /// <value></value>
    string HostName { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    string HostIp { get; }
}
