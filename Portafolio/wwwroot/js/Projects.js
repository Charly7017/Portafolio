const list = document.querySelectorAll(".nav-list li");
const nav = document.querySelector(".navigation");

const btnBringWebProjects = $(".btnBringWebProjects")




$(".btnBringAllProjects").click(function (event) {
    event.preventDefault();

    $.ajax({
        url: "/Projects?type=All", // Pasa el parámetro 'type' en la URL
        type: "GET",
        cache: false,
        success: function (data) {
            $("#results").empty();
            data.forEach(function (project) {
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
                    </div>`;
                $("#results").append(projectHTML);
            });
        },
        error: function (xhr, status, error) {
            console.error("Error al cargar los proyectos:", error);
            alert("Hubo un error al cargar los proyectos.");
        }
    });
});



$(".btnBringWebProjects").click(function (event) {
    event.preventDefault();

    $.ajax({
        url: "/Projects?type=Web", // Pasa el parámetro 'type' en la URL
        type: "GET",
        cache: false,
        success: function (data) {
            $("#results").empty();
            data.forEach(function (project) {
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
                    </div>`;
                $("#results").append(projectHTML);
            });
        },
        error: function (xhr, status, error) {
            console.error("Error al cargar los proyectos:", error);
            alert("Hubo un error al cargar los proyectos.");
        }
    });
});


$(".btnBringMobileProjects").click(function (event) {
    event.preventDefault();

    $.ajax({
        url: "/Projects?type=Mobile", // Pasa el parámetro 'type' en la URL
        type: "GET",
        cache: false,
        success: function (data) {
            $("#results").empty();
            data.forEach(function (project) {
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
                    </div>`;
                $("#results").append(projectHTML);
            });
        },
        error: function (xhr, status, error) {
            console.error("Error al cargar los proyectos:", error);
            alert("Hubo un error al cargar los proyectos.");
        }
    });
});






list.forEach((item) => {
    item.addEventListener("click", function (e) {
        list.forEach((li) => li.classList.remove("active"));
        e.currentTarget.classList.add("active");
    });
});



