{
    gsub(/[ -]/, "", $0)

    $0 = tolower($0)

    split($0, chars, "")

    for (i = 1; i <= length($0); i++) {
        if (seen[chars[i]]++) {
            print "false"
            exit
        }
    }

    print "true"
}

