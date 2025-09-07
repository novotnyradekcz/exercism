#!/usr/bin/env bash

data=$1
rot=$2

if (( rot > 26 || rot < 0 )); then
	exit 2
fi

declare -a alphabet
alphabet=( {a..z} )
alphabet+=( {a..z} )
declare -A cipher
for ((i=0;i<$((26+rot));i++)); do
	tick=$i
	if (( tick >= 26 )); then
		tick=$(( tick - 26 ))
	fi
	cipher[${alphabet[$tick]}]=${alphabet[$((tick+rot))]}
done

for ((i=0;i<${#data};i++)); do
	letter=${data:$i:1}

	case $letter in
		[a-z]) echo -n "${cipher["${letter,,}"]}" ;;
		[A-Z]) echo -n "${cipher["${letter,,}"]^^}" ;;
		*) echo -n "$letter" ;;
	esac
done
echo
