/// <reference path="./global.d.ts" />
// @ts-check

 export function cookingStatus(remainingTime) {
   if (remainingTime == undefined) {
     return "You forgot to set the timer."
   } else if (remainingTime == 0) {
     return "Lasagna is done.";
   } else {
     return "Not done, please wait."
   }
 }

export function preparationTime(layers, timePerLayer = 2) {
  return layers.length * timePerLayer;
}

export function quantities(layers) {
  let noodles = 0;
  let sauce = 0;
  for (const layer of layers) {
    if (layer == 'noodles') {
      noodles += 50;
    } else if (layer == 'sauce') {
      sauce += 0.2;
    }
  }
  return { 'noodles': noodles, 'sauce': sauce };
}

export function addSecretIngredient(friendsList, myList) {
  myList.push(friendsList[friendsList.length - 1]);
}

export function scaleRecipe(recipe, portions) {
  let scaledRecipe = structuredClone(recipe);
  for (const [key, value] of Object.entries(scaledRecipe)) {
    scaledRecipe[key] = portions / 2 * value;
  }
  return scaledRecipe;
}
