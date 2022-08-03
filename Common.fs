module Common

let fibs = 
    let rec fibs' a b =
        seq {
            yield a
            yield! fibs' b (a+b)
        }
    fibs' 1L 2L

let multiplesOf nb =
    Seq.initInfinite ((+) 1 >> (*) nb)

let inline isEven x = 
    x % 2L = 0L

let inline notGreaterThan limit x =
    x < limit

let inline modBy modulus x =
    x % modulus

let inline isMultipleOf mult =
    modBy mult >> (=) 0

let isMultipleOfOneOf multiples x =
    List.map isMultipleOf multiples
    |> List.map ((|>) x)
    |> List.fold (||) false