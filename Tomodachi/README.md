# Tomodachi (Virtual Pet) - Multi-Stack Implementation Repository

### Quick Links
* [Full Stack Prompts](../Full_Stack_Prompts.md)
* [JayPolyGlot Home](../README.md)

---

## Architecture Overview

This directory contains implementations of the **Tomodachi (Virtual Pet)** application across multiple languages, frameworks, and architectural patterns (from monolithic state machines to separated Full-Stack Backend & Frontend solutions).

```text
Tomodachi/
├── CSharp/
│   ├── Tomodachi.Domain/        # Core C# Domain Library (Pet.cs & rules)
│   ├── Tomodachi.ConsoleApp/    # Interactive CLI Console Runner
│   └── Tomodachi.Tests/         # xUnit Unit Test Suite
└── C/                           # C Language State Machine & Binary Storage
    ├── pet.h / pet.c
    ├── main.c
    └── Makefile
```

---

## 🚀 Running Implementations

### C# Solutions

```bash
# Run the Interactive Console Application
dotnet run --project Tomodachi/CSharp/Tomodachi.ConsoleApp/Tomodachi.ConsoleApp.csproj

# Run the xUnit Unit Test Suite
dotnet test Tomodachi/CSharp/Tomodachi.Tests/Tomodachi.Tests.csproj
```

### C Solutions

```bash
cd Tomodachi/C
make run
```
