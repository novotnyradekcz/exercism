
module matrix
  implicit none

contains
  function row(matrix, dims, i) result(r)
    integer, dimension(2), intent(in) :: dims
    character(len=*), dimension(dims(1)), intent(in) :: matrix
    integer, intent(in) :: i
    integer, dimension(dims(2)) :: r
    read(matrix(i),*) r
  end function

  function column(matrix, dims, j) result(c)
    integer, dimension(2), intent(in) :: dims
    character(len=*), dimension(dims(1)), intent(in) :: matrix
    integer, intent(in) :: j
    integer, dimension(dims(1)) :: c
    integer, dimension(dims(2)) :: tmp
    integer :: i
    
    do i = 1, dims(1)
      read(matrix(i),*) tmp
      c(i) = tmp(j)
    enddo
  end function

end module