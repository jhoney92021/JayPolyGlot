#!/usr/bin/env bash
# Automated Linux Setup Script for .NET SDK (C#) Development
set -e

GREEN='\033[0;32m'
YELLOW='\033[1;33m'
CYAN='\033[0;36m'
RED='\033[0;31m'
NC='\033[0m' # No Color

echo -e "${CYAN}=================================================${NC}"
echo -e "${CYAN}   Linux .NET SDK Environment Setup Script       ${NC}"
echo -e "${CYAN}=================================================${NC}"
echo ""

# 1. Check if dotnet is already installed
if command -v dotnet &> /dev/null; then
    echo -e "${GREEN}[+] .NET SDK is already installed and available in PATH:${NC}"
    dotnet --version
    echo ""
    echo -e "${GREEN}Setup complete! You can run 'dotnet build' or 'dotnet test'.${NC}"
    exit 0
fi

echo -e "${YELLOW}[!] .NET SDK not detected in PATH. Starting setup...${NC}"

# 2. Check distro package manager
if command -v pacman &> /dev/null; then
    echo -e "${CYAN}[*] Arch / CachyOS detected. Installing dotnet-sdk via pacman...${NC}"
    sudo pacman -S --needed --noconfirm dotnet-sdk
elif command -v apt-get &> /dev/null; then
    echo -e "${CYAN}[*] Ubuntu / Debian detected. Installing dotnet-sdk via apt...${NC}"
    sudo apt-get update
    sudo apt-get install -y dotnet-sdk-8.0 || sudo apt-get install -y dotnet-sdk-9.0
elif command -v dnf &> /dev/null; then
    echo -e "${CYAN}[*] Fedora / RHEL detected. Installing dotnet-sdk via dnf...${NC}"
    sudo dnf install -y dotnet-sdk-8.0 || sudo dnf install -y dotnet-sdk-9.0
else
    echo -e "${YELLOW}[*] Installing .NET SDK via official Microsoft script (dotnet-install.sh)...${NC}"
    mkdir -p ~/.dotnet
    curl -sSL https://dot.net/v1/dotnet-install.sh | bash -s -- --channel 8.0
    
    # Export env for current session
    export DOTNET_ROOT=$HOME/.dotnet
    export PATH=$PATH:$DOTNET_ROOT:$DOTNET_ROOT/tools
    
    echo -e "${YELLOW}[!] Add the following lines to your ~/.bashrc or ~/.zshrc:${NC}"
    echo "export DOTNET_ROOT=\$HOME/.dotnet"
    echo "export PATH=\$PATH:\$DOTNET_ROOT:\$DOTNET_ROOT/tools"
fi

echo ""
echo -e "${GREEN}=================================================${NC}"
echo -e "${GREEN}   Installation Complete!                        ${NC}"
echo -e "${GREEN}=================================================${NC}"
if command -v dotnet &> /dev/null; then
    dotnet --info | head -n 12
fi
