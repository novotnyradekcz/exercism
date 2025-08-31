def translate(text):
    words = text.split(' ')
    output = []
    for word in words:
        if word[0] in ['a', 'e', 'i', 'o', 'u'] or word[:2] == "xr" or word[:2] == "yt":
            output.append(word + "ay")
        elif word[1] in ['a', 'e', 'i', 'o', 'u', 'y'] and word[:2] != "qu":
            output.append(word[1:] + word[0] + "ay")
        elif (word[2] in ['a', 'e', 'i', 'o', 'u', 'y'] or word[:2] == "qu") and word[1:3] != "qu":
            output.append(word[2:] + word[:2] + "ay")
        elif word[3] in ['a', 'e', 'i', 'o', 'u', 'y'] or word[1:3] == "qu":
            output.append(word[3:] + word[:3] + "ay")
    return ' '.join(output)
