(ns cars-assemble)

(defn production-rate
  "Returns the assembly line's production rate per hour,
   taking into account its success rate"
  [speed]
  (cond (= speed 0) 0.0
        (<= speed 4) (* 221.0 speed)
        (<= speed 8) (* 221.0 speed 0.9)
        (= speed 9) (* 221.0 speed 0.8)
        (= speed 10) (* 221.0 speed 0.77)
        :else 0.0))

(defn working-items
  "Calculates how many working cars are produced per minute"
  [speed]
  (int (/
         (production-rate speed)
         60)))
