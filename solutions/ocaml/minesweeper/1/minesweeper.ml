open Base

type cell =
  | Mine
  | Count of int

let succ_cell = function
  | Mine -> Mine
  | Count n -> Count (n + 1)

let char_of_cell = function
  | Mine -> '*'
  | Count 0 -> ' '
  | Count n ->
    Char.of_int_exn (Char.to_int '0' + n)

let cell_of_char = function
  | '*' -> Mine
  | ' ' -> Count 0
  | _ ->
    invalid_arg "invalid input"

let annotate lines =
  let height = List.length lines in
  if height = 0 then
    []
  else
    let width = String.length (List.hd_exn lines) in
    let line_of_string line =
      Array.init (width + 2) ~f:(fun i ->
          if i = 0 || i = width + 1 then
            Count 0
          else
            cell_of_char line.[i-1]) in
    let string_of_line line =
      String.init width ~f:(fun i -> char_of_cell line.(i + 1)) in
    let board =
      let board = Array.create ~len:(height + 2) [||] in
      board.(0) <- Array.create ~len:(width + 2) (Count 0);
      board.(height + 1) <- Array.create ~len:(width + 2) (Count 0);
      List.iteri lines ~f:(fun i l -> board.(i + 1) <- line_of_string l);
      board in
    for i = 1 to height do
      for j = 1 to width do
        if Poly.(board.(i).(j) = Mine) then
          if j > 0 then
            for k = i - 1 to i + 1 do
              for l = j - 1 to j + 1 do
                board.(k).(l) <- succ_cell board.(k).(l)
              done
            done
      done
    done;
    List.init height ~f:(fun i -> string_of_line board.(i + 1))
