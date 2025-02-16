using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portafolio.Models;
using Portafolio.Repository;
using System.Globalization;
using System.Linq;

namespace Portafolio.Pages
{
    public class ProjectsModel : PageModel
    {
        private readonly IProjectsSpanishRepository _projectsSpanishRepository;
        private readonly IProjectsEnglishRepository _projectsEnglishRepository;

        public ProjectsModel(IProjectsSpanishRepository projectsSpanishRepository, 
                            IProjectsEnglishRepository projectsEnglishRepository)
        {
            _projectsSpanishRepository = projectsSpanishRepository;
            _projectsEnglishRepository = projectsEnglishRepository;
        }


        public List<Project> Projects { get; set; } = new List<Project>();


        [BindProperty(SupportsGet = true)]
        public ProjectCategory Type { get; set; }

        public IActionResult OnGet()
        {
            List<Project> allProjects = null;
            var cultureTag = CultureInfo.CurrentCulture.Name;

            allProjects = cultureTag == "es"
            ? _projectsSpanishRepository.GetProjects()
            : _projectsEnglishRepository.GetProjects();


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
                return new JsonResult(new { Projects,cultureTag});
            }

            return Page();

        }

    }
}
