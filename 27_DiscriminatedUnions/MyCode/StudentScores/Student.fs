namespace StudentScores

module Student =
    type Student =
        { Surname: string
          GivenName: string
          Id: string
          MeanScore: float
          MinScore: float
          MaxScore: float }


    let namePart i (s: string) =
        let elements = s.Split(',')
        elements.[i].Trim()

    let fromString (s: string) =
        let elements = s.Split('\t')
        let name = elements.[0]
        let given = namePart 1 name
        let sur = namePart 0 name
        let id = elements.[1]

        let scores =
            elements
            |> Array.skip 2
            |> Array.map TestResult.fromString 
            |> Array.filter (fun r -> r <> Excused)
            |> Array.map TestResult.effectiveScore

        let mean = scores |> Array.average

        let min = scores |> Array.min

        let max = scores |> Array.max

        { Surname = sur
          GivenName = given
          Id = id
          MeanScore = mean
          MinScore = min
          MaxScore = max }

    let printSummary (student: Student) =
        printfn
            $"{student.Surname}, {student.GivenName}	{student.Id}	%0.1f{student.MeanScore}	%0.1f{student.MinScore}	%0.1f{
                                                                                                                             student.MaxScore
            }"
