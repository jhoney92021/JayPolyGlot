#ifndef BASIC_ALGORITHMS_H
#define BASIC_ALGORITHMS_H

#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

// Struct for Min, Max, Average result
typedef struct {
    int min;
    int max;
    double average;
} MinMaxAvg;

// Helper utilities
void print_array(const int arr[], size_t length);

// Basic 13 Algorithm Prototypes
void print_1_to_255(void);
void print_odds_1_to_255(void);
void print_sum_0_to_255(void);
void iterate_array(const int arr[], size_t length);
int find_maximum_value(const int arr[], size_t length);
double find_average_value(const int arr[], size_t length);
int* find_odd_values(const int arr[], size_t length, size_t *out_size);
size_t count_greater_than_y(const int arr[], size_t length, int y);
void square_array_values(int arr[], size_t length);
void replace_negatives_with_zero(int arr[], size_t length);
MinMaxAvg get_min_max_average(const int arr[], size_t length);
void shift_array_values_left(int arr[], size_t length);
void fizz_buzz(int n);

#endif // BASIC_ALGORITHMS_H
