// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

[<EntryPoint>]
let main argv =

    let isEven x =
        x % 2 = 0

    let todayIsSunday =
        DateTime.Now.DayOfWeek = DayOfWeek.Sunday

    let numbers = [|1; 2; 4; 8; 16|]

    let numbers = 
        [|
            for i in 0..4 -> pown 2 i
        |]

    let numbers = 
        [|
            for i in 0..9 -> 
                let x = i * i
                if x |> isEven then
                    x
                else
                    0
        |]

    let numbers = 
        [|
            for i in 0..9 do 
                let x = i * i
                if x |> isEven then
                    x
        |]

    let numbers = 
        [|
            for i in 0..9 do 
                let x = i * i
                if x |> isEven then
                    yield x
        |]

    let numbers = 
        [|
            42
            for i in 0..9 do 
                let x = i * i
                if x |> isEven then
                    x
            999
        |]

    let numbers = 
        //Array Comprehension
        [|
            if todayIsSunday then 42
            for i in 0..9 do 
                let x = i * i
                if x |> isEven then
                    x
            999
        |]

    printfn $"%A{numbers}"
    0 // return an integer exit code