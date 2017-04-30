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

[<Theory>]
[<InlineData("")>]
[<InlineData("A")>]
[<InlineData("B1C")>]
[<InlineData("A1C")>]
[<InlineData("B1Z")>]
let ``should support degenerate cases`` graph =
    assertMinPath graph 0 "{}"
