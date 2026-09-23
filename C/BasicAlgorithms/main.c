#include "basic_algorithms.h"

int main(void) {
    printf("=========================================\n");
    printf("   C Basic 13 Algorithms Demo & Harness  \n");
    printf("=========================================\n\n");

    printf("--- 1. Print 1 to 255 ---\n");
    print_1_to_255();

    printf("\n--- 2. Print Odds 1 to 255 ---\n");
    print_odds_1_to_255();

    printf("\n--- 3. Print Sum 0 to 255 ---\n");
    print_sum_0_to_255();

    printf("\n--- 4. Iterate Array ---\n");
    int sample_arr[] = {1, 3, 5, 7, 9, 11};
    size_t sample_len = sizeof(sample_arr) / sizeof(sample_arr[0]);
    iterate_array(sample_arr, sample_len);

    printf("\n--- 5. Find Maximum Value ---\n");
    int max_val = find_maximum_value(sample_arr, sample_len);
    printf("Max value of sample_arr: %d\n", max_val);

    printf("\n--- 6. Find Average Value ---\n");
    double avg_val = find_average_value(sample_arr, sample_len);
    printf("Average value of sample_arr: %.2f\n", avg_val);

    printf("\n--- 7. Find Odd Values (Dynamic Allocation) ---\n");
    int mixed_arr[] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    size_t mixed_len = sizeof(mixed_arr) / sizeof(mixed_arr[0]);
    size_t odd_count = 0;
    int *odds = find_odd_values(mixed_arr, mixed_len, &odd_count);
    printf("Odd values count: %zu -> ", odd_count);
    print_array(odds, odd_count);
    free(odds); // Clean up dynamically allocated array

    printf("\n--- 8. Find Greater Than Y Values ---\n");
    size_t count_gt_y = count_greater_than_y(mixed_arr, mixed_len, 5);
    printf("Elements in mixed_arr > 5: %zu\n", count_gt_y);

    printf("\n--- 9. Square Array Values ---\n");
    int square_arr[] = {1, 2, 3, 4, 5};
    size_t square_len = sizeof(square_arr) / sizeof(square_arr[0]);
    printf("Before: ");
    print_array(square_arr, square_len);
    square_array_values(square_arr, square_len);
    printf("After:  ");
    print_array(square_arr, square_len);

    printf("\n--- 10. Replace Negatives with Zero ---\n");
    int neg_arr[] = {-1, 5, -3, 8, -10, 2};
    size_t neg_len = sizeof(neg_arr) / sizeof(neg_arr[0]);
    printf("Before: ");
    print_array(neg_arr, neg_len);
    replace_negatives_with_zero(neg_arr, neg_len);
    printf("After:  ");
    print_array(neg_arr, neg_len);

    printf("\n--- 11. Get Min, Max, Average Struct ---\n");
    MinMaxAvg result = get_min_max_average(mixed_arr, mixed_len);
    printf("Min: %d, Max: %d, Average: %.2f\n", result.min, result.max, result.average);

    printf("\n--- 12. Shift Array Values Left ---\n");
    int shift_arr[] = {1, 5, 10, 7, -2};
    size_t shift_len = sizeof(shift_arr) / sizeof(shift_arr[0]);
    printf("Before: ");
    print_array(shift_arr, shift_len);
    shift_array_values_left(shift_arr, shift_len);
    printf("After:  ");
    print_array(shift_arr, shift_len);

    printf("\n--- 13. FizzBuzz (n=30) ---\n");
    fizz_buzz(30);

    printf("\n=========================================\n");
    printf("   All C Basic 13 Algorithms Executed!   \n");
    printf("=========================================\n");

    return 0;
}
