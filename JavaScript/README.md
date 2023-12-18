# jhoney's JavaScript notes

- [Main Notes](../README.md#quick-links)

### Quick Links

- [Home](../README.md)
- [Local CLI app set up](#js_local_cli_set_up)
- [Node CLI Commands](#node_cli_commands)
- [npm CLI Commands](#npm_cli_commands)

### Local CLI app set up

- using local file
  - be sure to "type": "module" to package.json
  - I tend to use import style like this
    - import {PrintTo255_For} from "./BasicAlgorithms/PrintTo255.js"

<a name="js_local_cli_set_up"></a>

### Node CLI Commands

- Node . --runs a project from a package.json
- Node <fileName> -- runs a specific file
  <a name="node_cli_commands"></a>

### Node CLI Commands

- npm init --creats a project with a package.json
  <a name="npm_cli_commands"></a>

# JavaScript Primitive Types

In JavaScript, primitive types are the basic building blocks for representing simple data values. They are used to store fundamental data types such as numbers, strings, booleans, null, and undefined.

## Numeric Types

- **Number:** Represents both integer and floating-point numbers.

## String Type

- **String:** Represents a sequence of characters.

## Boolean Type

- **Boolean:** Represents a boolean value (true or false).

## Special Types

- **null:** Represents the intentional absence of any object value.
- **undefined:** Represents an uninitialized variable or a variable without a value.

## Example Usage:

```javascript
// Numeric types
let age = 25;
let pi = 3.14;

// String type
let name = "John Doe";

// Boolean type
let isStudent = true;
let isWorking = false;

// Special types
let nullValue = null;
let undefinedValue;

console.log(age); // Output: 25
console.log(name); // Output: John Doe
console.log(isStudent); // Output: true
console.log(nullValue); // Output: null
console.log(undefinedValue); // Output: undefined
```
