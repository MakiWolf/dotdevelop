dotnet restore

msbuild external/fsharpbinding/.paket/paket.targets /t:RestorePackages /p:PaketReferences="external\fsharpbinding\MonoDevelop.FSharpBinding\paket.references"

msbuild Main.sln /p:Configuration=DebugGnome /p:PLATFORM='Any CPU'
