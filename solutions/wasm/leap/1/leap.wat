(module
  ;;
  ;; Determine if a year is a leap year
  ;;
  ;; @param {i32} year - The year to check
  ;;
  ;; @returns {i32} 1 if leap year, 0 otherwise
  ;;
  (func (export "isLeap") (param $year i32) (result i32)
    (local $result i32)

    (if (i32.rem_u (local.get $year) (i32.const 4))
      (then (local.set $result (i32.const 0)))
      (else
        (if (i32.rem_u (local.get $year) (i32.const 100))
          (then (local.set $result (i32.const 1)))
          (else
            (if (i32.rem_u (local.get $year) (i32.const 400))
              (then (local.set $result (i32.const 0)))
              (else (local.set $result (i32.const 1)))
            )
          )
        )
      )
    )
    (local.get $result)
  )  
)
