#!/bin/sh
for D in *; do
  if [ -d "${D}" ]; then
    cd "${D}"

    FILE=coverlet.sh
    
    if [ -f "$FILE" ]; then
      ./coverlet.sh
    fi
    cd ..
  fi
done
