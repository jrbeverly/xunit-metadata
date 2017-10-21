#!/bin/sh
command -v dotnet >/dev/null 2>&1 || { echo >&2 "The script requires 'dotnet' but it's not installed.  Aborting."; exit 1; }

#
# Variables
#
DIR=$(dirname "$(readlink -f "$0")")
DIR_ROOT=$(dirname "$DIR")
DIR_ARTIFACT="$DIR_ROOT/artifacts"
DIR_SRC="$DIR_ROOT/src"

#
# Main
#
dotnet pack "$DIR_SRC/Xunit.Metadata/Xunit.Metadata.csproj" --output "$DIR_ARTIFACT"