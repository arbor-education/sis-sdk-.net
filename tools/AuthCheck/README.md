# Arbor API authentication check

A small command-line utility that answers one question: **can this
`applicationUsername` and `dpt_token` authenticate against the Arbor REST
API?**

It checks this by issuing a `GET` through `Arbor.Api.Gateway.RestGateway` — the
SDK's own gateway class, the one integrators use. The request is built and sent
by the SDK, so a pass means the SDK authenticates, not merely that the
credentials are valid somewhere else.

It reads `/students` by default, and any of the SDK's other 859 resource types
with `--resource`.

## Prerequisites

You need the `dotnet` command. On macOS:

```bash
brew install dotnet
```

That is the only setup step. Unlike the rest of this repository, this tool does
not need MSBuild, Mono, Visual Studio or a NuGet restore.

## Usage

From the repository root:

```bash
dotnet run --project tools/AuthCheck -- \
  --url https://myschool.uk.arbor.sc \
  --application-username my-application
```

You will be prompted for the `dpt_token`, which is not echoed. Pass
`--dpt-token` instead if you need it non-interactive, though note that puts the
token in your shell history.

### Credential naming

The two values Arbor issues you are named here exactly as Arbor names them:

| This tool | Purpose |
| --------- | ------- |
| `--application-username` | The `applicationUsername` |
| `--dpt-token` | The `dpt_token` |

Both flags also accept the verbatim Arbor spellings, `--applicationUsername`
and `--dpt_token`, so you can paste either form.

They are sent as HTTP Basic credentials: the `applicationUsername` in the user
field and the `dpt_token` in the password field. The SDK's own
`RestGateway` constructor calls its parameters `authUser` and `authPassword`,
which is left untouched — only this tool and this document use the Arbor names.

`--url` wants the Arbor site root. A trailing slash, a missing `https://`, or an
accidental `/rest-v2` suffix are all handled for you.

Run `dotnet run --project tools/AuthCheck -- --help` for all options.

## Checking a different entity

`--resource` (also spelled `--entity`, or `-r`) switches the endpoint:

```bash
dotnet run --project tools/AuthCheck -- \
  --url https://myschool.uk.arbor.sc \
  --application-username my-application --resource Staff
```

Any of these spellings work, case-insensitively, so you do not have to remember
which form a given place uses:

| Form | Example |
| ---- | ------- |
| SDK resource name | `AcademicUnit` |
| SDK constant name | `ACADEMIC_UNIT` |
| URL segment | `academic-units` |
| Separators ignored | `academic unit`, `academicunit` |

A name that does not exist is rejected before any request is made, with
suggestions:

```text
Error: 'Pupil' is not a resource type the SDK defines. Close matches:
UkDfe_PupilPremiumRecipient, ... Use --list-resources to see all 860.
```

### Finding the right name

`--list-resources` prints every resource type with the exact URL it maps to, and
takes an optional search term:

```bash
dotnet run --project tools/AuthCheck -- --list-resources enrolment
```

```text
Resource types matching 'enrolment' (17 of 860):

  AcademicUnitEnrolment        ->  /rest-v2/academic-unit-enrolments
  AcademicYearEnrolment        ->  /rest-v2/academic-year-enrolments
  ...
```

The list is read by reflection from the SDK's own `ResourceType` classes
(`Arbor.Resource`, `Arbor.Resource.UkDfe`, `Arbor.Resource.Finance`), so
resources added to the SDK appear here automatically.

**Check the URL in that listing if you get a 404.** The path is derived by the
SDK's `PluralizeFilter`, which is naive: `Staff` becomes `/rest-v2/staffs`, and
module resources keep an underscore, as in
`/rest-v2/uk-dfe_local-authorities`. The listing shows exactly what will be
requested, so you can see the path before you run the check.

### Scripted use

Credentials can come from the environment instead of the command line, which
keeps them out of both the argument list and shell history:

```bash
export ARBOR_API_URL=https://myschool.uk.arbor.sc
export ARBOR_APPLICATION_USERNAME=my-application
export ARBOR_DPT_TOKEN=...
dotnet run --project tools/AuthCheck
```

The exit code is usable as a check in a script or CI job:

| Code | Meaning |
| ---- | ------- |
| 0 | Authenticated successfully |
| 1 | Authentication failed (401) or authorisation refused (403) |
| 2 | Bad usage or missing configuration |
| 3 | Network, DNS, TLS or timeout failure |
| 4 | Reached the API but the request was refused |

## Reading the result

A pass looks like this:

```text
Gateway:  Arbor.Api.Gateway.RestGateway  (SDK version 0.0.0-dev)
Resource: Student  (STUDENT)
GET       https://myschool.uk.arbor.sc/rest-v2/students?page-size=1
Auth:     HTTP Basic, applicationUsername 'my-application'

  Completed in 340ms

  AUTH OK  -  the gateway authenticated and read /students.

  Returned 1 student record(s).

PASS
```

Some outcomes are worth spelling out:

- **`AUTH OK` with 0 records returned is still a pass.** Authentication is what
  is under test; an empty list means the credentials worked and the site has no
  students matching the query.
- **`AUTHENTICATED, NOT AUTHORISED` (403) means the `dpt_token` is right.** The
  application simply lacks permission on the data. This is a permissions change
  in Arbor, not a credentials problem.
- **`AUTH OK, CANNOT MODEL RESOURCE` is also a pass.** The API returned records,
  so the credentials are good, but the SDK has no model class to turn them into
  objects. See the limitations below.
- **`NOT THE API`** means something answered but not with JSON, which usually
  means `--url` is not the API root, or a sign-in/SSO page sits in front of it.
  Authentication is genuinely unknown in this case, so it is not reported as
  either a pass or an auth failure.

By default only the number of records is printed, never their contents, so
student personal data stays off your terminal. `--verbose` additionally prints
the returned resource URLs (for example `/rest-v2/students/1`) and full
exception detail; it never prints the `dpt_token` or the encoded auth header.

## Requesting only one record

The default `--page-size 1` is deliberate: it is enough to prove authentication
while pulling as little real data as possible. Raise it only if you want to see
more.

## How this fits with the rest of the repository

- `tools/AuthCheck` — this utility.
- `tools/ArborSdk.Modern` — a build shim, not a fork. It compiles the exact same
  sources as `src/ArborSdk.csproj` (`src/Arbor/**/*.cs`) against modern .NET, so
  the gateway can be run without MSBuild or Mono. Nothing is copied or
  duplicated; new files under `src/Arbor` are picked up automatically.

Neither project is part of `ArborSdkDotNet.sln`, which targets .NET Framework
4.5.1 and would not load them. Building or packaging the SDK is unaffected.

## Resources the SDK cannot read back

All 71 `Finance_*` resource types are declared in
`Arbor.Resource.Finance.ResourceType`, but the SDK ships no matching model
classes — there is no `src/Arbor/Model/Finance/` directory at all. When such a
resource returns records, `RestGateway.instantiateModel` passes a null `Type` to
`Activator.CreateInstance` and throws `ArgumentNullException`
(`src/Arbor/Api/Gateway/RestGateway.cs:156`).

This tool detects that case ahead of the request, says so up front, and reports
the outcome as an authentication pass, because the failure happens only after a
successful authenticated response. Affected resources are flagged
`[no model class]` in `--list-resources`.

The 717 non-module resources all have model classes, and for those
`RestGateway` falls back to `ModelBase` anyway, so they are unaffected.

## Limitations inherited from the SDK

These are properties of `RestGateway`, not of this tool. They are listed because
they shape what the output can tell you, and each is a candidate for a small
follow-up fix in the SDK.

1. **HTTP status codes are largely lost.** `ServerErrorException` carries only a
   message string, with no status code and no inner exception
   (`src/Arbor/Api/ServerErrorException.cs`). This tool therefore has to
   recognise `401` and `403` from the message text, and where it cannot, it
   reports the gateway's message verbatim rather than guessing. A `5xx` often
   arrives with no status at all, which is why it is reported as
   "the status code could not be determined".

2. **Connection failures surface as `NullReferenceException`.**
   `RestGateway.sendRequest` reads `ex.Response.ContentLength` without checking
   whether `ex.Response` is null (`src/Arbor/Api/Gateway/RestGateway.cs:411`).
   For a DNS failure, refused connection or TLS error, `WebException.Response`
   *is* null, so the real cause is replaced by a null dereference. This tool
   catches that and explains it, but the underlying fix belongs in the SDK.

3. **TLS certificate validation is disabled for the whole process.**
   `RestGateway.sendRequest` assigns a `ServerCertificateValidationCallback`
   that accepts every certificate (`RestGateway.cs:374`), and it appends to a
   static, process-wide hook. Any application that constructs a `RestGateway`
   therefore stops validating HTTPS certificates everywhere, which exposes it to
   interception. This tool deliberately has no `--insecure` flag because there
   would be nothing for it to opt into. **This is worth raising as a security
   issue against the SDK independently of this utility.**

4. **There is no request timeout.** The SDK never sets one, so a wedged
   connection would hang indefinitely. This tool enforces `--timeout` itself by
   running the gateway call on a worker thread and exiting if it overruns; the
   abandoned request dies with the process.

## One fidelity caveat

`RestGateway` encodes the Basic credentials with `Encoding.Default`
(`RestGateway.cs:378`). That is the machine's ANSI code page on .NET Framework
but always UTF-8 on modern .NET, so for a `dpt_token` or `applicationUsername`
containing non-ASCII characters this tool could send different bytes than the
shipped .NET Framework build would. The two are identical for ASCII
credentials, which covers the normal case. If you are testing a credential with
accented or non-Latin characters and see an unexpected 401, that difference is
a plausible cause and is itself a latent bug in the SDK.
