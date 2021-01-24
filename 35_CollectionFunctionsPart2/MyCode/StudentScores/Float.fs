namespace StudentScores

module Float =
    let tryFromString s =
        match s with
        | "N/A" -> Nothing
        | _ -> Something (float s)

    let tryFromStringOr defaultValue =
        tryFromString >> Optional.defaultValue defaultValue
