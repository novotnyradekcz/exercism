//
// This is only a SKELETON file for the 'Parallel Letter Frequency' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const parallelLetterFrequency = (texts) => {
  let frequencies = {}
  Promise.all(texts.map((text) => getFrequency(frequencies, text)));
  return frequencies;
};

const getFrequency = (frequencies, text) => {
  return new Promise((resolve) => {
    for (const [letter] of text.toLowerCase().match(/\p{Letter}/gu) || [])
      frequencies[letter] = (frequencies[letter] || 0) + 1;
    resolve(frequencies);
  });
};