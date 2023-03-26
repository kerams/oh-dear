module T

open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Configs
open System.Runtime.CompilerServices

[<MemoryDiagnoser>]
type Current () =

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let o = Some 10

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let vo = ValueSome 10

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let r = Result<int, string>.Ok 10

    [<Benchmark>]
    member _.Option() =
        match o with
        | Some x -> Some (x + 3)

    [<Benchmark>]
    member _.Voption() =
        match vo with
        | ValueSome x -> ValueSome (x + 3)

    [<Benchmark>]
    member _.Result() =
        match r with
        | Ok x -> Result<int, string>.Ok (x + 3)

BenchmarkDotNet.Running.BenchmarkRunner.Run (
    typeof<Current>.Assembly,
    DefaultConfig.Instance.WithOption (ConfigOptions.JoinSummary, true))
|> ignore