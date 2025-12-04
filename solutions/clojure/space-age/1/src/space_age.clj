(ns space-age)

(def orbital-periods
  {:mercury 0.2408467
   :venus   0.61519726
   :earth   1.0
   :mars    1.8808158
   :jupiter 11.862615
   :saturn  29.447498
   :uranus  84.016846
   :neptune 164.79132})

(def earth-year-seconds 31557600)

(defn calculate-age [planet-seconds orbital-period]
  (/ planet-seconds (* earth-year-seconds orbital-period)))

(defn on-mercury [seconds]
  (calculate-age seconds (:mercury orbital-periods)))

(defn on-venus [seconds]
  (calculate-age seconds (:venus orbital-periods)))

(defn on-earth [seconds]
  (calculate-age seconds (:earth orbital-periods)))

(defn on-mars [seconds]
  (calculate-age seconds (:mars orbital-periods)))

(defn on-jupiter [seconds]
  (calculate-age seconds (:jupiter orbital-periods)))

(defn on-saturn [seconds]
  (calculate-age seconds (:saturn orbital-periods)))

(defn on-uranus [seconds]
  (calculate-age seconds (:uranus orbital-periods)))

(defn on-neptune [seconds]
  (calculate-age seconds (:neptune orbital-periods)))
