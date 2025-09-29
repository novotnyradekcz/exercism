return {
  encode = function(s)
    local result = ""
    local count = 1
    
    for i = 1, #s do
      local currentChar = s:sub(i, i)
      local nextChar = s:sub(i + 1, i + 1)
        
      if currentChar == nextChar then
        count = count + 1
      else
        if count > 1 then
          result = result .. count .. currentChar
        else
          result = result .. currentChar
        end
        count = 1
      end
    end
    
    return result
  end,

  decode = function(s)
    local result = ""
    local count = ""
    
    for i = 1, #s do
      local char = s:sub(i, i)
        
      if tonumber(char) then
        count = count .. char
      else
        if count == "" then
          count = 1
        end
        result = result .. char:rep(count)
        count = ""
      end
    end
    
    return result
  end
}
