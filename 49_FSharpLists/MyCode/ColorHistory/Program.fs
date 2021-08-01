// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open System.Drawing
open ColorManagement

let listColors (history: ColorHistory) =
    history.Colors()
    |> Seq.iter (printf "%A ")
    printfn ""

[<EntryPoint>]
let main argv =
    printf "I can create a color history with some colors: "
    let history = ColorHistory ([Color.Indigo; Color.Violet], 7)
    history |> listColors
    
    printfn "I can add a color"
    history.Add(Color.Blue)
    history |> listColors
    printfn "The new color is the latest: "
    printfn $"%O{history.TryLatest()}"

    printf "I can explicitly remove the most recent color: "
    history.RemoveLatest()
    history |> listColors


    printf "It doesn't matter if I remove from an empty history: "
    history.RemoveLatest()
    history.RemoveLatest()
    history.RemoveLatest()
    history |> listColors


    0