# jhoney's TypeScript notes

- [Main Notes](../README.md#quick-links)

### install

- npm install -g typescript

### Quick Links

- [Home](../README.md)
- [Local CLI app set up](#js_local_cli_set_up)
- [ts-node CLI Commands](#ts-node_cli_commands)
- [npm CLI Commands](#npm_cli_commands)

### Local CLI app set up

- using local file
  - be sure to "type": "module" to package.json
  - I tend to use import style like this
    - import {PrintTo255_For} from "./BasicAlgorithms/PrintTo255.js"

<a name="js_local_cli_set_up"></a>

### ts-node CLI Commands

- tsc <filename> --compiles a ts file to js
- ts-node . --runs a project from a package.json
- ts-node <fileName> -- runs a specific file
  <a name="ts-node_cli_commands"></a>

### Node CLI Commands

- npm init --creats a project with a package.json
  <a name="npm_cli_commands"></a>

# TypeScript Primitive Types

In TypeScript, primitive types are the basic building blocks for representing simple data values. TypeScript is a superset of JavaScript, so it inherits JavaScript's primitive types and adds some additional features.

## Numeric Types

### 1. Integer Types

- **number:** Represents both integer and floating-point numbers.

## String Type

- **string:** Represents a sequence of characters.

## Boolean Type

- **boolean:** Represents a boolean value (true or false).

## Special Types

- **null:** Represents the intentional absence of any object value.
- **undefined:** Represents an uninitialized variable or a variable without a value.

## Additional Types

- **enum:** Represents a set of named constant values.
- **any:** Represents any data type. This is often used when the type is not known during development.
- **void:** Represents the absence of a type. Typically used as the return type for functions that do not return a value.

## Example Usage:

```typescript
// Numeric types
let age: number = 25;
let pi: number = 3.14;

// String type
let name: string = "John Doe";

// Boolean type
let isStudent: boolean = true;
let isWorking: boolean = false;

// Special types
let nullValue: null = null;
let undefinedValue: undefined;

// Additional types
enum DaysOfWeek {
  Monday,
  Tuesday,
  Wednesday,
  Thursday,
  Friday,
  Saturday,
  Sunday,
}

let today: DaysOfWeek = DaysOfWeek.Wednesday;

function logMessage(): void {
  console.log("This function does not return a value.");
}

console.log(age); // Output: 25
console.log(name); // Output: John Doe
console.log(isStudent); // Output: true
console.log(nullValue); // Output: null
console.log(undefinedValue); // Output: undefined
console.log(today); // Output: 2 (Wednesday)
logMessage(); // Output: This function does not return a value.
```
