module BookingUpForBeauty

// The following line is needed to use the DateTime type
open System

let schedule (appointmentDateDescription: string): DateTime = 
    match DateTime.TryParse appointmentDateDescription with
        | true, date -> date
        | _ -> DateTime(2012, 9, 15, 0, 0, 0)

let hasPassed (appointmentDate: DateTime): bool = 
    if appointmentDate < DateTime.Now then true
    else false

let isAfternoonAppointment (appointmentDate: DateTime): bool =
    match appointmentDate.Hour with
        | x when x >= 12 && x < 18 -> true
        | _ -> false

let description (appointmentDate: DateTime): string = 
    "You have an appointment on " + appointmentDate.ToString() + "."

let anniversaryDate(): DateTime = DateTime(2023, 9, 15, 0, 0, 0)
    