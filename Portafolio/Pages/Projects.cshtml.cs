using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portafolio.Models;
using System.Linq;

namespace Portafolio.Pages
{
    public class ProjectsModel : PageModel
    {
        public List<Project> Projects { get; set; } = new List<Project>();


        [BindProperty(SupportsGet = true)]
        public ProjectCategory Type { get; set; }

        public IActionResult OnGet()
        {

            var allProjects = GetProjects();


            if (Type == ProjectCategory.All)
            {
                Projects = allProjects;
            }
            else
            {
                Projects = allProjects.Where(p => p.Category == Type).ToList();
            }

            if(HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return new JsonResult(Projects);
            }

            return Page();

        }

        private List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project
                {
                    Name = "Manejador de tareas",
                    Description = "Sistema que permite a los usuarios gestionar tareas, anexar archivos y registrar pasos detallados.",
                    Technologies = "HTML, CSS, BOOSTRAP, APS.NET, JQUERY, KNOCKOUT.js",
                    ImageUrl = "/Images/TaskManagerImage.png",
                    GithubLink = "https://github.com/Charly7017/ManejoTareas",
                    Category = ProjectCategory.Web
                },
                new Project
                {
                    Name = "Sistema de cuentas por pagar",
                    Description = "Permite un control detallado de las facturas recibidas, los pagos pendientes y las fechas de vencimiento.",
                    Technologies = "HTML, CSS, BOOTSTRAP, ASP.NET, JQUERY",
                    ImageUrl = "/Images/accountspayablesystemImage.png",
                    GithubLink = "https://github.com/Charly7017/CuentasPorPagar",
                    Category = ProjectCategory.Web
                },
                new Project
                {
                    Name = "Super Hero App",
                    Description = "Aplicación móvil para gestionar héroes.",
                    Technologies = "Xamarin, .NET",
                    ImageUrl = "",
                    GithubLink = "https://github.com/Charly7017/SuperHeroApp",
                    Category = ProjectCategory.Mobile
                }
            };
        }
    }
}
