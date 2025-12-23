function luhn_valid(card_number) {
    gsub(/ /, "", card_number);
    if (length(card_number) <= 1) return 0;

    for (i = 1; i <= length(card_number); i++) {
        if (substr(card_number, i, 1) !~ /[0-9]/) {
            return 0;
        }
    }

    for (i = length(card_number) - 1; i >= 1; i -= 2) {
        digit = substr(card_number, i, 1) * 2;
        if (digit > 9) {
            digit -= 9;
        }
        card_number = substr(card_number, 1, i - 1) digit substr(card_number, i + 1);
    }

    sum = 0;
    for (i = 1; i <= length(card_number); i++) {
        sum += substr(card_number, i, 1);
    }

    return sum % 10 == 0 ? 1 : 0;
}

BEGIN {
    if (getline input < "/dev/stdin" <= 0) {
        print "Error reading input";
        exit 1;
    }

    if (luhn_valid(input)) {
        print "true";
    } else {
        print "false" ;
    }
}
