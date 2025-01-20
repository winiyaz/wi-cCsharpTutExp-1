#!/usr/bin/bash
# This bash srcript is for installing the KL docker image here
clear

# Colors
export RED='\033[0;31m'
export GREEN='\033[0;32m'
export YELLOW='\033[0;33m'
export BLUE='\033[0;34m'
export PURPLE='\033[0;35m'
export CYAN='\033[0;36m'
export WHITE='\033[0;37m'
export NC='\033[0m' # No Color

# Commands
b1() {
    echo -e "${CYAN} =============== "
    echo -e "Setting up a new dotnet project"
    echo -e "===============${NC}"
}

c1() {
    echo -e "${GREEN}[-] Enter name of project ${NC}"
    echo -e "${GREEN}[-]Command Execute - dot new console -n <NewName> ${NC}"
    echo -e "${PURPLE}[*]Enter name of project: ${NC}"
    read -r projekt
    CO1="dotnet new console -n $projekt"
    CO2="eza -T $projekt"
    echo -e "${GREEN}[+] $projekt Created ${NC}"
    $CO1
    $CO2
}

# Execution
b1
c1
