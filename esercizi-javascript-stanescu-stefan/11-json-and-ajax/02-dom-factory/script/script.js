
const factoryJSON = `{
    "id": 101,
    "name": "Shit Car Factory",
    "location": "Mirafiori Torino, TO",
    "capacity": 5000,
    "isOperational": true,
    "employees": ["Alice", "Bob", "Charlie"],
    "contactInfo": {
      "phone": "123-456-7890",
      "email": "info@fiat.com"
    },
    "specializations": ["Hatchbacks", "SUVs", "Electric Vehicles"],
    "notes": null
  }`;
  
  const carsJSON = `[
    {
    "id": 1,
    "make": "Fiat",
    "model": "Punto",
    "year": 2001,
    "isElectric": false,
    "features": ["Bluetooth", "Wheel", "Need something else?"],
    "owner": {
      "name": "Stwfy",
      "address": "Street of the guy 312"
    },
    "previousOwner": null
  },
    {
      "id": 2,
      "make": "Tesla",
      "model": "Model 3",
      "year": 2022,
      "isElectric": true
    },
    {
      "id": 3,
      "make": "Ford",
      "model": "Mustang",
      "year": 2021,
      "isElectric": false
    },
    {
      "id": 4,
      "make": "Chevrolet",
      "model": "Bolt EV",
      "year": 2023,
      "isElectric": true
    },
    {
      "id": 5,
      "make": "Honda",
      "model": "Civic",
      "year": 2020,
      "isElectric": false
    }
  ]`;
  
  // Parse JSON strings
  const factory = JSON.parse(factoryJSON);
  const cars = JSON.parse(carsJSON);
  
  // DOM Elements
  const factoryList = document.getElementById("factory-list");
  const carsList = document.getElementById("cars-list");
  
  // Populate Factory List
  for (const key in factory) {
    const li = document.createElement("li");
    if (Array.isArray(factory[key])) {
      li.innerHTML = `<span class="title">${key}:</span> ${factory[key].join(", ")}`;
    } else if (typeof factory[key] === "object" && factory[key] !== null) {
      li.innerHTML = `<span class="title">${key}:</span> ${Object.entries(factory[key])
        .map(([k, v]) => `${k}: ${v}`)
        .join(", ")}`;
    } else {
      li.innerHTML = `<span class="title">${key}:</span> ${factory[key]}`;
    }
    factoryList.appendChild(li);
  }
  
  // Populate Cars List
  cars.forEach((car) => {
    const li = document.createElement("li");
    li.innerHTML = `<span class="title">Car ID:</span> ${car.id} <br>
                    <span class="title">Make:</span> ${car.make} <br>
                    <span class="title">Model:</span> ${car.model} <br>
                    <span class="title">Year:</span> ${car.year} <br>
                    <span class="title">Electric:</span> ${car.isElectric ? "Yes" : "No"}`;
    carsList.appendChild(li);
  });