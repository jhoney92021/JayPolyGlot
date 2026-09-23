#include "basic_algorithms.h"

// Square array values in-place
void square_array_values(int arr[], size_t length) {
    for (size_t i = 0; i < length; i++) {
        arr[i] = arr[i] * arr[i];
    }
}
