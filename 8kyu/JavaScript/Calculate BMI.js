function bmi(weight, height) {
  
  var bmi = weight / height / height;
  
  if ( bmi <= 18.5)
  {
    x = 'Underweight';
  }
  else if ( bmi <= 25.0 ) 
  {
    x = 'Normal';
  }
  else if (bmi <= 30.0) 
  {
    x = 'Overweight';
  }
  else
  {
    x = 'Obese';
  }
    
  return x;
}