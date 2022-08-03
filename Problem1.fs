module Problem1

open Common

let isMultipleOf3Or5 =
    isMultipleOfOneOf [3; 5]

let allMultiplesOf3Or5 =
    Seq.initInfinite ((+) 1)
    |> Seq.filter isMultipleOf3Or5

let response =
    allMultiplesOf3Or5
    |> Seq.takeWhile (notGreaterThan 1000)
    |> Seq.sum