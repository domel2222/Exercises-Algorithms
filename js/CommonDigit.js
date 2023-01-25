function commonDigit(array) {
  let digitCounter = {};

  for (const item of array) {
    for (const digit of item.toString()) {
      CreateDigitCounter(digitCounter, digit);
    }
  }
  return GetHighestKey(digitCounter);
}

function CreateDigitCounter(digitCounter, digit) {
  if (digitCounter.hasOwnProperty(digit)) {
    digitCounter[digit]++;
  } else {
    digitCounter[digit] = 1;
  }
}

function GetHighestKey(objectCounter) {
  let highestKey = Number.MIN_SAFE_INTEGER;
  let highestValue = 0;

  for (const key in objectCounter) {
    if (objectCounter[key] >= highestValue && parseInt(key) > highestKey) {
      highestValue = objectCounter[key];
      highestKey = key;
    }
  }
  return highestKey;
}

const result = commonDigit([111, 222, 5555, 12]);

console.log(result);
