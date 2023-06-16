function createPhoneNumber(numbers){
    

  
  var x = numbers.toString().slice(0, 5).replaceAll(",", "");
  
  
  var y = numbers.toString().slice(6, 12).replaceAll(",", "");
  
  var z = numbers.toString().slice(12, 21).replaceAll(",", "");
  
  return "(" + x + ") " + y + "-" + z;
//console.log(numbers.toString().substring(3));
  
}