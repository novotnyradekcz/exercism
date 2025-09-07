#!/usr/bin/env bash

input="$1"
if [[ -z "$input" ]]; then
    echo "Invalid input: series cannot be empty"
    exit 1
fi

length="$2"
if (( length < 1 )); then
    echo "Invalid input: slice length cannot be negative and slice length cannot be zero"
    exit 1
fi

input_length=${#input}
if (( input_length < length )); then
    echo "Invalid input: slice length cannot be greater than series length"
    exit 1
fi

substrings=""
for (( i = 0; i <= input_length - length; i++ )); do
    substring="${input:i:length}"
    substrings+="$substring "
done

echo "$substrings" | xargs
