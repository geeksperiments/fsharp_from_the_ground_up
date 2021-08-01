open System
open MathSequence

[<EntryPoint>]
let main argv =

    // let total =
    //     // seq { for i in 1..1000 -> i * i }
    //     Seq.init 1000 (fun i -> 
    //         let x = i + 1
    //         x * x)
    //     |> Seq.sum

    let squares = 
        Seq.initInfinite (fun i -> 
            let x = i + 1
            x * x)

    let total = 
        squares
        |> Seq.truncate 1000
        |> Seq.sum

    printfn "The total is: %i" total
    
    MathSequence.pell
    |> Seq.truncate 10
    |> Seq.iter (fun x -> printf $"%i{x} ")
    0 

