int square_digits(int num) {
  
 int total = 0;
  int mul = 1;
  
  while(num) {
    int d = num % 10;
    total += d * d * mul;
    mul *= (d > 3 ? 100 : 10);
    num /= 10;
  }
  
  return total;
}