#include "basic_algorithms.h"

// Print odd integers from 1 to 255
void print_odds_1_to_255(void) {
    for (int i = 1; i <= 255; i += 2) {
        printf("%d ", i);
    }
    printf("\n");
}
