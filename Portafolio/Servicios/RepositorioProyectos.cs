using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
            {
                Titulo = "Divinity Fashion Look",
                Descripcion = "E-Commerce realizada en Wordpress",
                Link = "https://pelucasdivinityfashionlook.com/",
                ImagenURL = "/imagenes/pelucas.jpg"
            },
                new Proyecto
            {
                Titulo = "AG Technology",
                Descripcion = "E-Commerce realizada en Wordpress",
                Link = "https://agtechnology.com.ar/",
                ImagenURL = "/imagenes/agt.jpg"
            },
                new Proyecto
            {
                Titulo = "Benitegarcia",
                Descripcion = "Sitio Web realizado en Wordpress",
                Link = "http://benitegarcia.com/",
                ImagenURL = "/imagenes/benite.jpg"
            },
                new Proyecto
            {
                Titulo = "ConstruMeza",
                Descripcion = "Sitio Web realizado en Wordpress",
                Link = "https://construmeza.com/",
                ImagenURL = "/imagenes/construmeza.jpg"
            },
            };
        }
    }
}
