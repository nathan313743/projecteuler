let total = [1..999] |> List.map (fun i -> if i % 5 = 0 || i % 3 = 0 then i else 0) |> List.sum
printf "%d" total
let total = [1..999] |> List.filter (fun i -> i % 5 = 0 || i % 3 = 0) |> List.sum