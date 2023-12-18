# jhoney's Cpp notes #

### Quick Links ###
* [Home](../README.md)
* [Basic Algo Prompts](../BasicAlgorithmPromts.md)

### Set Up For Windows ###
* Get MYSYS2 https://www.msys2.org/
    - Then run  `$ pacman -S mingw-w64-ucrt-x86_64-gcc`
    - Verify install with `gcc --version` in whatever CLI you prefer, maybe starting with the MYSYS2
        - If  `gcc --version` doesn't bring anything back, you may need to add the binaries (bin) to the windows environment [PATH](../Windows/README.md#adding-to-the-path-windows-11)

# C++ Primitive Types

In C++, primitive types are the basic building blocks for representing simple data values. C++ inherits the fundamental data types from the C language and extends them with additional features.

## Numeric Types

### 1. Integer Types

- **char:** Typically 8 bits, used to represent characters.
- **short:** 16-bit signed integer.
- **int:** 32-bit signed integer.
- **long:** 32 or 64 bits, depending on the system.
- **long long:** 64-bit signed integer.

### 2. Unsigned Integer Types

- **unsigned char:** Typically 8 bits, used for unsigned characters.
- **unsigned short:** 16-bit unsigned integer.
- **unsigned int:** 32-bit unsigned integer.
- **unsigned long:** 32 or 64 bits, depending on the system.
- **unsigned long long:** 64-bit unsigned integer.

### 3. Floating-Point Types

- **float:** Typically 32 bits, single-precision floating-point.
- **double:** Typically 64 bits, double-precision floating-point.
- **long double:** Extended precision floating-point.

## Character Type

- **char:** Typically 8 bits, used to represent characters.

## Boolean Type

- **bool:** Represents a boolean value (true or false).

## Example Usage:

```cpp
// Integer types
int age = 25;
unsigned int count = 100;

// Floating-point types
float pi = 3.14f;
double e = 2.71828;

// Character type
char grade = 'A';

// Boolean type
bool isStudent = true;
``````