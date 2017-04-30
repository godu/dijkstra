module Tests

open System
open Xunit
open Dijkstra

let assertMinPath graph length path =
    Assert.Equal(
        length,
        PathFinder.minLength graph "A" "Z"
    )
    Assert.Equal(
        path, 
        PathFinder.minPath graph "A" "Z"
    )

[<Fact>]
let ``noGraph should have noPath`` () =
    assertMinPath "" 0 "{}"