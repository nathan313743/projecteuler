namespace Problem1

module Say =
    let hello name =
        printfn "Hello %s" name

module Problem1 =
    let result = [1..999] |> List.map (fun i -> if i % 5 = 0 || i % 3 = 0 then i else 0) |> List.sum