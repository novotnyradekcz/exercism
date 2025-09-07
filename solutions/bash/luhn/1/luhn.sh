#!/usr/bin/env bash

number="${1//[[:space:]]/}"  # Remove spaces from the number
sum=0
len=${#number}

if (( len <= 1 )); then
    echo "false"
    exit
fi

if ! [[ $number =~ ^[0-9]+$ ]]; then
    echo "false"
    exit
fi

for ((i = len - 1; i >= 0; i--)); do
    digit=${number:i:1}

    if (( (len - i) % 2 == 0 )); then
        digit=$(( digit * 2 ))
        if (( digit > 9 )); then
            digit=$(( digit - 9 ))
        fi
    fi

    sum=$(( sum + digit ))
    done

if (( sum % 10 == 0 )); then
    echo "true"
else
    echo "false"
fi
