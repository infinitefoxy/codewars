function doubleChar(str) {
  // Your code here
  return  str.replace(/./g, '$&$&')
}