# jhoney's rust notes

### Quick Links

- [Home](../README.md)

## installation

- just go here https://www.rust-lang.org/tools/install

## hello world

- https://doc.rust-lang.org/book/ch01-02-hello-world.html

## cli commands

- works kinda like Java/C build then run, unless using Cargo

  - to run with cargo first build like rustc main.rs
  - then ./main to run

- with cargo you can

  - cargo build
  - cargo run

  - cargo add
    - adds a dependancy to project
  - cargo install

    - installs a module to a project

    # Rust Primitive Types

In Rust, primitive types are the basic building blocks for representing simple data values. Rust is known for its strong static typing system, where variable types are explicitly declared at compile time.

## Numeric Types

### 1. Integer Types

- **i8:** 8-bit signed integer.
- **i16:** 16-bit signed integer.
- **i32:** 32-bit signed integer.
- **i64:** 64-bit signed integer.

- **u8:** 8-bit unsigned integer.
- **u16:** 16-bit unsigned integer.
- **u32:** 32-bit unsigned integer.
- **u64:** 64-bit unsigned integer.

### 2. Floating-Point Types

- **f32:** 32-bit floating-point number.
- **f64:** 64-bit floating-point number.

## Character Type

- **char:** Represents a Unicode character.

## Boolean Type

- **bool:** Represents boolean values (true or false).

## Example Usage:

```rust
// Numeric types
let age: i32 = 25;
let pi: f64 = 3.14;

// Character type
let grade: char = 'A';

// Boolean type
let is_student: bool = true;
let is_working: bool = false;

println!("Age: {}", age);
println!("Grade: {}", grade);
println!("Is Student: {}", is_student);
```
