module GradeSchool

type School = Map<int, string list>

let empty: School = Map.empty

let add (student: string) (grade: int) (school: School): School = 
    if Map.exists (fun g s -> List.contains student s) school then
        school
    else
        match (Map.tryFind grade school) with
        | None -> Map.add grade [student] school
        | Some _ -> Map.add grade (List.sort (student::school.[grade])) school

let roster (school: School): string list = Map.values school |> List.concat |> List.distinct

let grade (number: int) (school: School): string list = 
    match (Map.tryFind number school) with
    | None -> []
    | Some _ -> school.[number]
