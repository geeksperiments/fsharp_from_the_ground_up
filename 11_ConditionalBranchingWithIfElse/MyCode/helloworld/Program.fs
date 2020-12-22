// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

[<EntryPoint>]
let main argv =
    let person = 
        match argv with
        | arg when arg.Length > 0 -> arg.[0]
        | _ -> "Anonymous Person"

    printfn $"Hello {person} from my F# program!"
    0 // return an integer exit code


