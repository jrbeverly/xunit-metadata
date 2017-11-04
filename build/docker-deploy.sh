#!/bin/sh
command -v docker >/dev/null 2>&1 || { echo >&2 "The script requires 'docker' but it's not installed.  Aborting."; exit 1; }
[ -z "$NugetAPIKey" ] && { echo >&2 "The script requires 'NugetAPIKey' but the environment variable is not set.  Aborting."; exit 1; }
[ -z "$NugetSource" ] && { echo >&2 "The script requires 'NugetSource' but the environment variable is not set.  Aborting."; exit 1; }
DIR_REPO=$(dirname "$(dirname "$(readlink -f "$0")")")
set -ev

docker run --rm \
    -v "$DIR_REPO":/media \
    -e NugetAPIKey="${NugetAPIKey}" \
    -e NugetSource="${NugetSource}" \
    --workdir /media \
    microsoft/dotnet:latest sh build/deploy.sh