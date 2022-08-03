let solvedProblems = [
    (1, Problem1.response.ToString())
    (2, Problem2.response.ToString())
]

solvedProblems |>
List.iter (fun (pbNum, pbResponse) -> printfn $"Problem #{pbNum}: {pbResponse}")
