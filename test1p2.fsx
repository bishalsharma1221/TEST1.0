open System
// Tail-recursive function to calculate the sum of multiples of 3 up to n
let sumMultiplesOf3 (n: int) : int =
    let rec sumHelper (current: int) (acc: int) =
        if current > n then acc
        else sumHelper (current + 3) (acc + current)
    
    sumHelper 3 0
// Test the function with n = 27
let result = sumMultiplesOf3 27
printfn "Sum of multiples of 3 up to 27: %d" result