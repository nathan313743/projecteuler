namespace Problem2

open Microsoft.VisualStudio.TestTools.UnitTesting

module Problem2 =

    let rec fibRec x y=
        let current = x + y
        
        match current with
        | _ when current >= 4000000 -> []
        | _ -> current::fibRec y current
    
    let summedResult x y =
        fibRec x y 
        |> List.filter(fun i -> i % 2 = 0)
        |> List.sum

[<TestClass>]
type TestClass () =

    [<TestMethod>]
    member this.FibTest () =
        let result =  Problem2.summedResult 0 1
        Assert.AreEqual(4613732, result);
