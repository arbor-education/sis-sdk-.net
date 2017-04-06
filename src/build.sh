#! /bin/bash

pev -v >/dev/null 2>&1 || { echo >&2 "Script requires 'pev' but it's not installed.  Aborting."; exit 1; }

if [ ! -f bin/Debug/ArborSdk.dll ]; then
    echo "Required dll file not found! Build project first."
fi

# Get an assemby version from dll using 'pev'
ASSEMBLY_VERSION=$(pev -p bin/Debug/ArborSdk.dll )
cp bin/Debug/ArborSdk.dll Build/lib/ArborSdk.$ASSEMBLY_VERSION.dll

echo "Build file added"
