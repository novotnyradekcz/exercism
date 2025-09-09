class Triangle<out T : Number>(val a: T, val b: T, val c: T) {

    init {
        val sideA = (Number::toDouble)(a)
        val sideB = (Number::toDouble)(b)
        val sideC = (Number::toDouble)(c)
        if (sideA <= 0 || sideB <= 0 || sideC <= 0) {
            throw java.lang.IllegalArgumentException("Triangle sides have to be larger than 0.")
        }
        if (sideA + sideB < sideC || sideB + sideC < sideA || sideC + sideA < sideB) {
            throw java.lang.IllegalArgumentException("Triangle inequality violated.")
        }
    }

    private val sides = setOf(a, b, c).size
    
    val isEquilateral: Boolean = sides == 1
    val isIsosceles: Boolean = sides <= 2
    val isScalene: Boolean = sides == 3
}
