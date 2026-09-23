#include "basic_algorithms.h"

// Calculate and return Min, Max, and Average of array in a MinMaxAvg struct
MinMaxAvg get_min_max_average(const int arr[], size_t length) {
    MinMaxAvg result = { .min = 0, .max = 0, .average = 0.0 };
    if (length == 0) {
        return result;
    }
    
    int min = arr[0];
    int max = arr[0];
    double sum = arr[0];
    
    for (size_t i = 1; i < length; i++) {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
        sum += arr[i];
    }
    
    result.min = min;
    result.max = max;
    result.average = sum / (double)length;
    return result;
}
