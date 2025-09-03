module sieve
  implicit none

contains

  function primes(limit) result(array)
    integer, intent(in) :: limit
    integer, allocatable :: array(:)
    logical, allocatable :: sieve(:)
    integer :: i, j, count

    ! Initialize sieve array with .true. (indicating prime) for all numbers
    allocate(sieve(limit))
    sieve = .true.
    
    ! Set sieve(1) to .false. because 1 is not a prime number
    sieve(1) = .false.

    ! Perform sieve of Eratosthenes
    do i = 2, int(sqrt(real(limit)))
      if (sieve(i)) then
        do j = i*i, limit, i
          sieve(j) = .false.
        end do
      end if
    end do

    ! Count the number of primes
    count = 0
    do i = 2, limit
      if (sieve(i)) count = count + 1
    end do

    ! Allocate array to hold the primes
    allocate(array(count))
    count = 0

    ! Store the prime numbers in the result array
    do i = 2, limit
      if (sieve(i)) then
        count = count + 1
        array(count) = i
      end if
    end do

  end function primes

end module sieve
