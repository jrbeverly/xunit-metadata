#!/bin/sh
command -v dotnet >/dev/null 2>&1 || { echo >&2 "The script requires 'dotnet' but it's not installed.  Aborting."; exit 1; }
DIR_BUILD=$(dirname "$(readlink -f "$0")")
set -ev

sh "$DIR_BUILD/build.sh"
sh "$DIR_BUILD/test.sh"
sh "$DIR_BUILD/package.sh"