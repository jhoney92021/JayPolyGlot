# PowerShell Setup Script for C Development on Windows
# Installs GCC via MSYS2 / MinGW-w64 UCRT64 toolchain

$ErrorActionPreference = "Stop"

Write-Host "=================================================" -ForegroundColor Cyan
Write-Host "   Windows C Environment Setup Script (MinGW)    " -ForegroundColor Cyan
Write-Host "=================================================" -ForegroundColor Cyan
Write-Host ""

# 1. Check if GCC is already installed and in PATH
try {
    $gccVersion = gcc --version 2>$null
    if ($gccVersion) {
        Write-Host "[+] GCC is already installed and available in PATH:" -ForegroundColor Green
        Write-Host ($gccVersion | Select-Object -First 1) -ForegroundColor Yellow
        Write-Host ""
        Write-Host "Setup complete! You can run 'make run' or compile using gcc." -ForegroundColor Green
        exit 0
    }
} catch {
    # GCC not found, proceed with setup
}

Write-Host "[!] GCC not detected in PATH. Starting automated toolchain setup..." -ForegroundColor Yellow

# 2. Check for winget
$winget = Get-Command winget -ErrorAction SilentlyContinue
if (-not $winget) {
    Write-Host "[X] 'winget' (Windows Package Manager) not found." -ForegroundColor Red
    Write-Host "    Please install MSYS2 manually from https://www.msys2.org/" -ForegroundColor Yellow
    exit 1
}

# 3. Install MSYS2 via winget if not present
if (-not (Test-Path "C:\msys64")) {
    Write-Host "[*] Installing MSYS2 via winget..." -ForegroundColor Cyan
    winget install MSYS2.MSYS2 --accept-package-agreements --accept-source-agreements
} else {
    Write-Host "[+] MSYS2 detected at C:\msys64" -ForegroundColor Green
}

# 4. Install GCC & Make via MSYS2 pacman
$msysBash = "C:\msys64\usr\bin\bash.exe"
if (Test-Path $msysBash) {
    Write-Host "[*] Installing MinGW-w64 UCRT64 GCC & Make..." -ForegroundColor Cyan
    & $msysBash -lc "pacman -Sy --noconfirm mingw-w64-ucrt-x86_64-gcc mingw-w64-ucrt-x86_64-make make"
} else {
    Write-Host "[X] MSYS2 bash not found at C:\msys64\usr\bin\bash.exe" -ForegroundColor Red
    exit 1
}

# 5. Environment PATH guidance
$ucrtPath = "C:\msys64\ucrt64\bin"
Write-Host ""
Write-Host "=================================================" -ForegroundColor Green
Write-Host "   Installation Complete!                        " -ForegroundColor Green
Write-Host "=================================================" -ForegroundColor Green
Write-Host "Toolchain installed at: $ucrtPath" -ForegroundColor Yellow
Write-Host ""
Write-Host "To make 'gcc' and 'make' available in any Terminal window:"
Write-Host "  1. Press Win + R, type 'sysdm.cpl', press Enter."
Write-Host "  2. Go to Advanced -> Environment Variables."
Write-Host "  3. Select 'Path' under User Variables, click Edit."
Write-Host "  4. Click New, paste: C:\msys64\ucrt64\bin"
Write-Host "  5. Click OK and restart your terminal."
Write-Host ""
