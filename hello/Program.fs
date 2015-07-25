[<EntryPoint>]
let main argv = 
    let name = argv.[0]
    let greeting = Hello.greet name
    printfn "%s" greeting
    0 // return an integer exit code