// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let quote symbol s = 
    sprintf $"{symbol}{s}{symbol}"

let singleQuote = quote '\''
let doubleQuote = quote '"'

[<EntryPoint>]
let main argv =
    let quotation = "It was the best of times, it was the worst of times."
    printfn $"{singleQuote quotation}"
    printfn $"{doubleQuote quotation}"
    0 // return an integer exit code