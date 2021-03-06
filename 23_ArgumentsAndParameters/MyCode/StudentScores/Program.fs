// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open System.IO

module Float =
    let tryFromString s =
        match s with
        | "N/A" -> None
        | _ -> Some (float s)

    let tryFromStringOr defaultValue = tryFromString >> Option.defaultValue defaultValue 

type Student =
    {
        Surname: string
        GivenName: string
        Id : string
        MeanScore : float
        MinScore : float
        MaxScore : float
    }

module Student = 

    let namePart i (s: string) =
        let elements = s.Split(',')
        elements.[i].Trim()

    let fromString (s : string) =               
        let elements = s.Split('\t')
        let name = elements.[0]
        let given = namePart 1 name
        let sur = namePart 0 name
        let id = elements.[1]
        let scores = 
            elements
            |> Array.skip 2
            |> Array.map (Float.tryFromStringOr 50.0)

        let mean =
            scores
            |> Array.average

        let min =
            scores
            |> Array.min

        let max =
            scores
            |> Array.max                        

        {
             Surname = sur
             GivenName = given
             Id = id
             MeanScore = mean
             MinScore = min
             MaxScore = max
        }

    let printSummary (student : Student) = 
        printfn $"{student.Surname}, {student.GivenName}\t{student.Id}\t%0.1f{student.MeanScore}\t%0.1f{student.MinScore}\t%0.1f{student.MaxScore}"

let summarize filePath =
    let studentList = 
        filePath
        |> File.ReadAllLines
        |> Array.skip 1
        |> Array.map Student.fromString
        |> Array.sortBy (fun student -> student.Surname)
        

    printfn $"Student count: {studentList.Length}"
    
    studentList
    |> Array.iter Student.printSummary

[<EntryPoint>]
let main argv =
    if argv.Length = 1 then
        let filePath = argv.[0]
        if File.Exists(filePath) then
            printfn $"Processing {filePath}"
            summarize filePath
            0
        else
            printfn $"File not found: {filePath}"
            2
    else
        printfn "Please specify a file"
        1