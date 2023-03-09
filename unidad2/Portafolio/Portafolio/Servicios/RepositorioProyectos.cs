using Portafolio.Interfaces;
using Portafolio.Models;

namespace Portafolio.Servicios
{
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>
            {
                new Proyecto {
                    Titulo = "La Prensa",
                    Descripcion = "Aplicacion de Planilla realizado en ASP.Net Core",
                    ImagenUrl = "/images/pic-laprensa.png",
                    Link = "http://laprensa.hn"
                },
                new Proyecto {
                    Titulo = "Diunsa",
                    Descripcion = "E-Comerce desarrollado en React",
                    ImagenUrl = "/images/pic-diunsa.png",
                    Link = "http://diunsa.hn"
                },
                new Proyecto {
                    Titulo = "JetStereo",
                    Descripcion = "Desarrollo de un sistema de cotizaciones Oneline en React",
                    ImagenUrl = "/images/pic-jetstereo.png",
                    Link = "http://jetstereo.com"
                },
                new Proyecto {
                    Titulo = "UNAH",
                    Descripcion = "Sistema de Matricula en ASP.Net Core con base de datos Oracle",
                    ImagenUrl = "/images/pic-unah.png",
                    Link = "http://unah.hn.edu"
                },
            };
        }
    }
}
