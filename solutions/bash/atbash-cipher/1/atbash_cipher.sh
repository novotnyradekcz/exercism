#!/usr/bin/env bash

alphabet="zyxwvutsrqponmlkjihgfedcba"

encode_atbash() {
    local plaintext=$1
    local encoded_text=""

    for ((i = 0; i < ${#plaintext}; i++)); do
        char="${plaintext:i:1}"
        if [[ $char =~ [a-z] ]]; then
            index=$(( $(printf "%d" \'$char) - 97 ))
            encoded_text+="${alphabet:index:1}"
        elif [[ $char =~ [0-9] ]]; then
            encoded_text+="$char"
        fi
    done

    # Format the encoded text into groups of 5 characters and remove trailing space
    echo "$encoded_text" | sed -r 's/([a-z0-9]{5})/\1 /g' | sed 's/[[:space:]]*$//'
}

decode_atbash() {
    local ciphertext=$1
    local decoded_text=""

    for ((i = 0; i < ${#ciphertext}; i++)); do
        char="${ciphertext:i:1}"
        if [[ $char =~ [a-z] ]]; then
            index=$(( $(printf "%d" \'$char) - 97 ))
            decoded_text+="${alphabet:index:1}"
        elif [[ $char =~ [0-9] ]]; then
            decoded_text+="$char"
        fi
    done

    echo "$decoded_text"
}

if [[ "$1" == "encode" ]]; then
    encode_atbash "${2,,}"  # Convert input to lowercase before encoding
elif [[ "$1" == "decode" ]]; then
    decode_atbash "${2,,}"  # Convert input to lowercase before decoding
else
    echo "Usage: $0 encode|decode <text>"
fi
