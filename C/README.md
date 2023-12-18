# jhoney's C notes

### Quick Links

- [Home](../README.md)
- [Basic Algo Prompts](../BasicAlgorithmPromts.md)

### Set Up For Windows

- Get MYSYS2 https://www.msys2.org/
  - Then run `$ pacman -S mingw-w64-ucrt-x86_64-gcc`
  - Verify install with `gcc --version` in whatever CLI you prefer, maybe starting with the MYSYS2
    - If `gcc --version` doesn't bring anything back, you may need to add the binaries (bin) to the windows environment [PATH](../Windows/README.md#adding-to-the-path-windows-11)

# C Primitive Types

In the C programming language, primitive types are the basic building blocks for representing simple data values. They are used to store fundamental data types such as integers, floating-point numbers, characters, and boolean values.

## Numeric Types

### 1. Integer Types

- **char:** Typically 8 bits, used to represent characters.
- **short:** 16-bit signed integer.
- **int:** 32-bit signed integer.
- **long:** 64-bit signed integer.

### 2. Unsigned Integer Types

- **unsigned char:** Typically 8 bits, used for unsigned characters.
- **unsigned short:** 16-bit unsigned integer.
- **unsigned int:** 32-bit unsigned integer.
- **unsigned long:** 64-bit unsigned integer.

### 3. Floating-Point Types

- **float:** Typically 32 bits, single-precision floating-point.
- **double:** Typically 64 bits, double-precision floating-point.
- **long double:** Extended precision floating-point.

## Character Type

- **char:** Typically 8 bits, used to represent characters.

## Boolean Type

- C does not have a built-in boolean type. Instead, integers are commonly used, where 0 represents false, and any non-zero value represents true.

## Example Usage:

```c
// Integer types
int age = 25;
unsigned int count = 100;

// Floating-point types
float pi = 3.14f;
double e = 2.71828;

// Character type
char grade = 'A';

// Boolean using integers
int isStudent = 1; // true
int isWorking = 0; // false
```

<br>
Example:

- Creates an exe
  - gcc (filename).c -o (filename)
    - ex gcc main.c -o main
- Runs file

  - ./(filename)
    - ./main

- idk
  ./(filename) 1024 > outputfile.c

- print f stuff

  - %d: for printing ints
  - %f: for printing floating point numbers
  - %c: for printing chars
  - %s: for printing string
  - %p: for printing memory address ie pointer
  - %x: for printing hexadecimal values

- random notes
  - printf("%c", "\n): printed hearts
