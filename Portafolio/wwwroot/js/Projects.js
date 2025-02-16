$(document).ready(function () {
    const list = document.querySelectorAll(".nav-list li");
    var miniProjectsHTML = "";

    $(".navigation").click(async function (e) {
        const target = $(e.target).closest("li");
        const navSibling = $(e.target.parentElement.parentElement.parentElement.nextElementSibling)

        if (target.hasClass("btnBringWebProjects")) {
            navSibling.removeClass("justify-content-center")
            try {
                data = await bringData("Web");
            } catch (error) {
                console.error("Error:", error);
            }
        }
        else if (target.hasClass("btnBringMobileProjects")) {
            navSibling.removeClass("justify-content-center")
            try {
                data = await bringData("Mobile");
            } catch (error) {
                console.error("Error:", error);
            }
        }
        else if (target.hasClass("btnBringAllProjects")) {
            navSibling.removeClass("justify-content-center")
            try {
                data = await bringData("All");
            } catch (error) {
                console.error("Error:", error);
            }
        }
        else if (target.hasClass("btnBringMiniProjects")) {
            try {
                data = await bringData("All");
                console.log(data.cultureTag)
            } catch (error) {
                console.error("Error:", error);
            }

            if (data.cultureTag === "es") {
                miniProjectsHTML= templateMiniProjectsCard("Mini proyectos","En este repositorio muestro algunos mini proyectos");
            }
            else {
                miniProjectsHTML = templateMiniProjectsCard("Mini projects","In this repository I show some mini projects");
            }

            $("#results").empty();

            $("#results").append(miniProjectsHTML);
            navSibling.addClass("justify-content-center")
            return;
        }

        printData(data.projects)

    });


    function templateMiniProjectsCard(title, description) {
        return `
        <div class="col reveal-project">
            <div class="cardProjects">
                <img src="" alt="Project Image">
                <h5>${title}</h5>
                <p>${description}</p>
                <p>HTML, CSS, JavaScript, jQuery</p>
                <a target="_blank" class="btnGithub" href="https://github.com/Charly7017/MiniProjects">
                    <i class="bi bi-github"></i>
                </a>
            </div>
        </div>`;
    }



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
            </div>`;
            $("#results").append(projectHTML);
        });
    }

    list.forEach((item) => {
        item.addEventListener("click", function (e) {
            list.forEach((li) => li.classList.remove("active"));
            e.currentTarget.classList.add("active");
        });
    });
});
