// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System.IO;

let printMeanScore (row : string) = 
    let elements = row.Split('\t')

    let name = elements.[0]
    let id = elements.[1]
    let scores = 
        elements
        |> Array.skip 2
        |> Array.map float
    
    let mean =
        scores
        |> Array.average
    
    let min =
        scores
        |> Array.min

    let max =
        scores
        |> Array.max
     

    printfn $"{name}\t{id}\t%0.1f{mean}\t%0.1f{min}\t%0.1f{max}"

let summarize filePath =
    let studentList = 
        filePath
        |> File.ReadAllLines
        |> Array.skip 1

    printfn $"Student count: {studentList.Length}"
    
    studentList
    |> Array.iter printMeanScore

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