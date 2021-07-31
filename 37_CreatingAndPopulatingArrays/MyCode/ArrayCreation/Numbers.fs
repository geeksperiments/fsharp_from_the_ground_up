namespace Numbers
open System
module Numbers =
    let isEven x =
        x % 2 = 0

    let todayIsSunday =
        DateTime.Now.DayOfWeek = DayOfWeek.Sunday

    let numbers1 = [|1; 2; 4; 8; 16|]

    let numbers2 = 
        [|
            for i in 0..4 -> pown 2 i
        |]

    let numbers3 = 
        [|
            for i in 0..9 -> 
                let x = i * i
                if x |> isEven then
                    x
                else
                    0
        |]

    let numbers4 = 
        [|
            for i in 0..9 do 
                let x = i * i
                if x |> isEven then
                    x
        |]

    let numbers5 = 
        [|
            for i in 0..9 do 
                let x = i * i
                if x |> isEven then
                    yield x
        |]

    let numbers6 = 
        [|
            42
            for i in 0..9 do 
                let x = i * i
                if x |> isEven then
                    x
            999
        |]

    let numbers7 = 
        //Array Comprehension
        [|
            if todayIsSunday then 42
            for i in 0..9 do 
                let x = i * i
                if x |> isEven then
                    x
            999
        |]

    let numbers8 = Array.init 5 (fun i -> pown 2 i)