#!/usr/bin/env bash

input_date="$1"
gigasecond=$((10**9))
epoch_time=$(date -d "$input_date" +%s)
gigasecond_anniversary=$((epoch_time + gigasecond))
anniversary_date=$(date -d @"$gigasecond_anniversary" "+%Y-%m-%dT%H:%M:%S")

echo "$anniversary_date"
