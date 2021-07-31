// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open Numbers
open Calc

[<EntryPoint>]
let main argv =
    printfn $"%A{Numbers.numbers7}"
    printfn $"Sames of Squares: {Calc.SumOfSquaresV2 1000}"

    let initlist = Array.zeroCreate<int> 10
    printfn $"%A{initlist}"
    initlist.[0] <- 42
    printfn $"%A{initlist}"
    0 // return an integer exit code