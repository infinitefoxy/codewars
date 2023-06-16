#include <cmath>
using namespace std;
  
  
bool approx_equals(double a, double b, double epsilon = 0.001) {

   if(fabs(a - b) < epsilon)
      return true; 
      return false; 
}