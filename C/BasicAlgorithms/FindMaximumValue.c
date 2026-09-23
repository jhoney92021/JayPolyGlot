#include "basic_algorithms.h"

// Find and return the maximum value in an integer array
int find_maximum_value(const int arr[], size_t length) {
    if (length == 0) {
        return 0; // Fallback for empty array
    }
    int max = arr[0];
    for (size_t i = 1; i < length; i++) {
        if (arr[i] > max) {
            max = arr[i];
        }
    }
    return max;
}
