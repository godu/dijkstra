module Tests

open System
open Xunit
open Dijkstra

[<Fact>]
let ``Say.hello should return hello foo`` () =
    Assert.Equal("Hello foo", Say.hello "foo")
