module Tests

open System
open Xunit
open Dijkstra

let assertPath graph expect =
    Assert.Equal(
        expect,
        PathFinder.minPath graph "A" "Z"
    )

[<Fact>]
let ``noGraph should have noPath`` () =
    assertPath "" "{}0"
