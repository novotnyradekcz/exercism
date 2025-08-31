
import re

def count_words(sentence):
    input = sentence.lower()
    word_list = re.split("\n|\t| |,|_", input)
    strip_list = []
    for word in word_list:
        strip_list.append(word.strip("_'.,!;:&@$%^"))
    word_set = set(strip_list)
    if "" in word_set:
        word_set.remove("")
    word_counts = {}
    for word in word_set:
        word_counts[word] = strip_list.count(word)
    return word_counts
