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
        | [| surname; givenName |] ->
            {| Surname = surname
               GivenName = givenName |}
        | [| surname |] ->
            {| Surname = surname
               GivenName = "(None)" |}
        | _ -> raise (System.FormatException($"Invalid name format: \"{s}\""))

    let fromString (s: string) =
        let elements = s.Split('\t')
        let name = elements.[0] |> namePart
        let id = elements.[1]

        let scores =
            elements
            |> Array.skip 2
            |> Array.map TestResult.fromString
            |> Array.choose TestResult.tryEffectiveScore

        let mean = scores |> Array.average

        let min = scores |> Array.min

        let max = scores |> Array.max

        { Surname = name.Surname
          GivenName = name.GivenName
          Id = id
          MeanScore = mean
          MinScore = min
          MaxScore = max }

    let printSummary (student: Student) =
        printfn
            $"{student.Surname}, {student.GivenName}	{student.Id}	%0.1f{student.MeanScore}	%0.1f{student.MinScore}	%0.1f{
                                                                                                                             student.MaxScore
            }"

    let printGroupSummary(surname : string) (students : Student[]) = 
        printfn "%s" (surname.ToUpperInvariant())
        students
        |> Array.sortBy (fun student -> student.GivenName)
        |> Array.iter (fun student ->
            printfn "\t%20s\t%s\t%0.1f\t%0.1f\t%0.1f" 
                student.GivenName student.Id
                student.MeanScore student.MinScore student.MaxScore)
