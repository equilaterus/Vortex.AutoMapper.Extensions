# Vortex AutoMapper Extensions

[Vortex Extensions](https://github.com/equilaterus/Vortex) to facilitate its use with AutoMapper including *extension methods* for **IMapper** that return mapped data wrapped directly into a *Vortex's Monad/Functor* **Maybe**.

```csharp
using Equilaterus.Vortex.AutoMapper.Extensions;
...

// Returns IMaybe<DestinationType>
var maybeResult = IMapper.MaybeMap<DestinationType>(sourceEntity);
```

For a complete sample [check our wiki](https://github.com/equilaterus/Vortex/wiki/Extensions#vortex-automapper-extensions).

## Builds

* **Release**

  [![Build status](https://ci.appveyor.com/api/projects/status/y456647c6fronpbw/branch/release?svg=true)](https://ci.appveyor.com/project/pipecaniza/vortex-automapper-extensions/branch/master) [![nuget](https://img.shields.io/nuget/v/Equilaterus.Vortex.AutoMapper.Extensions.svg)](https://www.nuget.org/packages/Equilaterus.Vortex.AutoMapper.Extensions/)

* **Master**

  [![Build status](https://ci.appveyor.com/api/projects/status/y456647c6fronpbw/branch/master?svg=true)](https://ci.appveyor.com/project/pipecaniza/vortex-automapper-extensions/branch/master)

* **Dev** Unstable

  [![Build status](https://ci.appveyor.com/api/projects/status/y456647c6fronpbw/branch/dev?svg=true)](https://ci.appveyor.com/project/pipecaniza/vortex-automapper-extensions/branch/dev)

## Releases

* Download [nuget package](https://www.nuget.org/packages/Equilaterus.Vortex.AutoMapper.Extensions/)  

* Download [source code](https://github.com/equilaterus/Vortex.AutoMapper.Extensions/releases)

* See [version change log](https://github.com/equilaterus/Vortex/wiki/Version-change-log)


## Links

* [Vortex AutoMapper Extensions Wiki](https://github.com/equilaterus/Vortex/wiki/Extensions#vortex-automapper-extensions)

* [Vortex Repo](https://github.com/equilaterus/Vortex)