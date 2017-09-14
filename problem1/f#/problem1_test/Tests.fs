namespace Problem1_Test
open Problem1
open System
open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type Problem1_Test () =

    [<TestMethod>]
    member this.Problem1_ValueIsExpected () =
        let result = Problem1.result
        Assert.AreEqual(233168, result);
