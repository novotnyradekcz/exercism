(defpackage :gigasecond-anniversary
  (:use :cl)
  (:export :from))
(in-package :gigasecond-anniversary)

(defun from (year month day hour minute second)
  (multiple-value-bind (s min h d mon y)
    (decode-universal-time
      (+ (encode-universal-time second minute hour day month year) 1000000000)
    )
    (list y mon d h min s)
  )
)
