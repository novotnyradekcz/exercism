fun reverse(input: String): String {
    if (input == "") return input
    val result = StringBuilder(input)
    val lastIndex = result.length - 1
    for (i in 0..lastIndex / 2) {
        val buffer = result[i]
        result[i] = result[lastIndex - i]
        result[lastIndex - i] = buffer
    }
    return result.toString()
}
