using Microsoft.AspNetCore.Mvc;
using Portafolio.Interfaces;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;
        private readonly IConfiguration configuration;

        public HomeController(
            ILogger<HomeController> logger,
            IRepositorioProyectos repositorioProyectos,
            IConfiguration configuration
        )
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
            this.configuration = configuration;
        }
        public IActionResult Index()
        {

            /*
             * LogTrace
             * LogDebug
             * LogInformation
             * LogWarning
             * LogError
             * LogCritical
             */

            //_logger.LogTrace("Este es un mensaje de Trace");
            //_logger.LogDebug("Este es un mensaje de Debug");
            //_logger.LogInformation("Este es un mensaje de Informtion");
            //_logger.LogWarning("Este es un mensaje de Warning");
            //_logger.LogError("Este es un mensaje de Error");
            //_logger.LogCritical("Este es un mensaje de Critical");

            //var apellido = configuration.GetValue<string>("apellido");

            //_logger.LogInformation("El apellido es:" + apellido);

            var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
            
            var modelo = new HomeIndexViewModel() 
            { 
                Proyectos = proyectos
            };
            return View(modelo);
        }

        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos();
            return View(proyectos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}