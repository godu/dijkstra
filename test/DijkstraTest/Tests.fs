module Tests

open System
open Xunit
open Dijkstra

let assertMinPath graph length path =
    match length with
    | Some l ->
        Assert.Equal(
            l,
            PathFinder.minLength graph "A" "Z"
        )
    | None -> ()
    match path with
    | Some p ->
        Assert.Equal(
            p,
            PathFinder.minPath graph "A" "Z"
        )
    | None -> ()

[<Theory>]
[<InlineData("")>]
[<InlineData("A")>]
[<InlineData("B1C")>]
[<InlineData("A1C")>]
[<InlineData("B1Z")>]
let ``should support degenerate cases`` graph =
    assertMinPath graph (Some 0) (Some "{}")
