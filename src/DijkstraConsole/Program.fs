// Learn more about F# at http://fsharp.org

open System
open Dijkstra

[<EntryPoint>]
let main argv =
    let graph = PathFinder.createGraph ""
    printfn
        "%s %d"
        (PathFinder.minPath "" "A" "B")
        (PathFinder.minLength graph "A" "B")
    0 // return an integer exit code
