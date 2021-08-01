// Learn more about F# at http://fsharp.org

open System
open Classes

[<EntryPoint>]
let main argv =
    let namePrompt = ConsolePrompt("Please enter your name", 3)
    namePrompt.BeepOnError <- false
    namePrompt.ColorScheme <- ConsoleColor.Cyan, ConsoleColor.Cyan
    printfn $"Hello %s{namePrompt.GetValue()}"
    0 // return an integer exit code
