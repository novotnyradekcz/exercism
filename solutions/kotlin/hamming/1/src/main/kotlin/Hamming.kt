object Hamming {

    fun compute(leftStrand: String, rightStrand: String): Int {
        if (leftStrand.length != rightStrand.length) {
            throw IllegalArgumentException("left and right strands must be of equal length")
        } else {
            var counter = 0
            for (i in 0 until leftStrand.length) {
                if (leftStrand[i] != rightStrand[i]) counter++
            }
        return counter
        }
    }
}
