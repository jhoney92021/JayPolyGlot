#include <stdio.h>
// Define ANSI escape codes for text color
#define RED_TEXT "\033[1;31m"
#define GREEN_TEXT "\033[1;32m"
#define YELLOW_TEXT "\033[1;33m"
#define BLUE_TEXT "\033[1;34m"
#define MAGENTA_TEXT "\033[1;35m"
#define CYAN_TEXT "\033[1;36m"
#define WHITE_TEXT "\033[1;37m"
#define RESET_TEXT "\033[0m"
// Function to print a new line
void printNewLine()
{
    printf("\n");
}
// Function to print text with color and formatting
void printIntWithColor(const char *text, const int *value, const char *color)
{
    // If color is NULL, default to GREEN_TEXT
    if (color == NULL)
    {
        color = GREEN_TEXT;
    }
    printf("%s~~~ %s %d ~~~%s\n", color, text, value, RESET_TEXT);
}
// Function to print text with color and formatting
void printWithColor(const char *text, const char *color)
{
    // If color is NULL, default to GREEN_TEXT
    if (color == NULL)
    {
        color = GREEN_TEXT;
    }
    printf("%s~~~ %s ~~~%s\n", color, text, RESET_TEXT);
}
// Function to print the array
void printArray(int size, int intArr[])
{
    printWithColor("Print Array", GREEN_TEXT);
    for (int i = 0; i < size; i++)
    {
        printf("%d", intArr[i]);
        printNewLine();
    }
}
// Function to print the maximum value in the array
void printMaxArray(int size, int intArr[])
{
    printWithColor("Print Max Array", GREEN_TEXT);
    int max = intArr[0];
    for (int i = 0; i < size; i++)
    {
        if (max < intArr[i])
        {
            max = intArr[i];
        }
    }
    printf("~~~ max ~~~\n%d\n", max);
}
// Function to print the average value of the array
void printAvgArray(int size, int intArr[])
{
    int sum = intArr[0];
    for (int i = 1; i < size; i++)
    {
        sum += intArr[i];
    }
    int average = sum / size;
    // Use RED_TEXT for the "average" message
    printIntWithColor("Print Avg Array", average, RED_TEXT);
}
int *findOddValues_For(int integerArray[], int arrayLength, int *resultSize)
{
    int *oddArray = NULL;
    int oddCount = 0;
    // Count the number of odd values in the input array
    for (int iterator = 0; iterator < arrayLength; iterator++)
    {
        if (integerArray[iterator] % 2 == 1)
        {
            oddCount++;
        }
    }
    // Allocate memory for the result array
    oddArray = (int *)malloc(oddCount * sizeof(int));
    if (oddArray == NULL)
    {
        // Handle memory allocation failure
        *resultSize = 0;
        return NULL;
    }
    // Fill the result array with odd values
    int resultIndex = 0;
    for (int iterator = 0; iterator < arrayLength; iterator++)
    {
        if (integerArray[iterator] % 2 == 1)
        {
            oddArray[resultIndex++] = integerArray[iterator];
        }
    }
    // Set the result size
    *resultSize = oddCount;
    // Print the result array for validation
    printf("~~~ To Odd Array -- For Loop -- Values: ");
    for (int i = 0; i < oddCount; i++)
    {
        printf("%d ", oddArray[i]);
    }
    printf("~~~\n");
    return oddArray;
}
int main()
{
    // printWithColor("1 - 255", MAGENTA_TEXT);
    int numArr[4] = {1, 4453, 67, 5};
    // printArray(4, numArr);
    // printMaxArray(4, numArr);
    printAvgArray(4, numArr);
    printWithColor("Find Max Value", CYAN_TEXT);
    int inputArray[] = {1, 12, 3, 4, 6};
    int arrayLength = sizeof(inputArray) / sizeof(inputArray[0]);
    // Variables to store the result array and its size
    int *resultArray;
    int resultSize;
    // Call the function to find odd values
    resultArray = findOddValues_For(inputArray, arrayLength, &resultSize);
    // Free the dynamically allocated memory
    free(resultArray);
    return 0;
}