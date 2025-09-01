(defpackage :lillys-lasagna-leftovers
  (:use :cl)
  (:export
   :preparation-time
   :remaining-minutes-in-oven
   :split-leftovers))

(in-package :lillys-lasagna-leftovers)

(defun preparation-time (&rest layers)
  (* 19 (length layers))
  )

(defun remaining-minutes-in-oven (&optional (time-in-oven :normal))
  (+
    337
    (case time-in-oven
      (:very-long 200)
      (:longer 100)
      (:normal 0)
      (:shorter -100)
      (:very-short -200)
      (otherwise -337)
      )
    )
  )

(defun split-leftovers (&optional &key (weight nil weight-p) (human 10) (alien 10))
  (if weight-p
    (if (null weight) 
      :looks-like-someone-was-hungry
      (- weight (+ human alien))
      )
    :just-split-it
    )
  )
