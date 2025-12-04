(ns leap)

(defn leap-year? [year] ;; <- argslist goes here
  (if (= (mod year 400) 0)
    true
    (if (= (mod year 100) 0)
      false
      (if (= (mod year 4) 0)
        true
        false))))
