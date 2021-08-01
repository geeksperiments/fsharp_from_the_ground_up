open System
open System.IO
open StudentScores

[<EntryPoint>]
let main argv =
    if argv.Length = 2 then
        let schoolCodesFilePath = argv.[0]
        let studentsFilePath = argv.[1]
        if not (File.Exists schoolCodesFilePath) then
            printfn "File not found: %s" schoolCodesFilePath
            1
        elif not (File.Exists studentsFilePath) then
            printfn "File not found: %s" studentsFilePath
            2
        else 
            printfn "Processing %s (school codes: %s)" studentsFilePath schoolCodesFilePath
            try
                Summary.summarize schoolCodesFilePath studentsFilePath
                0
            with
            | :? FormatException as e ->
                printfn "Error: %s" e.Message
                printfn "The file was not in the expected format."
                3
            | :? IOException as e ->
                printfn "Error: %s" e.Message
                printfn "If the file is open in another program, please close it."
                4     
            | e ->
                printfn "Unexpected error: %s" e.Message
                5
    else
        printfn "Please specify a file."
        6
