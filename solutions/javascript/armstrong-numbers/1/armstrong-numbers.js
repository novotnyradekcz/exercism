//
// This is only a SKELETON file for the 'Armstrong Numbers' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const isArmstrongNumber = number => {
  let stringNumber = number.toString()
  let result = 0
  for (let digit of stringNumber) {
    result += digit ** stringNumber.length
  }
  return result == number
};
