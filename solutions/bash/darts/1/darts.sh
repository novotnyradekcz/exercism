#!/usr/bin/env bash

# The following comments should help you get started:
# - Bash is flexible. You may use functions or write a "raw" script.
#
# - Complex code can be made easier to read by breaking it up
#   into functions, however this is sometimes overkill in bash.
#
# - You can find links about good style and other resources
#   for Bash in './README.md'. It came with this exercise.
#
#   Example:
#   # other functions here
#   # ...
#   # ...
#
#   main () {
#     # your main function code here
#   }
#
#   # call main with all of the positional arguments
#   main "$@"
#
# *** PLEASE REMOVE THESE COMMENTS BEFORE SUBMITTING YOUR SOLUTION ***

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
