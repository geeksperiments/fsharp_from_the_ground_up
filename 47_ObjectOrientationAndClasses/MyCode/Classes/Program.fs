// Learn more about F# at http://fsharp.org

open System
open Classes

[<EntryPoint>]
let main argv =
    let namePrompt = ConsolePrompt("Please enter your name", 3)
    namePrompt.BeepOnError <- false
    namePrompt.ColorScheme <- ConsoleColor.Cyan, ConsoleColor.Black
    let name = namePrompt.GetValue()
    printfn $"Hello %s{name}"
    let colorPrompt = ConsolePrompt("Please enter your favorite color", 1)
    colorPrompt.BeepOnError <- false
    let person = Person(name, colorPrompt.GetValue())
    printfn $"{person.Description()}"
    0 // return an integer exit code
