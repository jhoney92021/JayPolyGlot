#include "basic_algorithms.h"

// Print each element of an integer array
void iterate_array(const int arr[], size_t length) {
    for (size_t i = 0; i < length; i++) {
        printf("%d ", arr[i]);
    }
    printf("\n");
}

// Helper utility to format and print array contents
void print_array(const int arr[], size_t length) {
    printf("[");
    for (size_t i = 0; i < length; i++) {
        printf("%d%s", arr[i], (i + 1 < length) ? ", " : "");
    }
    printf("]\n");
}
