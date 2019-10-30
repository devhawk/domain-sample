<!-- markdownlint-enable -->
# Neo Blockchain Toolkit - Domain Sample

This repo contains the [Domain Smart Contract sample](https://github.com/neo-project/examples/tree/0ab03a0ed5e1e331b756d9ad51b01657385470c7/csharp/Domain)
with additional assets that can be used with the
[Neo Blockchain Toolkit](https://marketplace.visualstudio.com/items?itemName=ngd-seattle.neo-blockchain-toolkit).
This readme covers the basics of how to use emulated storage for the 
[Neo Smart Contract Debugger](https://github.com/neo-project/neo-debugger).

## Prerequisites

- [.NET Core 2.2 SDK](https://dotnet.microsoft.com/download/dotnet-core/2.2)
- [Visual Studio Code (v1.37 or later)](https://code.visualstudio.com/Download)
- [NEON-DE compiler](https://www.nuget.org/packages/Neo.neon-de/2.4.1.1)
- [Neo Smart Contract Debugger](https://github.com/neo-project/neo-debugger)

Further instructions on installing the NEON-DE compiler and Neo Smart
contract debugger are available in the
[Neo Blockchain Toolkit Quickstart](https://github.com/ngdseattle/neo-blockchain-toolkit/blob/master/quickstart.md#installation)

## Emulated Storage

Neo Smart Contracts can store key/value byte array pairs in storage for
later access. The Neo Smart Contract Debugger provides an emulated storage
service for contracts being debugged to get, put and delete key/value pairs
similar to how a real Neo blockchain instance works. However, the debugger
stores these storage updates in memory and they are discarded at the end
of the debugging session. Additionally, pre-existing storage data can be
specified in the launch.json file.

This sample contract demonstrates a simple DNS-style registry. Records can
be retrieved, updated and deleted. The launch.json file included in this
repository demonstrates how to configure emulated storage.

There are four profiles in [launch.json](.vscode\launch.json) for this contract:

- **query empty** - query for a record when storage is empty
- **query full** - query for a record when storage contains a relevant record
  for that key
- **register succeed** - create a record when storage is empty
- **register fail** - create a record when storage already contains a relevant record
  for that key
