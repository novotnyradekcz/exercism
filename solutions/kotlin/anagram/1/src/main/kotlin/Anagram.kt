class Anagram (word: String) {
    private val lowerCase = word.lowercase()
    private val sorted = lowerCase.toCharArray().sorted()
    
    fun match(anagrams: Collection<String>): Set<String> =
        anagrams.filter { 
                val candidate = it.lowercase()
                candidate.length == lowerCase.length && candidate != lowerCase && sorted == candidate.toCharArray().sorted()
        }.toSet()
}