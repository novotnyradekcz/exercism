#!/usr/bin/env bash

if [ "$#" -ne 2 ]; then
    echo "Incorrect number of arguments. Expected: 3"
    exit 1
fi

is_number() {
    re='^-?[0-9]+([.][0-9]+)?$'
    if ! [[ $1 =~ $re ]]; then
        return 1
    else
        return 0
    fi
}

for arg in "$@"; do
    if ! is_number "$arg"; then
        echo "Argument '$arg' is not a number."
        exit 1
    fi
done

x=$1
y=$2

r=$(awk "BEGIN { printf \"%.2f\", sqrt($x*$x + $y*$y) }")

if (( $(echo "$r <= 1" | bc -l) )); then
    echo "10"
elif (( $(echo "$r <= 5" | bc -l) )); then
    echo "5"
elif (( $(echo "$r <= 10" | bc -l) )); then
    echo "1"
else
    echo "0"
fi
