let find arr target =
  let rec binary_search arr target low high =
    if low > high then
      Error "value not in array"
    else
      let mid = (low + high) / 2 in
      let mid_element = arr.(mid) in
      if mid_element = target then
        Ok mid
      else if mid_element > target then
        binary_search arr target low (mid - 1)
      else
        binary_search arr target (mid + 1) high
  in
  binary_search arr target 0 (Array.length arr - 1)
