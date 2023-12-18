# jhoney's VB notes #

### Quick Links ###
* [Home](../README.md)

### DotNet CLI Commands ###
* dotnet new console --language vb -- creates new vb project
* dotnet run   --runs a project
* dotnet clean  --cleans a project
* dotnet build  --builds a project (there are options for verbosity like -v d[etailed])
* dotnet watch run --runs a project while also listening for changes to files (can edit code while in a persistant run mode)
<a name="dotnet_cli_commands"></a>

# Visual Basic (VB.NET) Primitive Types

In Visual Basic (VB.NET), primitive types are the basic building blocks for representing simple data values. They are used to store fundamental data types such as integers, floating-point numbers, characters, and boolean values.

## Numeric Types

### 1. Integer Types

- **Byte:** 8-bit unsigned integer.
- **Short:** 16-bit signed integer.
- **Integer:** 32-bit signed integer.
- **Long:** 64-bit signed integer.

### 2. Floating-Point Types

- **Single:** 32-bit single-precision floating-point.
- **Double:** 64-bit double-precision floating-point.
- **Decimal:** 128-bit precise decimal number.

## Character Type

- **Char:** 16-bit Unicode character.

## Boolean Type

- **Boolean:** Represents a boolean value (True or False).

## Example Usage:

```vb.net
' Integer types
Dim age As Integer = 25
Dim count As UInteger = 100

' Floating-point types
Dim pi As Single = 3.14F
Dim e As Double = 2.71828

' Character type
Dim grade As Char = "A"c

' Boolean type
Dim isStudent As Boolean = True
Dim isWorking As Boolean = False
``````