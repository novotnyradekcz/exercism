(defpackage :collatz-conjecture
  (:use :cl)
  (:export :collatz))

(in-package :collatz-conjecture)

(defun collatz (n)
  (if (< n 1)
      nil
      (labels ((recursive-collatz (num steps)
        (if (= num 1)
          steps
          (if (= (mod num 2) 0)
            (recursive-collatz (/ num 2) (+ steps 1))
            (recursive-collatz (+ (* 3 num) 1) (+ steps 1))))))
        (recursive-collatz n 0))))
  