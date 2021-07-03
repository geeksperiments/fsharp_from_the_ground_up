// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp
open System
open System.IO
open StudentScores

[<EntryPoint>]
let main argv =
    if argv.Length = 1 then
        let filePath = argv.[0]

        if File.Exists(filePath) then
            printfn $"Processing {filePath}"

            try
                Summary.summarize filePath
                0
            with
            | :? FormatException as e ->
                printfn $"Error: {e.Message}"
                printfn "The file was not in the expected format."
                1
            | :? IOException as e ->
                printfn $"Error: {e.Message}"
                printfn "The file is open in another program, please close it."
                2
            | e ->
                printfn $"Unexpected error: {e.Message}"
                3
        else
            printfn $"File not found: {filePath}"
            4
    else
        printfn "Please specify a file"
        5
