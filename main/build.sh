dotnet restore

dotnet restore external/vs-editor-api
dotnet restore external/Xamarin.PropertyEditing/Xamarin.PropertyEditing

msbuild external/fsharpbinding/.paket/paket.targets /t:RestorePackages /p:PaketReferences="external\fsharpbinding\MonoDevelop.FSharpBinding\paket.references"
cd external/fsharpbinding
mono .paket/paket.exe restore
cd ..
cd ..
msbuild Main.sln /p:Configuration=DebugGnome /p:PLATFORM='Any CPU'
