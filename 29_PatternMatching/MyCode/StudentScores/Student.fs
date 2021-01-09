namespace StudentScores

module Student =
    type Student =
        { Surname: string
          GivenName: string
          Id: string
          MeanScore: float
          MinScore: float
          MaxScore: float }


    let namePart (s: string) =
        let elements = s.Split(',')

        match elements with
        | [| surname; givenName |] -> surname, givenName
        | _ -> raise (System.FormatException($"Invalid name format: \"{s}\""))

    let fromString (s: string) =
        let elements = s.Split('\t')
        let name = elements.[0]
        let sur, given = namePart name
        let id = elements.[1]

        let scores =
            elements
            |> Array.skip 2
            |> Array.map TestResult.fromString
            |> Array.choose TestResult.tryEffectiveScore

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
