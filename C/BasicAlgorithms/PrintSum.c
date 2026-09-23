#include "basic_algorithms.h"

// Print numbers from 0 to 255 along with the cumulative sum
void print_sum_0_to_255(void) {
    long sum = 0;
    for (int i = 0; i <= 255; i++) {
        sum += i;
        printf("New number: %d Sum: %ld\n", i, sum);
    }
}
