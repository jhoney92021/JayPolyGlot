#include "basic_algorithms.h"

// Shift all array elements left by 1 position, setting the final element to 0
void shift_array_values_left(int arr[], size_t length) {
    if (length == 0) return;
    for (size_t i = 0; i < length - 1; i++) {
        arr[i] = arr[i + 1];
    }
    arr[length - 1] = 0;
}
