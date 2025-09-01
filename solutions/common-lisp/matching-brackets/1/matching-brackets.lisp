(defpackage :matching-brackets
  (:use :cl)
  (:export :pairedp))

(in-package :matching-brackets)

(defun opening (char)
  (case char
    (#\{ #\})
    (#\[ #\])
    (#\( #\))
  )
)

(defun pairedp (string)
  (let ((stack (list))
        (closing '(#\} #\] #\)))
        (flag T))
    (loop for i from 0 to (- (length string) 1) do
      (if (opening (aref string i))
        (push (aref string i) stack)
        (when (member (aref string i) closing)
          (when (or (= (length stack) 0) (not (equal (aref string i) (opening (pop stack)))))
            (setq flag NIL)
            )
          )
        )
      )
    (and flag (= (length stack) 0))
    )
  )
