// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
    sprintf $"from {whom}"

[<EntryPoint>]
let main argv =
    let message = from "F#" // Call the function
    printfn $"Hello world {message}"
    0 // return an integer exit code