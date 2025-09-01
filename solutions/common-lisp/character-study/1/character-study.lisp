(defpackage :character-study
  (:use :cl)
  (:export
   :compare-chars
   :size-of-char
   :change-size-of-char
   :type-of-char))
(in-package :character-study)

(defun compare-chars (char1 char2)
  (if (char-lessp char1 char2)
    :less-than
    (if (char-greaterp char1 char2)
      :greater-than
      :equal-to
      )
    )
  )

(defun size-of-char (char)
  (if (lower-case-p char)
      :small
      (if (upper-case-p char)
        :big
        :no-size
        )
      )
  )

(defun change-size-of-char (char wanted-size)
  (if (string-equal wanted-size :big)
      (char-upcase char)
      (char-downcase char)
      )
  )

(defun type-of-char (char)
  (cond
    ((alpha-char-p char) :alpha)
    ((digit-char-p char) :numeric)
    ((char-equal #\Space char) :space)
    ((char-equal #\Newline char) :newline)
    (t :unknown)
    )
  )
