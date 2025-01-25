﻿using Portafolio.Models;
using Portafolio.Repository;

namespace Portafolio.Provider
{
    public class ProjectsProviderSpanishRepository : IProjectsSpanishRepository
    {
        public List<Project> GetProjects()
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
