namespace StudentScores

module Float =
    let tryFromString s =
        match s with
        | "N/A" -> None
        | _ -> Some(float s)

    let tryFromStringOr defaultValue =
        tryFromString >> Option.defaultValue defaultValue
