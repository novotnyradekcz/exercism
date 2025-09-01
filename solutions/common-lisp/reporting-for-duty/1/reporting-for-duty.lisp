(defpackage :reporting-for-duty
  (:use :cl)
  (:export :format-quarter-value :format-two-quarters
           :format-two-quarters-for-reading))

(in-package :reporting-for-duty)

(defun format-quarter-value (quarter value)
  (format nil "The value ~A quarter: ~A" quarter value)
  )

(defun format-two-quarters (stream first first-value second second-value)
  (format stream
    "~%The value ~A quarter: ~A~%The value ~A quarter: ~A~%"
    first first-value second second-value)
  )

(defun format-two-quarters-for-reading (stream first first-value second second-value)
  (format stream
    "(\"The value ~A quarter: ~S\" \"The value ~A quarter: ~S\")"
    first first-value second second-value)
  )
