namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FSharp.Graphics.OpenGL")>]
[<assembly: AssemblyProductAttribute("FSharp.Graphics.OpenGL")>]
[<assembly: AssemblyDescriptionAttribute("F# OpenGL bindings")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
