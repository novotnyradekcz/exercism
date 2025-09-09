class PhoneNumber(val inputNumber: String) {
    var number: String = filterNumber(inputNumber)
    
    init {
        require(number[0] !in "01")
        require(number[3] !in "01")
        require(number.length == 10)
    }
    
    private fun filterNumber(inputNumber: String) = inputNumber.filter { it.isDigit() }.removePrefix("1")
}