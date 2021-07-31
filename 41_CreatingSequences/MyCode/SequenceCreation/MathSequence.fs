namespace MathSequence
module MathSequence = 
    type State = {N:int;Pn2:int;Pn1:int}

    let pell = 
        { N = 0; Pn2 = 0; Pn1 = 0; }
        |> Seq.unfold (fun s ->
            let pn =
                match s.N with
                |0|1
                    -> s.N
                | _ 
                    -> 2*s.Pn2 + s.Pn1
            let s' = { N = s.N + 1; Pn2 = s.Pn1; Pn1 =  pn; }
            Some(pn, s'))


    