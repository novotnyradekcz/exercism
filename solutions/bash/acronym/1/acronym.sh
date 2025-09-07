#!/usr/bin/env bash

phrase="$1"
acronym=""

words=$(echo "$phrase" | awk -F'[- ]' '{for (i=1; i<=NF; i++) print $i}' | sed 's/\*/\\\*/g')

for word in $words; do
  cleaned_word=$(echo "$word" | sed 's/[^a-zA-Z]//g' | tr '[:lower:]' '[:upper:]' | cut -c1)

  acronym+="$cleaned_word"
done

echo "$acronym"