function optionalPow(a, b) {
  const confirm = window.confirm(
    "Do you agree with raising " + a + " to the power of " + b + "?"
  );

  if (confirm) {
    result = Math.pow(a, b);
  } else {
    result = Math.pow(b, a);
  }
  const resultWindow = window.open();
  resultWindow.document.write(result);
}

optionalPow(5, 7);
