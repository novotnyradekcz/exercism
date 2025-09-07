#!/usr/bin/env bash

if [ $# -ne 2 ]; then
  echo "Usage: $0 <string1> <string2>"
  exit 1
fi

arg1="$1"
arg2="$2"

if [ ${#arg1} -ne ${#arg2} ]; then
  echo "strands must be of equal length"
  exit 1
fi

length=0

for ((i = 0; i < ${#arg1}; i++)); do
  if [ "${arg1:$i:1}" != "${arg2:$i:1}" ]; then
    ((length++))
  fi
done

echo "$length"