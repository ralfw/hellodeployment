module hello.body.tests

open System
open NUnit.Framework

[<Test>]
let greet_by_name() =
    Assert.AreEqual("Hello, Peter", (Hello.greet "Peter"))