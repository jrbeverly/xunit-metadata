#!/bin/sh
command -v dotnet >/dev/null 2>&1 || { echo >&2 "The script requires 'dotnet' but it's not installed.  Aborting."; exit 1; }
DIR_REPO=$(dirname "$(dirname "$(readlink -f "$0")")")
set -ev

dotnet restore \
    "$DIR_REPO/sln/Build.sln"

dotnet build \
    --configuration Release \
    --verbosity minimal \
    "$DIR_REPO/sln/Build.sln"