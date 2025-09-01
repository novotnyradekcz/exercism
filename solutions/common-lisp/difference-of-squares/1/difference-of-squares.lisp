(defpackage :difference-of-squares
  (:use :cl)
  (:export :sum-of-squares
           :square-of-sum
           :difference))

(in-package :difference-of-squares)

(defun square-of-sum (n)
  "Calculates the square of the sum for a given number."
  (labels ((sum-of-n (sum num step)
    (if (= step num)
      (+ sum step)
      (sum-of-n (+ sum step) num (+ step 1)))))
    (expt (sum-of-n 0 n 0) 2))
  )

(defun sum-of-squares (n)
  "Calculates the sum of squares for a given number."
  (labels ((sum-of-n (sum num step)
    (if (= step num)
      (+ sum (* step step))
      (sum-of-n (+ sum (* step step)) num (+ step 1)))))
    (sum-of-n 0 n 0))
  )

(defun difference (n)
  "Finds the diff. between the square of the sum and the sum of the squares."
  (- (square-of-sum n) (sum-of-squares n))
  )
