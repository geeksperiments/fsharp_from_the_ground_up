namespace StudentScores

module Summary =
    open System.IO
    open Student

    let summarize filePath =
        let studentList =
            filePath
            |> File.ReadAllLines
            |> Array.skip 1
            |> Array.map fromString
            |> Array.sortBy (fun student -> student.Surname)


        printfn $"Student count: {studentList.Length}"

        studentList |> Array.iter printSummary
