return function(config)
    if config.span == 0 then return 1 end
    assert(config.span > 0, 'span should not be negative')
    assert(#config.digits > 0, 'string should be not null')
    assert(#config.digits >= config.span,
           'span should be not bigger than string')

    local largest_product = -math.huge
    local step = config.span - 1

    for i = 1, #config.digits - step do
        local product = 1
        for digit in config.digits:sub(i, i + step):gmatch('.') do
            product = product * digit
        end
        largest_product = math.max(largest_product, product)
    end

    return largest_product
end
