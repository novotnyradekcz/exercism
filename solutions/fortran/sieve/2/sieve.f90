module sieve
  implicit none

contains

  function primes(limit) result(array)
    integer, intent(in) :: limit
    integer, allocatable :: array(:)
    logical, allocatable :: sieve(:)
    integer :: i, j, count

    allocate(sieve(limit))
    sieve = .true.
    
    sieve(1) = .false.

    do i = 2, int(sqrt(real(limit)))
      if (sieve(i)) then
        do j = i*i, limit, i
          sieve(j) = .false.
        end do
      end if
    end do

    count = 0
    do i = 2, limit
      if (sieve(i)) count = count + 1
    end do

    allocate(array(count))
    count = 0

    do i = 2, limit
      if (sieve(i)) then
        count = count + 1
        array(count) = i
      end if
    end do

  end function primes

end module sieve
