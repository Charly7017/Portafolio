using Portafolio.Models;
using Portafolio.Repository;

namespace Portafolio.Provider
{
    public class ProjectsProviderEnglishRepository : IProjectsEnglishRepository
    {
        public List<Project> GetProjects()
        {

            string commonTechnologies = "HTML, CSS, Bootstrap, JavaScript, jQuery, C#, ASP.NET, SQL";


            return new List<Project>
            {
                new Project
                {
                    Name = "Task Manager",
                    Description = "System that allows users to manage tasks, attach files, and register detailed steps.",
                    Technologies = $"{commonTechnologies}, Knockout.js",
                    ImageUrl = "/Images/TaskManagerImage.png",
                    GithubLink = "https://github.com/Charly7017/ManejoTareas",
                    Category = ProjectCategory.Web
                },
                new Project
                {
                    Name = "Accounts Payable System",
                    Description = "Provides detailed control of received invoices, pending payments, and due dates.",
                    Technologies = commonTechnologies,
                    ImageUrl = "/Images/accountspayablesystemImage.png",
                    GithubLink = "https://github.com/Charly7017/CuentasPorPagar",
                    Category = ProjectCategory.Web
                },
                new Project
                {
                    Name = "iContainer",
                    Description = "As a trainee at TAMSA, I participated in the development of this mobile application.",
                    Technologies = "C#, .NET MAUI",
                    ImageUrl = "/Images/iContainerImage.png",
                    GithubLink = "https://play.google.com/store/apps/details?id=com.tenaris.iContainer&hl=es_419",
                    Category = ProjectCategory.Mobile
                },
                new Project
                {
                    Name = "Booking System",
                    Description = "Web application for managing villa bookings with features like availability search, villa management, amenities tracking, and booking records.",
                    Technologies = commonTechnologies,
                    ImageUrl = "/Images/BookingSystemImage.png",
                    GithubLink = "https://github.com/Charly7017/BookingSystem",
                    Category = ProjectCategory.Web
                }
            };
        }
    }
}
