#!/bin/bash

export SDK=iphoneos15.4

function bind {
    echo "$1 artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/"

    if [ $3 == '1' ]
    then
        sharpie bind --sdk=$SDK \
            --output="libs/$1.iOS" \
            --namespace="$1" \
            --scope="$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/" \
            "$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/$2.h"
    elif [ $3 == '2' ]
    then
        sharpie bind --sdk=$SDK \
            --output="libs/$1.iOS" \
            --namespace="$1" \
            --scope="$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/" \
            "$PWD/artifacts/$2.xcframework/ios-arm64_armv7/$2.framework/Headers/$2.h"
    else
        sharpie bind --sdk=$SDK \
            --output="libs/$1.iOS" \
            --namespace="$1" \
            --scope="$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/" \
            "$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/$2-Swift.h"
    fi
}

# bind MapboxMaps MapboxMaps 0
bind MapboxMapsObjC MapboxMapObjC 0
# bind MapboxCoreMaps MapboxCoreMaps 1
# bind MapboxMobileEvents MapboxMobileEvents 1
# bind MapboxCommon MapboxCommon 2