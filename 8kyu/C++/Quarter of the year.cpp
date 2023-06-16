#include <math.h>

const float NUM_MONTHS_PER_QUARTER = 3.0f;

int quarter_of(int month){
  return ceil(month / NUM_MONTHS_PER_QUARTER);
}