(module
  (memory (export "mem") 1)

  (data (i32.const 64) "black,brown,red,orange,yellow,green,blue,violet,grey,white")

  ;;
  ;; Return buffer of comma separated colors
  ;; "black,brown,red,orange,yellow,green,blue,violet,grey,white"
  ;;
  ;; @returns {(i32, i32)} - The offset and length of the buffer of comma separated colors
  ;;
  (func (export "colors") (result i32 i32)
    (i32.const 64)   ;; Offset of the color buffer
    (i32.const 58)   ;; Length of the color string including the commas
  )

  ;;
  ;; Initialization function called each time a module is initialized
  ;; Can be used to populate globals similar to a constructor
  ;; Can be deleted if not needed
  ;;
  (func $initialize)
  (start $initialize)

  ;;
  ;; Given a valid resistor color, returns the associated value
  ;;
  ;; @param {i32} offset - offset into the color buffer
  ;; @param {i32} len - length of the color string
  ;;
  ;; @returns {i32} - the associated value
  ;;
  (func (export "colorCode") (param $offset i32) (param $len i32) (result i32)
    (local $index i32)
    (local $value i32)

    (local.set $index (local.get $offset))
    
    (if (i32.eq (i32.load8_u (local.get $index)) (i32.const 98))  ;; 'b'
      (then
        (local.set $index (i32.add (local.get $index) (i32.const 1)))
        (if (i32.eq (i32.load8_u (local.get $index)) (i32.const 108))  ;; 'l'
          (then
            (local.set $index (i32.add (local.get $index) (i32.const 1)))
            (if (i32.eq (i32.load8_u (local.get $index)) (i32.const 97))  ;; 'a'
              (then (local.set $value (i32.const 0)))  ;; "black"
              (else (local.set $value (i32.const 6)))  ;; "blue"
            )
          )
          (else (local.set $value (i32.const 1)))  ;; "brown"
        )
      )
      (else
        (if (i32.eq (i32.load8_u (local.get $index)) (i32.const 103))  ;; 'g'
          (then 
            (local.set $index (i32.add (local.get $index) (i32.const 3)))
            (if (i32.eq (i32.load8_u (local.get $index)) (i32.const 101))  ;; 'e'
              (then (local.set $value (i32.const 5)))  ;; "green"
              (else (local.set $value (i32.const 8)))  ;; "grey"
            )
          )
          (else
            (if (i32.eq (i32.load8_u (local.get $index)) (i32.const 114))  ;; 'r'
              (then (local.set $value (i32.const 2)))  ;; "red"
              (else
                (if (i32.eq (i32.load8_u (local.get $index)) (i32.const 111))  ;; 'o'
                  (then (local.set $value (i32.const 3)))  ;; "orange"
                  (else
                    (if (i32.eq (i32.load8_u (local.get $index)) (i32.const 121))  ;; 'y'
                      (then (local.set $value (i32.const 4)))  ;; "yellow"
                      (else
                        (if (i32.eq (i32.load8_u (local.get $index)) (i32.const 118))  ;; 'v'
                          (then (local.set $value (i32.const 7)))  ;; "violet"
                          (else (local.set $value (i32.const 9)))  ;; "white"
                        )
                      )
                    )
                  )
                )
              )
            )
          )
        )
      )
    )
    
    (local.get $value)
  )
)
