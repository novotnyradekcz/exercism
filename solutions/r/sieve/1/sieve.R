sieve <- function(limit) {
  if (limit < 2)
    return(c())

  primes <- rep(TRUE, limit)
  primes[1] <- FALSE

  for (i in 2:sqrt(limit))
    if (primes[i] && i^2 < limit)
      primes[seq(i^2, limit, i)] <- FALSE

  which(primes)
}
