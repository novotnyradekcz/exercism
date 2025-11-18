proc reverse*(s: string): string =
  result = ""
  for letter in s:
    result = letter & result
