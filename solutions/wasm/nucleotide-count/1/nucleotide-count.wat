(module
  (memory (export "mem") 1)
  
  (func (export "countNucleotides") (param $offset i32) (param $length i32) (result i32 i32 i32 i32)
    (local $memIdx i32)
    (local $memEnd i32)
    (local $ACount i32)
    (local $CCount i32)
    (local $GCount i32)
    (local $TCount i32)
    
    (local.set $ACount (i32.const 0))
    (local.set $CCount (i32.const 0))
    (local.set $GCount (i32.const 0))
    (local.set $TCount (i32.const 0))
    
    (local.set $memIdx (local.get $offset))
    (local.set $memEnd (i32.add (local.get $offset) (local.get $length)))
    
    (block $loop
      (loop $loopEnd
        (br_if $loop (i32.eq (local.get $memIdx) (local.get $memEnd)))
        
        (local.get $memIdx)
        (i32.load8_u)
        (i32.const 65) ;; 'A'
        (i32.eq)
        (if 
          (then (local.set $ACount (i32.add (local.get $ACount) (i32.const 1))))
          (else
            (local.get $memIdx)
            (i32.load8_u)
            (i32.const 67) ;; 'C'
            (i32.eq)
            (if 
              (then (local.set $CCount (i32.add (local.get $CCount) (i32.const 1))))
              (else
                (local.get $memIdx)
                (i32.load8_u)
                (i32.const 71) ;; 'G'
                (i32.eq)
                (if 
                  (then (local.set $GCount (i32.add (local.get $GCount) (i32.const 1))))
                  (else
                    (local.get $memIdx)
                    (i32.load8_u)
                    (i32.const 84) ;; 'T'
                    (i32.eq)
                    (if 
                      (then (local.set $TCount (i32.add (local.get $TCount) (i32.const 1))))
                      (else
                        (i32.const -1)
                        (i32.const -1)
                        (i32.const -1)
                        (i32.const -1)
                        return
                      )
                    )
                  )
                )
              )
            )
          )
        )
        (local.set $memIdx (i32.add (local.get $memIdx) (i32.const 1)))
        
        (br $loopEnd)
      )
    )
    
    ;; Return the counts as a 4-way tuple
    (local.get $ACount)
    (local.get $CCount)
    (local.get $GCount)
    (local.get $TCount)
    return
  )
)



;; (module
;;  (memory (export "mem") 1)

  ;;
  ;; Count the number of each nucleotide in a DNA string.
  ;;
  ;; @param {i32} offset - The offset of the DNA string in memory.
  ;; @param {i32} length - The length of the DNA string.
  ;;
  ;; @returns {(i32,i32,i32,i32)} - The number of adenine, cytosine, guanine, 
  ;;                                and thymine nucleotides in the DNA string
  ;;                                or (-1, -1, -1, -1) if the DNA string is
  ;;                                invalid.
  ;;
;;  (func (export "countNucleotides") (param $offset i32) (param $length i32) (result i32 i32 i32 i32)
    
    
;;    (return 
;;      (i32.const -1)
;;      (i32.const -1)
;;      (i32.const -1)
;;      (i32.const -1)
;;    )
;;  )
;;)
