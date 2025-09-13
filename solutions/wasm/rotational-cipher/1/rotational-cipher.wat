(module
  (memory (export "mem") 1)
  ;;
  ;; Encrypt plaintext using the rotational cipher.
  ;;
  ;; @param {i32} textOffset - The offset of the plaintext input in linear memory.
  ;; @param {i32} textLength - The length of the plaintext input in linear memory.
  ;; @param {i32} shiftKey - The shift key to use for the rotational cipher.
  ;;
  ;; @returns {(i32,i32)} - The offset and length of the ciphertext output in linear memory.
  ;;
  (func (export "rotate") (param $textOffset i32) (param $textLength i32) (param $shiftKey i32) (result i32 i32)
    (local $letterCase i32)
    (local $character i32)
    (local $lowerCase i32)
    (local $end i32)
    (local $charOffset i32)
    (local.set $end (i32.add (local.get $textOffset) (local.get $textLength)))
    (local.tee $charOffset (local.get $textOffset))
    
    (loop
      (block $continue
        (local.set $character (i32.load8_u (local.get $charOffset)))
        (local.set $letterCase (i32.and (i32.const 0x20) (local.get $character)))
        (local.set $lowerCase (i32.sub (local.get $character) (local.get $letterCase)))
        
        (if (i32.lt_u (local.get $lowerCase) (i32.const 65))
          (then br $continue)
        )
        (if (i32.gt_u (local.get $lowerCase) (i32.const 90))
          (then br $continue)
        )
        
        (i32.store8 (local.get $charOffset)
          (local.get $lowerCase)
          (i32.sub (i32.const 65))
          (i32.add (local.get $shiftKey))
          (i32.rem_u (i32.const 26))
          (i32.add (i32.const 65))
          (i32.add (local.get $letterCase)))
      )
    
      (local.tee $charOffset (i32.add (local.get $charOffset) (i32.const 1)))
      (br_if 0 (i32.lt_u (local.get $end)))
    )
  
    (return (local.get $textOffset) (local.get $textLength))
  )
)