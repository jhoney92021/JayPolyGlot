# jhoney's C notes

### Quick Links

- [Home](../README.md)
- [Basic Algo Prompts](../BasicAlgorithmPromts.md)
- [Basic 13 C Suite](./BasicAlgorithms/main.c)
- [Windows Setup Guide](./WINDOWS_SETUP.md)

### Compiling and Running C Basic Algorithms

```bash
cd C/BasicAlgorithms
make run
```

### Windows Environment Setup

For complete step-by-step Windows installation, automated setup scripts (`.ps1`), and one-click build scripts (`.bat`), see the dedicated [Windows Setup Guide](./WINDOWS_SETUP.md).

- **Automated Setup Script**: `powershell .\scripts\setup-windows.ps1`
- **One-Click Runner**: `.\scripts\build-and-run.bat`

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
