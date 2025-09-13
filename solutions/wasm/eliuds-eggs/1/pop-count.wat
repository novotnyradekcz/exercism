(module
  ;;
  ;; count the number of 1 bits in the binary representation of a number
  ;;
  ;; @param {i32} number - the number to count the bits of
  ;;
  ;; @returns {i32} the number of 1 bits in the binary representation of the number
  ;;
  (func (export "eggCount") (param $number i32) (result i32)
    (local $num i32)
    (local $counter i32)
    
    (local.set $num (local.get $number))
    (local.set $counter (i32.const 0))
    (block $loop
      (loop $end
        (br_if $loop (i32.eq (local.get $num) (i32.const 0)))

        (if (i32.eq (i32.rem_u (local.get $num) (i32.const 2)) (i32.const 1))
          (then (local.set $counter (i32.add (local.get $counter) (i32.const 1))))
        )

        (local.set $num (i32.div_u (local.get $num) (i32.const 2)))
        (br $end)
      )
    )
    (return (local.get $counter))
  )
)
