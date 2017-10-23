#!/bin/sh
command -v docker >/dev/null 2>&1 || { echo >&2 "The script requires 'docker' but it's not installed.  Aborting."; exit 1; }
DIR_REPO=$(dirname "$(dirname "$(readlink -f "$0")")")
set -ev

docker run --rm \
    -v "$DIR_REPO":/media \
    --workdir /media \
    microsoft/dotnet:latest sh build/pipeline.sh