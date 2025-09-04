//
// This is only a SKELETON file for the 'Acronym' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const parse = phrase => {
  let noUnderscores = phrase.replace('_', '').replace('-', ' ');
  let letters = noUnderscores.match(/(^|\s)\w/g);
  return letters.join('').replace(/\s/g, '').toUpperCase();
};
