#include "basic_algorithms.h"

// Print 1 to n replacing multiples of 3 with Fizz, 5 with Buzz, 15 with FizzBuzz
void fizz_buzz(int n) {
    for (int i = 1; i <= n; i++) {
        if (i % 15 == 0) {
            printf("FizzBuzz ");
        } else if (i % 3 == 0) {
            printf("Fizz ");
        } else if (i % 5 == 0) {
            printf("Buzz ");
        } else {
            printf("%d ", i);
        }
    }
    printf("\n");
}
