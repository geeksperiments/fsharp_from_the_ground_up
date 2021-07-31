// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
    sprintf $"from {whom}"

let hello name = 
    let message = from name // Call the function
    printfn $"Hello {message}" 

[<EntryPoint>]
let main argv =
    hello "F#"
    for name in argv do
        hello name
    0 // return an integer exit code