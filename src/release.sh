#! /bin/bash

# This script builds SDK NET project and uploads build file (ZIP archive) to the
# developer portal. Versioning is done automatically.

pev -v >/dev/null 2>&1 || { echo >&2 "Script requires 'pev' but it's not installed.  Aborting."; exit 1; }
mdtool -q >/dev/null 2>&1 || { echo >&2 "Script requires 'mdtool' but it's not installed.  Aborting."; exit 1; }

echo "Building project..."
mdtool -v build "--configuration:ArborRelease" ../ArborSdkDotNet.sln

# Get an assemby version from dll using 'pev'
ASSEMBLY_VERSION=$(pev -p bin/Debug/ArborSdk.dll )

# Set new name for build file
BUILD_SOURCE_PATH=Build/source/examples
BUILD_LIB_PATH=Build/lib
BUILD_FILE_NAME=Build-$ASSEMBLY_VERSION.zip


echo "Copying files..."
cp -r ../examples/ Build/source
cp bin/Debug/ArborSdk.dll Build/lib

# Remove unnecessary files befor zip
rm $BUILD_SOURCE_PATH/bin/Debug/ArborSdk.dll
rm $BUILD_SOURCE_PATH/bin/Debug/*.mdb
rm $BUILD_SOURCE_PATH/bin/Debug/*.exe
rm $BUILD_SOURCE_PATH/bin/Debug/.gitignore
rm $BUILD_SOURCE_PATH/bin/Release/.gitignore


zip -9 -r $BUILD_FILE_NAME Build

echo "Sending build file to the developers portal..."
scp $BUILD_FILE_NAME crm.arbor.sc:web/sites/DeveloperPortal/public/sdk-download/net

# Remove current build because of git (we don't want it as new file in repository)
rm $BUILD_FILE_NAME

exit
