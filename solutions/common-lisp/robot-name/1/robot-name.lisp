(defpackage :robot-name
  (:use :cl)
  (:export :build-robot :robot-name :reset-name))

(in-package :robot-name)

(defun random-letter ()
  (code-char (+ #.(char-code #\A)
                (random #.(- (char-code #\Z)
                             (char-code #\A)
                             -1)))))
(defun random-number ()
  (1+ (random 1000)))

(defparameter *used-names* (make-hash-table :test #'equal))

(defun random-name ()
  (let ((candidate (format nil "~A~A~3,'0D"
                           (random-letter)
                           (random-letter)
                           (random-number))))
    (if (gethash candidate *used-names* nil)
        (random-name)
        (progn
          (setf (gethash candidate *used-names*) t)
          candidate))))

(defun replace-name (old-name)
  (let ((new-name (random-name)))
    (remhash old-name *used-names*)
    new-name))

(defclass robot ()
  ((name :initform (random-name) :reader robot-name)))
(defmethod print-object ((r robot) stream)
  (print-unreadable-object (r stream :type t)
    (princ (robot-name r) stream)))

(defun build-robot ()
  (make-instance 'robot))

(defmethod reset-name ((r robot))
  (with-slots (name) r
    (setf name (replace-name name))))