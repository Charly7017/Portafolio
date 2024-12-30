namespace Portafolio.Models
{
    public class Project
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Technologies { get; set; }
        public string? ImageUrl { get; set; }
        public string? GithubLink { get; set; }
        public ProjectCategory Category { get; set; }
    }
}
