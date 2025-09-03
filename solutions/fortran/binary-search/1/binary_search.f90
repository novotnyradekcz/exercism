module binary_search
  implicit none

contains

  function find(array, val) result(idx)
    integer, dimension(:), intent(in) :: array
    integer, intent(in) :: val
    integer :: idx
    integer :: low, high, mid

    ! Initialize variables
    low = 1
    high = size(array)
    idx = -1  ! Default to -1 to indicate not found

    ! Perform binary search
    do while (low <= high)
      mid = (low + high) / 2  ! Find the middle index
      if (array(mid) == val) then
        idx = mid  ! Item found at index mid
        return
      elseif (array(mid) < val) then
        low = mid + 1  ! Eliminate the left half
      else
        high = mid - 1  ! Eliminate the right half
      end if
    end do

  end function

end module binary_search
