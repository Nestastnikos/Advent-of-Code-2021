open System.IO

let toInt boolValue =
  match boolValue with
  | true -> 1
  | false -> 0

let numOfIncreases =
  File.ReadAllLines("day-01-input.txt")
  |> Seq.map(fun x -> int x)
  |> Seq.pairwise
  |> Seq.map(fun (a,b) -> toInt(a < b))
  |> Seq.sumBy(fun x -> x)

printfn "Number of detected increases: %d" numOfIncreases


// part 2
let getDistinctElements first second =
  let a, b = first
  let c, d = second
  a, b, d

let numOfIncreases3Sum =
  File.ReadAllLines("day-01-input.txt")
  |> Seq.map(fun x -> int x)
  |> Seq.pairwise
  |> Seq.pairwise
  |> Seq.map(fun (a,b) -> getDistinctElements a b)
  |> Seq.map(fun (a,b,c) -> a + b + c)
  |> Seq.pairwise
  |> Seq.map(fun (a,b) -> toInt(a < b))
  |> Seq.sumBy(fun x -> x)

printfn "Number of detected increases when sum of 3: %d" numOfIncreases3Sum