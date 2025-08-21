#if !defined(SPACE_AGE_H)
#define SPACE_AGE_H

namespace space_age {
    class space_age {
        public:
            double seconds_per_year = 31557600;
            long age_in_seconds;
            long seconds() const {
                return age_in_seconds;
            }
            double on_mercury() const {
                return (double)seconds() / (0.2408467 * seconds_per_year);
            }
            double on_venus() const {
                return (double)seconds() / (0.61519726 * seconds_per_year);
            }
            double on_earth() const {
                return (double)seconds() / (seconds_per_year);
            }
            double on_mars() const {
                return (double)seconds() / (1.8808158 * seconds_per_year);
            }
            double on_jupiter() const {
                return (double)seconds() / (11.862615 * seconds_per_year);
            }
            double on_saturn() const {
                return (double)seconds() / (29.447498 * seconds_per_year);
            }
            double on_uranus() const {
                return (double)seconds() / (84.016846 * seconds_per_year);
            }
            double on_neptune() const {
                return (double)seconds() / (164.79132 * seconds_per_year);
            }
    
            space_age(long secs) {
                age_in_seconds = secs;
            }
    };
}  // namespace space_age

#endif // SPACE_AGE_H