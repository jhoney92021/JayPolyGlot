#!/usr/bin/env bash
# One-command script to build C# Basics and run xUnit test suite
set -e

GREEN='\033[0;32m'
CYAN='\033[0;36m'
RED='\033[0;31m'
NC='\033[0m'

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
CSHARP_DIR="$(dirname "$SCRIPT_DIR")"

echo -e "${CYAN}=================================================${NC}"
echo -e "${CYAN}   Building C# Basics & Running xUnit Tests      ${NC}"
echo -e "${CYAN}=================================================${NC}"

if ! command -v dotnet &> /dev/null; then
    echo -e "${RED}[ERROR] dotnet CLI is not installed or not in PATH.${NC}"
    echo "Please run ./scripts/setup-linux.sh or install .NET SDK first."
    exit 1
fi

cd "$CSHARP_DIR"

echo -e "${CYAN}[1/2] Building C# Project...${NC}"
dotnet build CSharpBasics.csproj

echo ""
echo -e "${CYAN}[2/2] Running xUnit Test Suite...${NC}"
dotnet test CSharpBasics.Tests/CSharpBasics.Tests.csproj

echo ""
echo -e "${GREEN}=================================================${NC}"
echo -e "${GREEN}   All C# Builds & Tests Succeeded!              ${NC}"
echo -e "${GREEN}=================================================${NC}"
