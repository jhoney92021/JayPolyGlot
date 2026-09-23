# C Development Environment Setup Guide for Windows

This document provides complete instructions for setting up a modern C development environment (GCC / Clang / MSVC) on Windows 10/11, building the **JayPolyGlot C Suite**, and running the basic algorithm routines.

---

## ⚡ Quick Start: Automated Setup & One-Click Runner

### 1. Automated Toolchain Installation (PowerShell)
Open a **PowerShell** prompt and execute the automated setup script:

```powershell
# Run from the JayPolyGlot/C directory
Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass
.\scripts\setup-windows.ps1
```

> **What it does**: Checks if `gcc` is present. If missing, it installs **MSYS2** via `winget`, installs the **MinGW-w64 UCRT64 GCC** toolchain and `make`, and provides PATH configuration instructions.

### 2. One-Click Build & Run (Batch Script)
To compile and execute the complete C Basic 13 suite in double-click mode or from Command Prompt:

```cmd
.\scripts\build-and-run.bat
```

---

## 🛠️ Option 1: Manual MSYS2 + MinGW-w64 UCRT64 (Recommended)

MSYS2 provides a native Windows environment with the latest GCC toolchain (`mingw-w64-ucrt-x86_64-gcc`).

### Step 1: Install MSYS2
1. Download the installer from [msys2.org](https://www.msys2.org/) or install via winget:
   ```cmd
   winget install MSYS2.MSYS2
   ```
2. Complete the installation wizard (default directory: `C:\msys64`).

### Step 2: Install GCC and Make
Open **MSYS2 UCRT64** terminal from the Start Menu (or run `C:\msys64\ucrt64.exe`) and run:
```bash
pacman -Sy --noconfirm mingw-w64-ucrt-x86_64-gcc mingw-w64-ucrt-x86_64-make make
```

### Step 3: Add to Windows PATH
To use `gcc` and `make` from PowerShell, Command Prompt, or VS Code:
1. Press `Win + R`, type `sysdm.cpl`, press Enter.
2. Go to **Advanced** tab -> **Environment Variables**.
3. Under **User Variables**, select `Path` and click **Edit**.
4. Click **New** and add:
   ```text
   C:\msys64\ucrt64\bin
   ```
5. Click **OK** on all dialogs and restart your open terminal windows.

### Step 4: Verify Installation
Open PowerShell or Command Prompt:
```powershell
gcc --version
make --version
```

### Step 5: Build and Run
```cmd
cd C\BasicAlgorithms
make run
```

---

## 🐧 Option 2: Windows Subsystem for Linux (WSL)

WSL allows running native Linux GCC directly on Windows with full Linux syscall compatibility.

### Step 1: Install WSL (Ubuntu)
Open PowerShell as Administrator:
```powershell
wsl --install
```
Restart your PC when prompted, then launch Ubuntu.

### Step 2: Install Build Essentials
Inside the WSL Linux terminal:
```bash
sudo apt update && sudo apt install -y build-essential make
```

### Step 3: Build & Run in WSL
Navigate to your Windows files (mounted at `/mnt/c/`):
```bash
cd /mnt/c/path/to/JayPolyGlot/C/BasicAlgorithms
make run
```

---

## 💼 Option 3: Visual Studio / MSVC (`cl.exe`)

If you have Visual Studio installed (with *Desktop development with C++* workload):

1. Open **Developer Command Prompt for VS 2022** (or **x64 Native Tools Command Prompt**).
2. Navigate to `JayPolyGlot\C\BasicAlgorithms`.
3. Compile using Microsoft C Compiler (`cl.exe`):
   ```cmd
   cl /W4 /std:c11 /Fe:runner.exe PrintTo255.c PrintOddsTo255.c PrintSum.c IterateArray.c FindMaximumValue.c FindAverageValue.c FindOddValues.c FindGreaterThanYValues.c SquareArrayValues.c AbsoluteValues.c GetMinMaxAverageValues.c ShiftArray.c FizzBuzz.c main.c
   ```
4. Run the executable:
   ```cmd
   runner.exe
   ```

---

## ❓ Troubleshooting

| Issue | Cause | Solution |
| :--- | :--- | :--- |
| `'gcc' is not recognized as an internal or external command` | PATH environment variable missing MinGW directory | Add `C:\msys64\ucrt64\bin` to PATH and restart terminal. |
| `'make' is not recognized` | `make` or `mingw32-make` package not installed | In MSYS2 terminal run `pacman -S mingw-w64-ucrt-x86_64-make make`. |
| Script execution disabled in PowerShell | PowerShell script execution policy restricting `.ps1` files | Run `Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass` before running setup. |
