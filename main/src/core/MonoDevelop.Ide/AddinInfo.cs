
using System;
using Mono.Addins;

[assembly:AddinRoot ("Ide", 
            Namespace = "MonoDevelop", 
            Version = MonoDevelop.BuildInfo.Version,
            CompatVersion = MonoDevelop.BuildInfo.CompatVersion,
            Category = "DotDevelop Core")]

[assembly:AddinName ("DotDevelop Ide")]
[assembly:AddinDescription ("The DotDevelop IDE application")]

[assembly:AddinDependency ("Core", MonoDevelop.BuildInfo.Version)]
