#!/usr/bin/env bash

if [ "$#" -ne 1 ]; then
    echo "Usage: leap.sh <year>"
    exit 1
fi

if [[ "$1" =~ ^[0-9]+$ ]]; then
    year=$1
else
    echo "Usage: leap.sh <year>"
    exit 1
fi

if [ $((year % 4)) -eq 0 ] && ([ $((year % 100)) -ne 0 ] || [ $((year % 400)) -eq 0 ]); then
    echo "true"
    exit 0
fi

echo "false"