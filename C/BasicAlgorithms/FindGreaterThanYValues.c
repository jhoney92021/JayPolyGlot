#include "basic_algorithms.h"

// Count elements in array strictly greater than y
size_t count_greater_than_y(const int arr[], size_t length, int y) {
    size_t count = 0;
    for (size_t i = 0; i < length; i++) {
        if (arr[i] > y) {
            count++;
        }
    }
    return count;
}
