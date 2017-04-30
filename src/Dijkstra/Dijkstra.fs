namespace Dijkstra

type Edge = {
    BeginNode : string;
    EndNode : string;
    Length : int
}

type Graph = {
    Edges : Edge list
}



module PathFinder =
    open System.Text.RegularExpressions

    let EmptyGrap = { Edges = [] }

    let addEdge edge graph =
        {graph with Edges = (List.append graph.Edges [edge])}

    let EdgeExpression = "(\\D+)(\\d+)(\\D+)"

    let (|ParseRegex|_|) regex str =
        let m = Regex(regex).Match(str);
        if m.Success
        then Some (List.tail [ for x in m.Groups -> x.Value ])
        else None

    let createGraph graphExpression =
        match graphExpression with
        | ParseRegex EdgeExpression [beginNode; length; endNode]
            -> addEdge { BeginNode = beginNode; EndNode = endNode; Length = int length } EmptyGrap
        | _ -> EmptyGrap


    let minPath graph beginNode endNode =
        "{}"

    let minLength graph beginNode endNode =
        List.fold
            (fun acc edge -> acc + edge.Length)
            0
            graph.Edges