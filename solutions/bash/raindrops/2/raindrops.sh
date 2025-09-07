#!/usr/bin/env bash

number="$1"
output=""

if [ $((number % 3)) -eq 0 ]; then
  output+="Pling"
fi

if [ $((number % 5)) -eq 0 ]; then
  output+="Plang"
fi

if [ $((number % 7)) -eq 0 ]; then
  output+="Plong"
fi

if [ -z "$output" ]; then
  output="$number"
fi

echo "$output"
