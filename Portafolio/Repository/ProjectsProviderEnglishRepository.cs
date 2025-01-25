using Portafolio.Models;
using Portafolio.Repository;

namespace Portafolio.Provider
{
    public class ProjectsProviderEnglishRepository : IProjectsEnglishRepository
    {
        public List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project
                {
                    Name = "Task Manager",
                    Description = "System that allows users to manage tasks, attach files, and register detailed steps.",
                    Technologies = "HTML, CSS, BOOSTRAP, ASP.NET, JQUERY, KNOCKOUT.js",
                    ImageUrl = "/Images/TaskManagerImage.png",
                    GithubLink = "https://github.com/Charly7017/ManejoTareas",
                    Category = ProjectCategory.Web
                },
                new Project
                {
                    Name = "Accounts Payable System",
                    Description = "Provides detailed control of received invoices, pending payments, and due dates.",
                    Technologies = "HTML, CSS, BOOTSTRAP, ASP.NET, JQUERY",
                    ImageUrl = "/Images/accountspayablesystemImage.png",
                    GithubLink = "https://github.com/Charly7017/CuentasPorPagar",
                    Category = ProjectCategory.Web
                },
                new Project
                {
                    Name = "Super Hero App",
                    Description = "Mobile application to manage heroes.",
                    Technologies = "Xamarin, .NET",
                    ImageUrl = "",
                    GithubLink = "https://github.com/Charly7017/SuperHeroApp",
                    Category = ProjectCategory.Mobile
                }
            };
        }
    }
}
