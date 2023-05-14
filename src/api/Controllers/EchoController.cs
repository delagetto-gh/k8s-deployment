using EchoIp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EchoIp.Controllers;

/// <summary>
/// Main Controller
/// </summary>
[ApiController]
[Route("[controller]")]
public class EchoController : ControllerBase
{
    private readonly ILogger<EchoController> _logger;
    private readonly IHostService _hostService;

    /// <summary>
    /// Ctor
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="hostService"></param>
    public EchoController(ILogger<EchoController> logger, IHostService hostService)
    {
        _logger = logger;
        _hostService = hostService;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<string> Get()
    {
        var infoString = $"{_hostService.HostName} : {_hostService.HostIp}";
        _logger.LogInformation(infoString);
        return infoString;
    }
}
