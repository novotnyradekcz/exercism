module LogLevels

let message(logLine: string): string = (Array.get (logLine.Split(':')) 1).Trim()

let logLevel(logLine: string): string = match logLine with
                                        | line when line.StartsWith("[ERROR]") -> "error"
                                        | line when line.StartsWith("[WARNING]") -> "warning"
                                        | line when line.StartsWith("[INFO]") -> "info"
                                        | _ -> "default"

let reformat(logLine: string): string = message(logLine) + " (" + logLevel(logLine) + ")"
