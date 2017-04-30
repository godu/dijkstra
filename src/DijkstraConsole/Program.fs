// Learn more about F# at http://fsharp.org

open System
open Dijkstra

[<EntryPoint>]
let main argv =
    printfn "%s" (PathFinder.minPath "" "A" "B")
    0 // return an integer exit code
