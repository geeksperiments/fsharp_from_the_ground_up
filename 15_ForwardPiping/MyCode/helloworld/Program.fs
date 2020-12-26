// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let sayHello person =
    printfn $"Hello {person} from my F# program!"

let isValid person =
    person 
    |> String.IsNullOrWhiteSpace
    |> not

[<EntryPoint>]
let main argv =
    argv
    |> Array.filter isValid 
    |> Array.iter sayHello
    printfn "Nice to meet you."
    0