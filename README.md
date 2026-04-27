# SourceGenerator.CSharp.Templates

A `dotnet new` project template for C# Source Generator development — skip the boilerplate, start writing your generator immediately.

## Why This Template?

Setting up a source generator project from scratch requires non-trivial configuration: targeting `netstandard2.0`, referencing the correct Roslyn packages, configuring `PrivateAssets`, and wiring up a test project. Without a template, every developer repeats this from memory and risks getting it slightly wrong.

This template encodes those best practices as defaults, so you start from a correct foundation every time.

## Requirements

- .NET SDK 6.0 or later

## Installation

```bash
dotnet new install SourceGenerator.CSharp.Templates
```

## Usage

```bash
dotnet new csharp-sg -n MySourceGenerator
```

This scaffolds a ready-to-use source generator project with the correct structure and configuration.

## What's Included

- Source generator project targeting `netstandard2.0`
- Roslyn analyzer package references with `PrivateAssets` configured correctly
- Unit test project pre-wired for generator testing

## License

[MIT](LICENSE)
