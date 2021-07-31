open System
open Bricks
open Microsoft.FSharp.Collections

[<EntryPoint>]
let main argv =

    let bricks =

        seq {
            printfn "creating elements"
            (3, 2, ConsoleColor.Yellow)
            (4, 2, ConsoleColor.Green)
            (2, 1, ConsoleColor.Magenta)
            (1, 1, ConsoleColor.Blue)
            (2, 2, ConsoleColor.Red)
            (4, 2, ConsoleColor.Blue)
            (4, 2, ConsoleColor.Magenta)
            (2, 2, ConsoleColor.Magenta)
            (2, 2, ConsoleColor.Red)
            (4, 2, ConsoleColor.Blue)
            (3, 2, ConsoleColor.Magenta)
            (4, 2, ConsoleColor.Green)
            (3, 2, ConsoleColor.Red)
            (4, 1, ConsoleColor.Blue)
            (4, 2, ConsoleColor.Yellow)
            (4, 2, ConsoleColor.Yellow)
            (1, 1, ConsoleColor.Blue)
            (1, 1, ConsoleColor.Green)
            (2, 1, ConsoleColor.Yellow)
            (4, 1, ConsoleColor.Magenta)
        }
        |> Seq.map (fun (sc, sr, cc) -> { StudColumns = sc; StudRows = sr; Color = cc })
        |> Seq.cache

        
    printfn "All the bricks:"
    bricks
    |> Seq.iter (Brick.printConsole)
    printfn "\n"

    printfn "Count of the bricks:"
    let count = bricks |> Seq.length
    printfn "Count: %i\n" count

    // printfn "Stud counts:"
    // bricks
    // |> Seq.map (fun b -> b.StudColumns * b.StudRows)
    // |> Seq.iter (fun c -> printf "%i; " c)
    // printfn "\n"

    // printfn "Red bricks (Seq.filter):"
    // bricks
    // |> Seq.filter (fun b -> b.Color = ConsoleColor.Red)
    // |> Seq.iter Brick.printConsole
    // printfn "\n"

    // printfn "Grouped by color (Seq.groupBy):"
    // let groupedByColor =
    //     bricks
    //     |> Seq.groupBy (fun b -> b.Color)
 
    // groupedByColor
    // |> Seq.iter (fun (color, bricks) ->
    //     printfn "%s:" (color.ToString())
    //     bricks
    //     |> Seq.iter Brick.printConsole
    //     printfn ""
    // )
    // printfn ""

    // printfn "Grouped by studcount (Seq.groupBy):"
    // let groupedByStudCount =
    //     bricks
    //     |> Seq.groupBy (fun b -> b.StudRows * b.StudColumns)
 
    // groupedByStudCount
    // |> Seq.sortByDescending fst
    // |> Seq.iter (fun (studCount, bricks) ->
    //     printfn "%i stud:" studCount
    //     bricks
    //     |> Seq.iter Brick.printConsole
    //     printfn "")
    // printfn ""

    0 
