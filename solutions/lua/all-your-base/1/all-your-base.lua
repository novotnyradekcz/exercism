local all_your_base = {}

all_your_base.convert = function(from_digits, from_base)
    assert(from_base >= 2, 'invalid input base')
    
    local result = 0
    for _, digit in ipairs(from_digits) do
        assert(digit < from_base, 'digit out of range')
        assert(digit >= 0, 'negative digits are not allowed')
        result = result * from_base + digit
    end
    
    return {
        to = function(to_base)
            assert(to_base >= 2, 'invalid output base')
            local digits, rv = math.max(math.ceil(math.log(result) / math.log(to_base)), 1), {}
            while digits > 0 do
                rv[digits] = result % to_base
                result = math.floor(result / to_base)
                digits = digits - 1
            end
            return #rv == 0 and { 0 } or rv
        end
    }
end

return all_your_base
