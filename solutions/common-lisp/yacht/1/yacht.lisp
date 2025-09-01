(defpackage :yacht
  (:use :cl)
  (:export :score))
(in-package :yacht)

(defun count-occurrences (value dice)
  "Counts the number of occurrences of VALUE in the list of DICE."
  (count value dice))

(defun full-house-p (dice)
  "Checks if the dice form a full house."
  (let ((freq (mapcar #'cdr (counted-set dice))))
    (and (= (length freq) 2)
         (or (and (= (first freq) 3) (= (second freq) 2))
             (and (= (first freq) 2) (= (second freq) 3))))))

(defun four-of-a-kind-p (dice)
  "Checks if the dice have at least four of the same value."
  (some (lambda (count) (>= count 4)) (mapcar #'cdr (counted-set dice))))

(defun yacht-p (dice)
  "Checks if all five dice are the same value."
  (= (length (remove-duplicates dice)) 1))

(defun little-straight-p (dice)
  "Checks if the dice form a little straight (1-2-3-4-5)."
  (equal (sort dice #'<) '(1 2 3 4 5)))

(defun big-straight-p (dice)
  "Checks if the dice form a big straight (2-3-4-5-6)."
  (equal (sort dice #'<) '(2 3 4 5 6)))

(defun counted-set (dice)
  "Returns an association list of each dice value and its count."
  (mapcar (lambda (value)
            (cons value (count value dice)))
          (remove-duplicates dice)))

(defun score (dice category)
  "Returns the score of the dice for the given category."
  (ecase category
    (:ones (* 1 (count-occurrences 1 dice)))
    (:twos (* 2 (count-occurrences 2 dice)))
    (:threes (* 3 (count-occurrences 3 dice)))
    (:fours (* 4 (count-occurrences 4 dice)))
    (:fives (* 5 (count-occurrences 5 dice)))
    (:sixes (* 6 (count-occurrences 6 dice)))
    (:full-house (if (full-house-p dice) (reduce #'+ dice) 0))
    (:four-of-a-kind
     (if (four-of-a-kind-p dice)
         (* 4 (car (car (sort (counted-set dice) (lambda (a b) (> (cdr a) (cdr b)))))))
         0))
    (:little-straight (if (little-straight-p dice) 30 0))
    (:big-straight (if (big-straight-p dice) 30 0))
    (:choice (reduce #'+ dice))
    (:yacht (if (yacht-p dice) 50 0))))
