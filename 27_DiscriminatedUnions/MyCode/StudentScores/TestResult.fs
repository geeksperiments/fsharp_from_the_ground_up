namespace StudentScores

type TestResult = 
   | Absent
   | Excused
   | Scored of float

module TestResult = 

    let fromString s =
        match s with 
        | "A" -> Absent
        | "E" -> Excused
        | _ -> s |> float |> Scored

    let effectiveScore (testResult: TestResult) = 
        match testResult with
        | Absent -> 0.0
        | Excused -> 50.0
        | Scored score -> score 

