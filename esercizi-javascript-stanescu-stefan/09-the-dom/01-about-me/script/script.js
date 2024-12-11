

document.body.style.fontFamily = "Arial, sans-serif";
document.getElementById("nickname").textContent = "CodeMaster";
document.getElementById("favorites").textContent = "Programming, Music, Hiking";
document.getElementById("hometown").textContent = "TechVille";

const listItems = document.querySelectorAll("li");
listItems.forEach((item) => {
    item.className = "list-item";
});

const img = document.createElement("img");
img.src = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/f2fc1c12-9b00-49f1-b483-8fce5548632a/d2o51t1-57d2fa3d-34ef-469b-9dc4-0def9eb54b17.jpg/v1/fit/w_581,h_371,q_70,strp/pokebar___drunk_pikachu_by_baitti_d2o51t1-375w-2x.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9MzcxIiwicGF0aCI6IlwvZlwvZjJmYzFjMTItOWIwMC00OWYxLWI0ODMtOGZjZTU1NDg2MzJhXC9kMm81MXQxLTU3ZDJmYTNkLTM0ZWYtNDY5Yi05ZGM0LTBkZWY5ZWI1NGIxNy5qcGciLCJ3aWR0aCI6Ijw9NTgxIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmltYWdlLm9wZXJhdGlvbnMiXX0.de4Y5T-Z0LiH7YTaB85PeCFK8c2iTGU-HR7Opv0zImU";
img.alt = "A picture of me";
document.body.appendChild(img);


setTimeout(() => {
    const link = document.createElement("link");
    link.rel = "stylesheet";
    link.href = "./style/style.css";
    document.head.appendChild(link);
}, 4000);