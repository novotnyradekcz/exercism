//
// This is only a SKELETON file for the 'Scrabble Score' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const score = (str) => {
  let equation = str
    .replace(/[AEIOULNRST]/gi, '+1')
    .replace(/[DG]/gi, '+2')
    .replace(/[BCMP]/gi, '+3')
    .replace(/[FHVWY]/gi, '+4')
    .replace(/[K]/gi, '+5')
    .replace(/[JX]/gi, '+8')
    .replace(/[QZ]/gi, '+10');
  return eval('0' + equation);
};
