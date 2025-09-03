module hamming
  implicit none
contains

  function compute(strand1, strand2, distance)
    character(len=*) :: strand1, strand2
    integer :: distance
    logical :: compute

    integer :: i, len1, len2

    len1 = len(trim(adjustl(strand1)))
    len2 = len(trim(adjustl(strand2)))

    if (len1 == 0 .and. len2 == 0) then
        distance = 0
        compute = .true.
        return
    endif

    if (len1 == 0 .or. len2 == 0 .or. len1 /= len2) then
        distance = 0
        compute = .false.
        return
    endif

    distance = 0
    do i = 1, len1
        if (strand1(i:i) /= strand2(i:i)) then
            distance = distance + 1
        endif
    end do

    compute = .true.
  end function compute

end module hamming
