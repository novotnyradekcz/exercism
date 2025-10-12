(import (rnrs))

(define (dna->rna dna)
  (define (complement nucleotide)
    (cond ((char=? nucleotide #\G) #\C)
          ((char=? nucleotide #\C) #\G)
          ((char=? nucleotide #\T) #\A)
          ((char=? nucleotide #\A) #\U)))
  
  (list->string (map complement (string->list dna))))
