(defpackage :leap
  (:use :cl)
  (:export :leap-year-p))
(in-package :leap)

(defun leap-year-p (year)
  (if (= (mod year 400) 0)
    t
    (if (= (mod year 100) 0)
      nil
      (if (= (mod year 4) 0)
        t
      )
    )
  )
)
