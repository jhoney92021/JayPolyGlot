#include "basic_algorithms.h"

// Return a dynamically allocated array containing all odd values from input array
int* find_odd_values(const int arr[], size_t length, size_t *out_size) {
    if (out_size == NULL) {
        return NULL;
    }
    
    size_t odd_count = 0;
    for (size_t i = 0; i < length; i++) {
        if (arr[i] % 2 != 0) {
            odd_count++;
        }
    }
    
    *out_size = odd_count;
    if (odd_count == 0) {
        return NULL;
    }
    
    int *odd_array = (int *)malloc(odd_count * sizeof(int));
    if (odd_array == NULL) {
        *out_size = 0;
        return NULL;
    }
    
    size_t index = 0;
    for (size_t i = 0; i < length; i++) {
        if (arr[i] % 2 != 0) {
            odd_array[index++] = arr[i];
        }
    }
    
    return odd_array;
}
