# this is a stub function that takes a natural_number
# and should return the difference-of-squares as described
# in the README.md
difference_of_squares <- function(natural_number) {
  # Calculate the sum of the first n natural numbers
  sum_of_natural_numbers <- (natural_number * (natural_number + 1)) / 2
  
  # Calculate the square of the sum
  square_of_sum <- sum_of_natural_numbers^2
  
  # Calculate the sum of the squares of the first n natural numbers
  sum_of_squares <- (natural_number * (natural_number + 1) * (2 * natural_number + 1)) / 6
  
  # Return the difference between the square of the sum and the sum of the squares
  difference <- square_of_sum - sum_of_squares
  return(difference)
}
