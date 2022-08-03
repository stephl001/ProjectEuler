// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these
// multiples is 23.
//
// Find the sum of all the multiples of 3 or 5 below 1000.
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