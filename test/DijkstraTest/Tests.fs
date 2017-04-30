module Tests

open System
open Xunit
open Dijkstra

[<Fact>]
let ``noGraph should have noPath`` () =
    Assert.Equal("{}0", PathFinder.minPath "" "A" "B")
