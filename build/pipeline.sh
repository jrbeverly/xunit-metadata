#!/bin/sh
command -v dotnet >/dev/null 2>&1 || { echo >&2 "The script requires 'dotnet' but it's not installed.  Aborting."; exit 1; }
DIR_REPO=$(dirname "$(dirname "$(readlink -f "$0")")")
set -ev

rm -rf "$DIR_REPO/artifacts/"
mkdir -p "$DIR_REPO/artifacts/"

sh "$DIR_REPO/build/build.sh"
sh "$DIR_REPO/build/test.sh"
sh "$DIR_REPO/build/package.sh"