#include "basic_algorithms.h"

// Calculate and return the average of array elements
double find_average_value(const int arr[], size_t length) {
    if (length == 0) {
        return 0.0;
    }
    double sum = 0.0;
    for (size_t i = 0; i < length; i++) {
        sum += arr[i];
    }
    return sum / (double)length;
}
