//
// This is only a SKELETON file for the 'Reverse String' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const reverseString = word => {
  let reversedWord = "";
  for (let i = 0; i < word.length; i++) {
    reversedWord = word[i] + reversedWord;
  }
  return reversedWord;
};
