#include <iostream>
#include <cmath>
using namespace std;
namespace Triangle
{
  long int isTriangle(long a, long b, long c)
  {
    
      

  if (a+b > c && a+c > b && b+c > a )

    return true;

    else

    return false;

    
    
    }
  
};