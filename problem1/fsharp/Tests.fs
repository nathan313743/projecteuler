namespace Fsharp
open Microsoft.VisualStudio.TestTools.UnitTesting

module Problem1 =
    let result = 
        [1..999] 
        |> List.filter (fun i -> i % 5 = 0 || i % 3 = 0 ) 
        |> List.sum

[<TestClass>]
type TestClass () =

    [<TestMethod>]
    member this.Problem1_ValueIsExpected () =
        let result = Problem1.result
        Assert.AreEqual(233168, result);
