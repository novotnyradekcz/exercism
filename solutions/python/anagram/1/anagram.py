def find_anagrams(word, candidates):
    anagrams = set()
    for candidate in candidates:
        if sorted(word.lower()) == sorted(candidate.lower()) and word.lower() != candidate.lower():
            anagrams.add(candidate)
    return anagrams