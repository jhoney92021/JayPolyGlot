# Tomodachi (Virtual Pet) - C# Solution

### Quick Links
* [Full Stack Prompts](../../Full_Stack_Prompts.md)
* [CSharp Home](../README.md)

---

## Overview

This project implements the **Tomodachi (Virtual Pet)** domain model and state machine in C# .NET 10.

### Domain Capabilities
- **State Meters**: `Hunger` (0-100), `Happiness` (0-100), `Energy` (0-100).
- **Actions**: `Feed()`, `Play()`, `Sleep()`, `WakeUp()`.
- **Time Progression**: `Tick()` updates pet stats asynchronously, handling sleep recovery, hunger decay, sickness, and mortality.

---

## Compiling & Running

```bash
cd CSharp/Tomodachi
dotnet run
```

## Running Unit Tests

```bash
cd CSharp/Tomodachi.Tests
dotnet test
```
