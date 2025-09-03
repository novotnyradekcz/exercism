module nth_prime
  implicit none
contains

  logical function is_prime(num)
    integer, intent(in) :: num
    integer :: i, sqrt_num

    if (num <= 1) then
        is_prime = .false.
        return
    endif

    sqrt_num = int(sqrt(real(num)))
    is_prime = .true.
    do i = 2, sqrt_num
        if (mod(num, i) == 0) then
            is_prime = .false.
            return
        endif
    end do
  end function is_prime

  integer function prime(n)
    integer, intent(in) :: n
    integer :: count, num

    count = 0
    num = 2

    do while (count < n)
        if (is_prime(num)) then
            count = count + 1
            if (count == n) then
                prime = num
                return
            endif
        endif
        num = num + 1
    end do

    prime = -1
  end function prime

end module nth_prime
