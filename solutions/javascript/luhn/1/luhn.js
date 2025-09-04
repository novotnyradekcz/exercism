//
// This is only a SKELETON file for the 'Luhn' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const valid = digitString => {
  let noSpaces = digitString.replace(/\s/g, "")
  if (!(/^\d+$/.test(noSpaces))) {
    return false;
  }
  let sum = 0;
  for (let i = noSpaces.length - 1; i >= 0; i--) {
    if ((i + noSpaces.length) % 2 == 0) {
      sum += 2 * +noSpaces[i];
      if (+noSpaces[i] > 4) {
        sum -= 9;
      }
    } else {
      sum += +noSpaces[i];
    }
  }
  return noSpaces.length > 1 && sum % 10 == 0;
};
