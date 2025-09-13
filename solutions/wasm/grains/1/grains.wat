(module
  ;;
  ;; Calculate the number of grains of wheat on the nth square of the chessboard
  ;;
  ;; @param {i32} squareNum - The square of the chessboard to calculate the number of grains for
  ;;
  ;; @returns {i64} - The number of grains of wheat on the nth square of the 
  ;;                  chessboard or 0 if the squareNum is invalid. The result
  ;;                  is unsigned.
  ;;
  (func $square (export "square") (param $squareNum i32) (result i64)
    (local $index i32)
    (local $result i64)

    (local.set $index (i32.const 1))
    (local.set $result (i64.const 1))
    
    (if (i32.le_s (local.get $squareNum) (i32.const 0))
      (then (local.set $result (i64.const 0)))
      (else
        (block $loop
          (loop $end
            (br_if $loop (i32.eq (local.get $index) (local.get $squareNum)))

            (local.set $result (i64.mul (local.get $result) (i64.const 2)))

            (local.set $index (i32.add (local.get $index) (i32.const 1)))
            (br $end)
          )
        )
      )
    )
    (local.get $result)
  )

  ;;
  ;; Calculate the sum of grains of wheat across all squares of the chessboard
  ;;
  ;; @returns {i64} - The number of grains of wheat on the entire chessboard.
  ;;                  The result is unsigned.
  ;;
  (func (export "total") (result i64)
    (local $index i32)
    (local $result i64)

    (local.set $index (i32.const 1))
    (local.set $result (i64.const 0))
    
    (block $loop
      (loop $end
        (br_if $loop (i32.eq (local.get $index) (i32.const 65)))

        (local.set $result (i64.add (local.get $result) (call $square (local.get $index))))

        (local.set $index (i32.add (local.get $index) (i32.const 1)))
        (br $end)
      )
    )
    (local.get $result)
  )
)
