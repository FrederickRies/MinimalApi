# PlaygroundMinimalApi
Here is a little playground around the last evolutions of C# 10 

https://github.com/dotnet/roslyn/blob/main/docs/Language%20Feature%20Status.md

## Global usings
Inheritance of using declarations in all project files
https://github.com/dotnet/csharplang/issues/3428
```csharp
global using Api;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Hosting;
global using System;
```
## Null parameters validation
https://github.com/dotnet/csharplang/issues/2145

## Interpolation in const strings
https://github.com/dotnet/csharplang/issues/2951
