local function flatten(input)
    local result = {}
    
    local function flatten(input)
        for _, value in ipairs(input) do
            if type(value) == "table" then
                flatten(value)
            elseif value ~= nil and value ~= "null" then
                table.insert(result, value)
            end
        end
    end
    
    flatten(input)
    return result
end

return flatten
