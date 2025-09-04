// @ts-check

/**
 * Calculates the sum of the two input arrays.
 *
 * @param {number[]} array1
 * @param {number[]} array2
 * @returns {number} sum of the two arrays
 */
export function twoSum(array1, array2) {
  let num1 = "";
  for (const digit of array1) {
    num1 += digit;
  }
  let num2 = "";
  for (const digit of array2) {
    num2 += digit;
  }
  return Number(num1) + Number(num2);
}

/**
 * Checks whether a number is a palindrome.
 *
 * @param {number} value
 * @returns {boolean} whether the number is a palindrome or not
 */
export function luckyNumber(value) {
  let stringValue = String(value)
  let valueLength = stringValue.length
  for (let i = 0; i < Math.floor(stringValue.length / 2); i++) {
    if (stringValue[i] != stringValue[valueLength - i - 1]) {
      return false;
    }
  }
  return true;
}

/**
 * Determines the error message that should be shown to the user
 * for the given input value.
 *
 * @param {string|null|undefined} input
 * @returns {string} error message
 */
export function errorMessage(input) {
  if (input == "" || input == null || input == undefined) {
    return "Required field";
  } else if (Number(input) == 0 || isNaN(Number(input))) {
    return "Must be a number besides 0";
  } else {
    return "";
  }
}
