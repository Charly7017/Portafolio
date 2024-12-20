using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portafolio.Models;

namespace Portafolio.Pages
{
    public class ProjectsModel : PageModel
    {
        public List<Project> Projects { get; set; } = new List<Project>();

        public void OnGet()
        {
            Projects = GetProjects();
        }

        private List<Project> GetProjects()
        {
            var list = new List<Project>()
            {
                new Project()
                {
                    Name = "Sistema de reservas",
                    Description="Sistema que reserva cosas",
                    Technologies="HTML, CSS, BOOSTRAP, APS.NET, KNOCKOUT"
                },
                new Project
                {
                    Name = "Gestión de inventarios",
                    Description = "Sistema que gestiona inventarios",
                    Technologies = "C#, SQL, ENTITY FRAMEWORK"
                },
                new Project
                {
                    Name = "Gestion de usuarios",
                    Description = "Sistema que gestiona usuarios",
                    Technologies = "C#, SQL, ENTITY FRAMEWORK,.net"
                },
                new Project
                {
                    Name = "Gestion de contenedores",
                    Description = "Sistema que gestiona contenedores",
                    Technologies = "C#, SQL, ENTITY FRAMEWORK,.net,knockout"
                }
            };

            return list;
        }

    }
}
