import kotlin.math.abs

class Squares {
    val n: Int
    
    constructor(n: Int) {
        this.n = n
    }

    fun sumOfSquares(): Int {
        var sum = 0
        for (i in 1..n) {
            sum += i * i
        }
        return sum
    }

    fun squareOfSum(): Int {
        var sum = 0
        for (i in 1..n) {
            sum += i
        }
        sum *= sum
        return sum
    }

    fun difference(): Int {
        return abs(sumOfSquares() - squareOfSum())
    }
}
