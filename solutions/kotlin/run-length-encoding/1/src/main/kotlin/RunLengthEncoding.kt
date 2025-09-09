object RunLengthEncoding {
    fun encode(input: String): String {
        if (input == "") {
            return input
        }
        
        val result = StringBuilder()
        var count = 1
        
        for (i in 1 until input.length) {
            if (input[i] == input[i - 1]) {
                count++
            } else {
                if (count > 1) {
                    result.append(count).append(input[i - 1])
                } else {
                    result.append(input[i - 1])
                }
                count = 1
            }
        }
        if (count > 1) {
            result.append(count).append(input[input.length - 1])
        } else {
            result.append(input[input.length - 1])
        }
        
        return result.toString()
    }

    fun decode(input: String): String {
        if (input == "") {
            return input
        }
        
        val result = StringBuilder()
        var i = 0
        
        while (i < input.length) {
            var count = 0
            while (i < input.length && input[i].isDigit()) {
                count = count * 10 + (input[i] - '0')
                i++
            }
            if (count == 0) count = 1
            if (i < input.length) {
                result.append(input[i].toString().repeat(count))
                i++
            }
        }
        
        return result.toString()
    }
}
