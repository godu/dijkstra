module Tests

open System
open Xunit
open Dijkstra

let assertMinPath graphExpression length path =
    let graph = PathFinder.createGraph graphExpression
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
            PathFinder.minPath graphExpression "A" "Z"
        )
    | None -> ()

[<Theory>]
[<InlineData("", 0)>]
[<InlineData("A", 0)>]
[<InlineData("B1C", 1)>]
[<InlineData("A1C", 1)>]
[<InlineData("B1Z", 1)>]
let ``should support degenerate cases`` graphExpression length =
    assertMinPath graphExpression (Some length) (Some "{}")

[<Fact>]
let ``should support one edge graph`` () =
    assertMinPath "A1Z" (Some 1) None
