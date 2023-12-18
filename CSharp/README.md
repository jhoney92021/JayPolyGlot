# jhoney's CSharp notes #

### Quick Links ###
* [Home](../README.md)
* [Linq Basics](./LinqBasics/README.md)
* [Loops](./Documentation/Loops.md)
* [DotNet CLI Commands](#dotnet_cli_commands)
* [DotNet Version Notes](#dotnet_version_notes)

### DotNet CLI Commands ###
* dotnet run   --runs a project
* dotnet clean  --cleans a project
* dotnet build  --builds a project (there are options for verbosity like -v d[etailed])
* dotnet watch run --runs a project while also listening for changes to files (can edit code while in a persistant run mode)
<a name="dotnet_cli_commands"></a>

### DotNet Version Notes ###
* file scoped namespaces is a recent inclusion to C# -v 10 and DotNet -v 6.0
    - see https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-10.0/file-scoped-namespaces
<a name="dotnet_version_notes"></a>

# C# Primitive Types

In C#, primitive types are the basic building blocks for representing simple data values. They are used to store fundamental data types such as integers, floating-point numbers, characters, and boolean values.

## Numeric Types

### 1. Integer Types

- **sbyte:** 8-bit signed integer.
- **byte:** 8-bit unsigned integer.
- **short:** 16-bit signed integer.
- **ushort:** 16-bit unsigned integer.
- **int:** 32-bit signed integer.
- **uint:** 32-bit unsigned integer.
- **long:** 64-bit signed integer.
- **ulong:** 64-bit unsigned integer.

### 2. Floating-Point Types

- **float:** 32-bit floating-point number.
- **double:** 64-bit floating-point number.
- **decimal:** 128-bit precise decimal number.

## Character Type

- **char:** 16-bit Unicode character.

## Boolean Type

- **bool:** Represents a boolean value (true or false).

## Example Usage:

```csharp
// Integer types
int age = 25;
byte byteValue = 200;

// Floating-point types
float floatValue = 3.14f;
double doubleValue = 2.71828;

// Character type
char grade = 'A';

// Boolean type
bool isStudent = true;
``````
