/**
 * @file: script.js
 * @author: Stefan Stanescu
 * 
 * Logs a recipe's details to the console.
 */

const recipes = [
    {
        title: "Spaghetti Bolognese",
        servings: 4,
        ingredients: [
            "spaghetti",
            "ground beef",
            "canned tomatoes",
            "Salt and pepper"
        ]
    },
    {
        title: "Pancakes",
        servings: 2,
        ingredients: [
            "flour",
            "sugar",
            "milk",
            "egg"
        ]
    },
    {
        title: "Caesar Salad",
        servings: 3,
        ingredients: [
            "romaine lettuce",
            "Caesar dressing",
            "cheese",
            "Croutons",
            "Salt and pepper"
        ]
    }
];

// Logging all recipes
recipes.forEach(recipe => {
    console.log(`\nTitle: ${recipe.title}`);
    console.log(`Servings: ${recipe.servings}`);
    console.log("Ingredients:");
    recipe.ingredients.forEach(ingredient => console.log(ingredient));
});