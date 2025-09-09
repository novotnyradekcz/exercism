object ScrabbleScore {
    fun scoreLetter(c: Char): Int {
        when (c.uppercaseChar()) {
            'Q', 'Z' -> return 10
            'J', 'X' -> return 8
            'K' -> return 5
            'F', 'H', 'V', 'W', 'Y' -> return 4
            'B', 'C', 'M', 'P' -> return 3
            'D', 'G' -> return 2
            else -> return 1
        }
    }
    fun scoreWord(word: String): Int {
        var score = 0
        for (letter in word) {
            score += scoreLetter(letter)
        }
        return score
    }
}
