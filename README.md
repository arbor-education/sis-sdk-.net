# Arbor .NET SDK

This repository contains the Arbor SDK for .NET Framework. It provides models,
queries, API gateway classes, and helper services for working with the Arbor
REST API.

The SDK is a legacy, non-SDK-style project targeting .NET Framework 4.5.1. The
main output is `ArborSdk.dll`; the repository also contains C# and VB.NET
example applications.

## Repository structure

- `src/` — SDK source and `ArborSdk.csproj`.
- `examples/` — C# console example.
- `ArborSdkVbExamplets/` — VB.NET console example.
- `.github/workflows/` — package, lint, publish, and security workflows.

## Requirements

The project uses `packages.config`, so dependencies must be restored before it
is built.

On Windows, use:

- Visual Studio Build Tools 2022 or Visual Studio 2022 with MSBuild.
- A current NuGet CLI available on `PATH`.

The repository restores the .NET Framework 4.5.1 reference assemblies from
NuGet, so the old 4.5.1 Developer Pack does not need to be installed separately.

## Restore and build on Windows

From the repository root:

```powershell
nuget restore ArborSdkDotNet.sln
msbuild src\ArborSdk.csproj /p:Configuration=Debug
```

The SDK assembly is written to:

```text
src\bin\Debug\ArborSdk.dll
```

To build the C# example:

```powershell
msbuild examples\ArborSdkExamples.csproj /p:Configuration=Debug
```

## Restore and build on Fedora

Install Mono and download a current NuGet CLI. Fedora's packaged NuGet client
is too old for the dependencies used by this project.

```bash
sudo dnf install mono-devel curl
curl -L https://dist.nuget.org/win-x86-commandline/latest/nuget.exe -o /tmp/nuget.exe
mono /tmp/nuget.exe restore ArborSdkDotNet.sln
xbuild src/ArborSdk.csproj /p:Configuration=Debug
```

To build the VB.NET example as part of the solution, also install `mono-basic`:

```bash
sudo dnf install mono-basic
```

## Create NuGet packages

Restore dependencies first, then run:

```powershell
nuget pack src/ArborSdk.csproj -Build -Symbols -SymbolPackageFormat snupkg
```

This creates the main `.nupkg` and symbol `.snupkg` in the repository root.
Publishing is handled by `.github/workflows/publish.yaml` when a tag is pushed.

## Run the C# example

Copy the example configuration template:

```bash
cp examples/config-dist.xml examples/config.xml
```

Set the Arbor API base URL, username, and password in `examples/config.xml`.
This file contains credentials and must not be committed.

Build the example and run it from its output directory:

```bash
xbuild examples/ArborSdkExamples.csproj /p:Configuration=Debug
cd examples/bin/Debug
MONO_IOMAP=all mono ArborSdkExamples.exe
```

On Windows, run `ArborSdkExamples.exe` from `examples\bin\Debug` instead. The
sample API calls in `examples/Main.cs` are commented out by default; enable only
the calls needed for your test environment.

## Basic usage

```csharp
using Arbor.Api.Gateway;
using Arbor.Model;
using Arbor.Resource;

var gateway = new RestGateway(baseUrl, username, password);
var student = (Student)gateway.retrieve(ResourceType.STUDENT, "1");
```

Use credentials for an appropriate non-production Arbor environment while
developing. Some SDK methods create, update, or delete API resources.

## Validation

The repository currently has no automated unit test suite. Changes should at
minimum be validated by:

1. Restoring all NuGet dependencies.
2. Building `src/ArborSdk.csproj`.
3. Building the example projects where relevant.
4. Creating and inspecting the NuGet package.
5. Running focused API smoke tests for changed serialization or model behavior.

## License

This project is licensed under the terms in [LICENSE](LICENSE).
