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

    let tryEffectiveScore (testResult: TestResult) = 
        match testResult with
        | Absent -> Some 0.0
        | Excused -> None
        | Scored score -> Some score 

