// Learn more about F# at http://fsharp.org

open System
open NumberOperations

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    printfn "%f" (Exponential.SquareNumber (3.0))
    printfn "%f" (Exponential.Exponent (3.0, 2.0))
    printfn "%s" (Exponential.GetPercentageString(50.0, 100.0));
    printfn "%s" (Exponential.GetPercentageString(23.4, 300.0));
    0 // return an integer exit code