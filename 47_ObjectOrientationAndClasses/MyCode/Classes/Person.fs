namespace Classes

open System

type Person (name: string, favoriteColorName: string) =
    do
        if String.IsNullOrWhiteSpace(name) then
            raise <| ArgumentException("Null or empty", "name")

    let favoriteColor =
        if String.IsNullOrWhiteSpace(favoriteColorName) then
            "(None)"
        else
            favoriteColorName

    member this.Description() =
        sprintf $"Name: {name}, favorite color: {favoriteColor}"