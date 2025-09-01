(defpackage :lillys-lasagna
  (:use :cl)
  (:export :expected-time-in-oven
           :remaining-minutes-in-oven
           :preparation-time-in-minutes
           :elapsed-time-in-minutes))

(in-package :lillys-lasagna)

;; Define function expected-time-in-oven
(defun expected-time-in-oven 
  () 
  "returns how many minutes the lasagna should be in the oven" 
  337)
;; Define function remaining-minutes-in-oven
(defun remaining-minutes-in-oven 
  (minutes) 
  "returns how many minutes the lasagna still has to remain in the oven" 
  (- (expected-time-in-oven) minutes))
;; Define function preparation-time-in-minutes
(defun preparation-time-in-minutes 
  (layers) 
  "returns how many minutes Lilly spent preparing the lasagna" 
  (* layers 19))
;; Define function elapsed-time-in-minutes
(defun elapsed-time-in-minutes 
  (layers minutes) 
  "returns how many minutes Lilly has worked on cooking the lasagna" 
  (+ (preparation-time-in-minutes layers) minutes))