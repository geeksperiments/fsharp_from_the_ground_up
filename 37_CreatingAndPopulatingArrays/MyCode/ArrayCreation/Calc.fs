namespace Calc
module Calc = 
    let SumOfSquares min max =
        [|
            for i in min..max -> i * i
        |]
        |> Array.sum

    let SumOfSquaresV2 max =
        Array.init max (fun i -> 
            let x = i + 1
            x * x)
        |> Array.sum