dotnet restore

dotnet restore external/vs-editor-api
dotnet restore external/Xamarin.PropertyEditing/Xamarin.PropertyEditing

msbuild external/fsharpbinding/.paket/paket.targets /t:RestorePackages /p:PaketReferences="external\fsharpbinding\MonoDevelop.FSharpBinding\paket.references"

msbuild Main.sln /p:Configuration=DebugGnome /p:PLATFORM='Any CPU'
