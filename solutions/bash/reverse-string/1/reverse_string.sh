#!/usr/bin/env bash


input="$1"
length=${#input}
reversed=""

for ((i = length - 1; i >= 0; i--)); do
    reversed="${reversed}${input:$i:1}"
done

echo "$reversed"

