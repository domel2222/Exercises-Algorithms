function digitSum(array) {
  let numberDetails = {
    value: 0,
    sum: 0,
    position: 0,
  };
  if (array.length == 0) return "No data in array";
  else if (array.length == 1) return numberDetails.position;

  for (const [index, number] of array.entries()) {
    sumDigits(number, numberDetails, index);
  }
  return numberDetails.position;
}

function sumDigits(number, numberDetails, index) {
  sumNumber = 0;
  for (const digit of number.toString()) {
    sumNumber += parseInt(digit);
  }

  return actualizeData(numberDetails, number, index);
}

function actualizeData(numberDetails, number, index) {
  if (sumNumber >= numberDetails.sum && number > numberDetails.value) {
    numberDetails.value = number;
    numberDetails.sum = sumNumber;
    numberDetails.position = index;
  }

  return numberDetails;
}

var result = digitSum([256, 326]);
