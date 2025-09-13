(module
  (memory (export "mem") 1)

  ;; Write a decimal number into memory
  ;;
  ;; @param {i32} offset - The offset of the linear memory position to write to
  ;; @param {i32} number - The number that should be serialized
  ;;
  ;; @returns {i32} the number of digits written
  (func $storeNum (param $offset i32) (param $number i32) (result i32)
    (local $digits i32) (local $length i32)
    (local.set $digits (i32.const 0)) (local.set $length (local.get $number))
    (loop $places
      (local.set $length (i32.div_u (local.get $length) (i32.const 10)))
      (local.set $digits (i32.add (local.get $digits) (i32.const 1)))
    (br_if $places (local.get $length)))
    (local.set $length (i32.sub (local.get $digits) (i32.const 1)))
    (loop $chars
      (i32.store8 (i32.add (local.get $offset) (local.get $length))
        (i32.add (i32.rem_u (local.get $number) (i32.const 10)) (i32.const 48)))
      (local.set $number (i32.div_u (local.get $number) (i32.const 10)))
      (local.set $length (i32.sub (local.get $length) (i32.const 1)))
    (br_if $chars (local.get $number)))
    (local.get $digits)
  )

  ;;
  ;; Encode a string using run-length encoding
  ;;
  ;; @param {i32} offset - The offset of the input string in linear memory
  ;; @param {i32} length - The length of the input string in linear memory
  ;;
  ;; @returns {(i32,i32)} - The offset and length of the encoded string in linear memory
  ;;
  (func (export "encode") (param $offset i32) (param $length i32) (result i32 i32)
    (local $char i32) (local $current i32) (local $count i32)
    (local $inputPos i32) (local $outputPos i32)
    (local.set $outputPos (i32.const 0)) 
    (local.set $inputPos (i32.const 0))
    (local.set $current (i32.const -1))
    (if (i32.gt_u (local.get $length) (i32.const 0)) (then (loop $chars
      (local.set $char (i32.load8_u (i32.add (local.get $offset) (local.get $inputPos))))
      (if (i32.eq (local.get $current) (i32.const -1)) ;; no current char
        (then (local.set $current (local.get $char)) (local.set $count (i32.const 1)))
        (else (if (i32.ne (local.get $current) (local.get $char)) ;; current differs from char
          (then (if (i32.ne (local.get $count) (i32.const 1)) ;; more than one instance of the char
            (then (local.set $outputPos (i32.add (local.get $outputPos)
              (call $storeNum (i32.add (local.get $offset) (local.get $outputPos)) (local.get $count))))))
            (i32.store8 (i32.add (local.get $offset) (local.get $outputPos)) (local.get $current))
            (local.set $outputPos (i32.add (local.get $outputPos) (i32.const 1)))
            (local.set $current (local.get $char)) (local.set $count (i32.const 1)))
          (else (local.set $count (i32.add (local.get $count) (i32.const 1)))))))
      (local.set $inputPos (i32.add (local.get $inputPos) (i32.const 1)))
    (br_if $chars (i32.le_u (local.get $inputPos) (local.get $length))))))
    (return (local.get $offset) (local.get $outputPos))
  )

  ;;
  ;; Decode a string using run-length encoding
  ;;
  ;; @param {i32} inputOffset - The offset of the string in linear memory
  ;; @param {i32} inputLength - The length of the string in linear memory
  ;;
  ;; returns {(i32,i32)} - The offset and length of the decoded string in linear memory
  ;;
  (func (export "decode") (param $offset i32) (param $length i32) (result i32 i32)
    (local $inputPos i32) (local $outputPos i32) (local $char i32) (local $count i32)
    (if (i32.eqz (local.get $length)) (then (return (local.get $offset) (i32.const 0))))
    (local.set $inputPos (i32.const 0)) (local.set $outputPos (i32.const 0))
    (local.set $count (i32.const 0))
    (loop $chars
      (local.set $char (i32.load8_u (i32.add (local.get $offset) (local.get $inputPos))))
      (local.set $inputPos (i32.add (local.get $inputPos) (i32.const 1)))
      (if (i32.and (i32.ge_u (local.get $char) (i32.const 48))
        (i32.le_u (local.get $char) (i32.const 57))) ;; == number
        (then (local.set $count (i32.add (i32.mul (local.get $count) (i32.const 10)) (i32.sub (local.get $char) (i32.const 48)))))
        (else (loop $repeat
            (i32.store8 (i32.add (i32.const 300) (local.get $outputPos)) (local.get $char))
            (local.set $outputPos (i32.add (local.get $outputPos) (i32.const 1)))
            (local.set $count (i32.sub (local.get $count) (i32.const 1)))
          (br_if $repeat (i32.ge_s (local.get $count) (i32.const 1))))
          (local.set $count (i32.const 0))))
    (br_if $chars (i32.lt_u (local.get $inputPos) (local.get $length))))
    (return (i32.const 300) (local.get $outputPos))
  )
)
