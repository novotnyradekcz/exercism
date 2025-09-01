(defpackage :grains
  (:use :cl)
  (:export :square :total))
(in-package :grains)

(defun square (n) 
  (expt 2 (- n 1)))

(defun total () 
  (loop for i from 1 to 64
    sum (square i)))
