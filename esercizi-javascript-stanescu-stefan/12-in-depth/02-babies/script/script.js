let babies = [];

//object literal
babies.push({
    name: "Pushka",
    months: 9,
    noises: ["giggle","cry"],
    favoriteFoods: ["candies", "banana"]
});

//array index assignment
babies[1] = {
    name: "Dragos",
    months: 11,
    noises: ["babble", "squeal"],
    favoriteFoods: ["sweet potato","peach"]
};

//push
let baby2 = {
    name: "Mitraliera",
    months: 2001,
    noises: ["coo", "laugh"],
    favoriteFoods: ["carrot", "tomato"]
};
babies.push(baby2);

//spread operator to clone a template
const babyTemplate = {
    name: "",
    months: 0,
    noises: [],
    favoriteFoods: []
};
let baby4 = { ...babyTemplate,name: "Noah", months:15, noises: ["gurgle", "hum"], favoriteFoods:["avocado", "mango"] };
babies.push(baby4);

babies.forEach(baby => {
    console.log(Object.entries(baby).map(([key, value]) => `[${key}:"${value}"]`).join(", "));
});

babies.forEach(baby => {
    baby.outfit = {
        shirt: "shirt",
        pants: "pants",
        shoes: "the nice ones"
    };
});

babies.forEach(baby => {
    console.log(JSON.stringify(baby, null, 2));
});
