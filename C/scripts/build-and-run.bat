@echo off
rem =========================================================
rem   Windows One-Click Build & Run Script for C Algorithms
rem =========================================================

echo Building C BasicAlgorithms Suite...
echo.

cd /d "%~dp0..\BasicAlgorithms"

rem Check if make is available
where mingw32-make >nul 2>nul
if %ERRORLEVEL% equ 0 (
    mingw32-make run
    goto end
)

where make >nul 2>nul
if %ERRORLEVEL% equ 0 (
    make run
    goto end
)

rem Fallback to direct GCC compilation
where gcc >nul 2>nul
if %ERRORLEVEL% neq 0 (
    echo [ERROR] GCC is not detected in your PATH.
    echo Please run scripts\setup-windows.ps1 or add C:\msys64\ucrt64\bin to your PATH.
    pause
    exit /b 1
)

echo [INFO] Compiling C source files using GCC directly...
gcc -Wall -Wextra -std=c11 -O2 -o runner.exe PrintTo255.c PrintOddsTo255.c PrintSum.c IterateArray.c FindMaximumValue.c FindAverageValue.c FindOddValues.c FindGreaterThanYValues.c SquareArrayValues.c AbsoluteValues.c GetMinMaxAverageValues.c ShiftArray.c FizzBuzz.c main.c

if %ERRORLEVEL% neq 0 (
    echo [ERROR] Build failed!
    pause
    exit /b 1
)

echo [SUCCESS] Build completed successfully! Executing runner...
echo =========================================================
runner.exe
echo =========================================================

:end
pause
