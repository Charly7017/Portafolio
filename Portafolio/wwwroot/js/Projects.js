const list = document.querySelectorAll(".nav-list li");
const nav = document.querySelector(".navigation");

const btnBringWebProjects = $(".btnBringWebProjects")
var projects = " ";

$(".navigation").click(async function (e) {

    if ($(e.target).hasClass("btnBringWebProjects")) {
        try {
            projects = await bringData("Web");
        } catch (error) {
            console.error("Error:", error);
        }
    }
    else if ($(e.target).hasClass("btnBringMobileProjects")) {
        try {
            projects = await bringData("Mobile");
        } catch (error) {
            console.error("Error:", error);
        }
    }
    else if ($(e.target).hasClass("btnBringAllProjects")) {
        try {
            projects = await bringData("All");
        } catch (error) {
            console.error("Error:", error);
        }
    }
    else if ($(e.target).hasClass("btnBringMiniProjects")) {
        $("#results").empty();
        const miniProjectsHTML = `
            <div class="col reveal-project">
                <div class="cardProjects">
                    <img src="" alt="Project Image">
                    <h5>Mini proyectos</h5>
                    <p>En este repositorio mostrare mini proyectos que he hecho</p>
                    <p>HTML, CSS, JAVASCRIPT, jQuery</p>
                    <a target="_blank" class="btnGithub" href="https://github.com/Charly7017/MiniProjects">
                        <i class="bi bi-github"></i>
                    </a>
                </div>
          </div>`
            ;
        $("#results").append(miniProjectsHTML);
        return
    }

    printData(projects)

});

async function bringData(type) {
    try {
        const response = await $.ajax({
            url: `/Projects?type=${type}`,
            type: "GET",
            cache: false,
        });
        return response;
    } catch (error) {
        console.error("Error al cargar los proyectos:", error);
        alert("Hubo un error al cargar los proyectos.");
        throw error;
    }
}

function printData(projects) {
    $("#results").empty();

    projects.forEach(function (project) {
        const projectHTML = `
            <div class="col reveal-project">
                <div class="cardProjects">
                    <img src="${project.imageUrl}" alt="Project Image">
                    <h5>${project.name}</h5>
                    <p>${project.description}</p>
                    <p>${project.technologies}</p>
                    <a target="_blank" class="btnGithub" href="${project.githubLink}">
                        <i class="bi bi-github"></i>
                    </a>
                </div>
          </div>`
        ;
        $("#results").append(projectHTML);
    });
}


list.forEach((item) => {
    item.addEventListener("click", function (e) {
        list.forEach((li) => li.classList.remove("active"));
        e.currentTarget.classList.add("active");
    });
});



