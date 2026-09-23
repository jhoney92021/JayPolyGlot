#include "basic_algorithms.h"

// Replace any negative values in array with zero
void replace_negatives_with_zero(int arr[], size_t length) {
    for (size_t i = 0; i < length; i++) {
        if (arr[i] < 0) {
            arr[i] = 0;
        }
    }
}
