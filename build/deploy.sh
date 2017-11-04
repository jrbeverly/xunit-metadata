#!/bin/sh
command -v dotnet >/dev/null 2>&1 || { echo >&2 "The script requires 'dotnet' but it's not installed.  Aborting."; exit 1; }
[ -z "$NugetAPIKey" ] && { echo >&2 "The script requires 'NugetAPIKey' but the environment variable is not set.  Aborting."; exit 1; }
[ -z "$NugetSource" ] && { echo >&2 "The script requires 'NugetSource' but the environment variable is not set.  Aborting."; exit 1; }
DIR_REPO=$(dirname "$(dirname "$(readlink -f "$0")")")
set -ev

dotnet nuget push \
    --source "${NugetSource}" \
    --api-key "${NugetAPIKey}" \
    "$DIR_REPO/artifacts/"*.nupkg