# .NET SDK (C#) Development Environment Setup Guide for Linux

This document provides complete instructions for setting up the **.NET SDK** (C#) environment on Linux distributions (CachyOS, Arch, Ubuntu, Debian, Fedora), building the **JayPolyGlot C# Suite**, and running the xUnit test suite.

---

## ⚡ Quick Start: Automated Setup & One-Command Runner

### 1. Automated SDK Installation
Run the automated Linux setup script from your terminal:

```bash
# From the JayPolyGlot/CSharp directory
./scripts/setup-linux.sh
```

> **What it does**: Detects your Linux distribution (`pacman`, `apt`, `dnf`), installs the `.NET SDK` package via native package manager (or uses Microsoft's official `dotnet-install.sh` for generic Linux), and verifies `dotnet` CLI availability.

### 2. One-Command Build & Test Runner
To compile the C# project and execute all xUnit test suites in one command:

```bash
./scripts/build-and-test.sh
```

---

## 📦 Distribution Package Manager Setup

### 1. CachyOS / Arch Linux
```bash
sudo pacman -S dotnet-sdk
```

### 2. Ubuntu / Debian
```bash
# Ubuntu 24.04 / 22.04 LTS
sudo apt update
sudo apt install -y dotnet-sdk-8.0
```

### 3. Fedora / RHEL
```bash
sudo dnf install -y dotnet-sdk-8.0
```

---

## 🌐 Non-Root / Generic Linux Installation (`dotnet-install.sh`)

If you do not have `sudo` access or are running a distribution without native .NET packages:

```bash
# Download official Microsoft installation script
curl -sSL https://dot.net/v1/dotnet-install.sh | bash -s -- --channel 8.0

# Add to current session environment
export DOTNET_ROOT=$HOME/.dotnet
export PATH=$PATH:$DOTNET_ROOT:$DOTNET_ROOT/tools
```

To make this permanent, add these lines to your `~/.bashrc` or `~/.zshrc`:
```bash
export DOTNET_ROOT=$HOME/.dotnet
export PATH=$PATH:$DOTNET_ROOT:$DOTNET_ROOT/tools
```

---

## 🧪 Building, Running, and Testing

### Verify Installation
```bash
dotnet --info
```

### Build the C# Console Application
```bash
cd CSharp
dotnet build
```

### Run the Interactive Console Application
```bash
dotnet run --project CSharpBasics.csproj
```

### Run the xUnit Test Suite
```bash
dotnet test CSharpBasics.Tests/CSharpBasics.Tests.csproj
```

---

## ❓ Troubleshooting

| Symptom | Cause | Solution |
| :--- | :--- | :--- |
| `dotnet: command not found` | `.NET` binary not in `$PATH` | Ensure `/usr/share/dotnet` or `~/.dotnet` is added to your `$PATH`. |
| `SDK not found` error during `dotnet build` | Only Runtime installed instead of SDK | Install `dotnet-sdk` package (not just `dotnet-runtime`). |
| Permission denied when running shell scripts | Script missing execution permission | Run `chmod +x scripts/*.sh`. |
