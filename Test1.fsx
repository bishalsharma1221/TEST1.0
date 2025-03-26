open System
// 1. Mapping, Filtering through Lists
let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

// A) Filter high-income salaries (above 100,000)
let highIncomeSalaries = List.filter (fun s -> s > 100000) salaries
printfn "High Income Salaries: %A" highIncomeSalaries

// B) Calculate tax for all salaries based on the tax table
let calculateTax (salary: int) =
    if salary <= 49020 then float salary * 0.15
    elif salary <= 98040 then (49020.0 * 0.15) + (float (salary - 49020) * 0.205)
    elif salary <= 151978 then (49020.0 * 0.15) + (49020.0 * 0.205) + (float (salary - 98040) * 0.26)
    elif salary <= 216511 then (49020.0 * 0.15) + (49020.0 * 0.205) + (53938.0 * 0.26) + (float (salary - 151978) * 0.29)
    else (49020.0 * 0.15) + (49020.0 * 0.205) + (53938.0 * 0.26) + (64533.0 * 0.29) + (float (salary - 216511) * 0.33)

let taxes = List.map calculateTax salaries
printfn "Taxes for each salary: %A" taxes

// C) Increase salaries less than 49,020 by 20,000
let updatedSalaries = salaries |> List.map (fun s -> if s < 49020 then s + 20000 else s)
printfn "Updated Salaries: %A" updatedSalaries

// D) Sum salaries between 50,000 and 100,000 using reduce/fold
let sumMidRangeSalaries = 
    salaries 
    |> List.filter (fun s -> s >= 50000 && s <= 100000) 
    |> List.fold (+) 0
printfn "Sum of Mid-Range Salaries: %d" sumMidRangeSalaries