#!/usr/bin/env bash

sieve_of_eratosthenes() {
    local limit=$1
    # array to store whether number is prime
    local primes=()
    for ((i=2; i<=limit; i++)); do
        primes[$i]=1  # 1 means prime
    done

    # Apply the Sieve of Eratosthenes algorithm
    for ((i=2; i*i<=limit; i++)); do
        if [[ ${primes[$i]} -eq 1 ]]; then
            for ((j=i*i; j<=limit; j+=i)); do
                primes[$j]=0  # 0 means composite
            done
        fi
    done

    # print numbers
    for ((i=2; i<=limit; i++)); do
        if [[ ${primes[$i]} -eq 1 ]]; then
            if [[ $i -eq 2 ]]; then
                echo -n "$i"
            else
                echo -n " $i"
            fi
        fi
    done
}

# check usage
if [[ $# -ne 1 ]]; then
    echo "Usage: $0 <limit>"
    exit 1
fi

# check if argument is a positive integer
if [[ ! $1 =~ ^[1-9][0-9]*$ ]]; then
    echo "Error: Argument must be a positive integer."
    exit 1
fi

sieve_of_eratosthenes "$1"


