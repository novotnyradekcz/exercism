#!/usr/bin/env bash

if [ $# -eq 1 ]; then
  echo "Hello, $1"
  exit 0
fi

echo "Usage: $0 <person>"
exit 1