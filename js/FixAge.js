function fixAge(arr) {
  const min = 18;
  const max = 60;
  let result = "";

  for (const element of arr) {
    if (element >= min && element <= max) {
      result += element + ",";
    }
  }
  return result.length > 0 ? result.slice(0, -1) : "NA";
}

const methodResult = fixAge([18, 68, 23, 58, 45, 3, 65, 34]);
