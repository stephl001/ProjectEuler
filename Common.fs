module Common

let fibs = 
    let rec fibs' a b =
        seq {
            yield a
            yield! fibs' b (a+b)
        }
    fibs' 1L 2L

let inline isEven x = 
    x % 2L = 0L

let inline notGreaterThan limit x =
    x < limit