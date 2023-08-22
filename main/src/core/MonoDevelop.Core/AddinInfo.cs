
using System;
using Mono.Addins;

[assembly:AddinRoot ("Core", 
        Namespace = "MonoDevelop", 
        Version = MonoDevelop.BuildInfo.Version,
        CompatVersion = MonoDevelop.BuildInfo.CompatVersion,
        Category = "DotDevelop Core")]

[assembly:AddinName ("DotDevelop Runtime")]
[assembly:AddinDescription ("Provides the core services of the DotDevelop platform")]
