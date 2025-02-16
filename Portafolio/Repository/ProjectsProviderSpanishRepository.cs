using Portafolio.Models;
using Portafolio.Repository;

namespace Portafolio.Provider
{
    public class ProjectsProviderSpanishRepository : IProjectsSpanishRepository
    {
        public List<Project> GetProjects()
        {
            string commonTechnologies = "HTML, CSS, Bootstrap, JavaScript, jQuery, C#, ASP.NET, SQL";


            return new List<Project>
            {
                new Project
                {
                    Name = "Manejador de tareas",
                    Description = "Sistema que permite a los usuarios gestionar tareas, anexar archivos y registrar pasos detallados.",
                    Technologies = $"{commonTechnologies}, Knockout.js",
                    ImageUrl = "/Images/TaskManagerImage.png",
                    GithubLink = "https://github.com/Charly7017/ManejoTareas",
                    Category = ProjectCategory.Web
                },
                new Project
                {
                    Name = "Seguimiento de pagos",
                    Description = "Permite un control detallado de las facturas recibidas, los pagos pendientes y las fechas de vencimiento.",
                    Technologies = commonTechnologies,
                    ImageUrl = "/Images/accountspayablesystemImage.png",
                    GithubLink = "https://github.com/Charly7017/CuentasPorPagar",
                    Category = ProjectCategory.Web
                },
                new Project
                {
                    Name = "iContainer",
                    Description = "Como prácticante en TAMSA, participe en el desarrollo de esta aplicación móvil.",
                    Technologies = "C#, .NET MAUI",
                    ImageUrl = "/Images/iContainerImage.png",
                    GithubLink = "https://play.google.com/store/apps/details?id=com.tenaris.iContainer&hl=es_419",
                    Category = ProjectCategory.Mobile
                },
                new Project
                {
                    Name = "Booking System",
                    Description = "Aplicación web para la gestión de reservas de villas, que permite buscar disponibilidad, administrar villas, gestionar servicios y consultar las reservas realizadas.",
                    Technologies = commonTechnologies,
                    ImageUrl = "/Images/BookingSystemImage.png",
                    GithubLink = "https://github.com/Charly7017/BookingSystem",
                    Category = ProjectCategory.Web
                }
            };
        }
    }
}
