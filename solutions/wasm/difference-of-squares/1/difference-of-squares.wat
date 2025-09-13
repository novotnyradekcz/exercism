(module
  ;;
  ;; Calculate the square of the sum of the first N natural numbers
  ;;
  ;; @param {i32} max - The upper bound (inclusive) of natural numbers to consider
  ;;
  ;; @returns {i32} The square of the sum of the first N natural numbers
  ;;
  (func $squareOfSum (export "squareOfSum") (param $max i32) (result i32)
    (local $index i32)
    (local $sum i32)

    (local.set $index (i32.const 1))
    (local.set $sum (i32.const 0))
    
    (block $loop
      (loop $end
        (br_if $loop (i32.gt_u (local.get $index) (local.get $max)))

        (local.set $sum (i32.add (local.get $sum) (local.get $index)))

        (local.set $index (i32.add (local.get $index) (i32.const 1)))
        (br $end)
      )
    )

    (i32.mul (local.get $sum) (local.get $sum))
  )

  ;;
  ;; Calculate the sum of the squares of the first N natural numbers
  ;;
  ;; @param {i32} max - The upper bound (inclusive) of natural numbers to consider
  ;;
  ;; @returns {i32} The sum of the squares of the first N natural numbers
  ;;
  (func $sumOfSquares (export "sumOfSquares") (param $max i32) (result i32)
    (local $index i32)
    (local $sum i32)

    (local.set $index (i32.const 1))
    (local.set $sum (i32.const 0))
    
    (block $loop
      (loop $end
        (br_if $loop (i32.gt_u (local.get $index) (local.get $max)))

        (local.set $sum (i32.add (local.get $sum) (i32.mul (local.get $index) (local.get $index))))

        (local.set $index (i32.add (local.get $index) (i32.const 1)))
        (br $end)
      )
    )

    (local.get $sum)
  )

  ;;
  ;; Calculate the difference between the square of the sum and the sum of the 
  ;; squares of the first N natural numbers.
  ;;
  ;; @param {i32} max - The upper bound (inclusive) of natural numbers to consider
  ;;
  ;; @returns {i32} Difference between the square of the sum and the sum of the
  ;;                squares of the first N natural numbers.
  ;;
  (func (export "difference") (param $max i32) (result i32)
    (call $squareOfSum (local.get $max))
    (call $sumOfSquares (local.get $max))
    (i32.sub)
  )
)
