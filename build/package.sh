#!/bin/sh
command -v dotnet >/dev/null 2>&1 || { echo >&2 "The script requires 'dotnet' but it's not installed.  Aborting."; exit 1; }
DIR_REPO=$(dirname "$(dirname "$(readlink -f "$0")")")
set -ev

dotnet pack \
    --no-build \
    --configuration Release \
    --output "${DIR_REPO}/artifacts" \
    --verbosity minimal \
    "${DIR_REPO}/src/Xunit.Metadata/Xunit.Metadata.csproj" 