=begin
Write your code for the 'Space Age' exercise in this file. Make the tests in
`space_age_test.rb` pass.

To get started with TDD, see the `README.md` file in your
`ruby/space-age` directory.
=end
class SpaceAge
  EARTH_YEAR_IN_SECONDS = 31557600.0

  ORBITAL_PERIODS = {
    mercury: 0.2408467,
    venus: 0.61519726,
    earth: 1.0,
    mars: 1.8808158,
    jupiter: 11.862615,
    saturn: 29.447498,
    uranus: 84.016846,
    neptune: 164.79132
  }

  def initialize(seconds)
    @seconds = seconds
  end

  def on_planet(planet)
    orbital_period = ORBITAL_PERIODS[planet]
    raise ArgumentError, "Unknown planet: #{planet}" unless orbital_period

    (@seconds / (orbital_period * EARTH_YEAR_IN_SECONDS)).round(2)
  end

  ORBITAL_PERIODS.keys.each do |planet|
    define_method("on_#{planet}") do
      on_planet(planet)
    end
  end
end