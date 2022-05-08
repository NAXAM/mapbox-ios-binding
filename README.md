# Mapbox for Xamarin.iOS
A Xamarin.iOS binding library for [Mapbox](https://www.mapbox.com/ios-sdk/) library.

## About
This project is maintained by [tuyen-vuduc](https://github.com/tuyen-vuduc).<br> 
At the momment, I don't have free time to contribute to the project, but if there is a paid request, I am happy to talk to.

## Installation

```
Install-Package MapboxMaps.iOS
```

## Usage

- 1) How to use: Please follow the official guide [here](https://www.mapbox.com/ios-sdk/).
- 2) Atm, Xamarin.iOS not officially support XCFramework for a binding library yet: please download and include xcframeworks to your iOS project as below example
```
  <ItemGroup>
    <NativeReference Include="..\..\artifacts\MapboxCommon.xcframework">
      <Kind>Framework</Kind>
      <SmartLink>False</SmartLink>
    </NativeReference>
    <NativeReference Include="..\..\artifacts\MapboxCoreMaps.xcframework">
      <Kind>Framework</Kind>
      <SmartLink>False</SmartLink>
    </NativeReference>
    <NativeReference Include="..\..\artifacts\MapboxMaps.xcframework">
      <Kind>Framework</Kind>
      <SmartLink>False</SmartLink>
    </NativeReference>
    <NativeReference Include="..\..\artifacts\MapboxMobileEvents.xcframework">
      <Kind>Framework</Kind>
      <SmartLink>False</SmartLink>
    </NativeReference>
    <NativeReference Include="..\..\artifacts\Turf.xcframework">
      <Kind>Framework</Kind>
      <SmartLink>False</SmartLink>
    </NativeReference>
    <NativeReference Include="..\..\artifacts\MapboxMapObjC.xcframework">
      <Kind>Framework</Kind>
      <SmartLink>False</SmartLink>
    </NativeReference>
  </ItemGroup>
```


## Upgrade
It takes time to do the binding library and/or upgrade it. Microsoft intends to make it a lot simpler in the future, but not now.

Here are steps if you want to make changes and/or upgrade to the libraries

- 1) Download latest artifacts from Mapbox as per its installation guide
- 2) Run `chmod +x ./gen.sh`
- 3) Run `./gen.sh`
- 4) Compile and correct any errors shown up
- 5) Update `AssemblyInfo.cs` files with the right version number
- 6) Update `*.nuspec` files to have the right version number
- 7) Run `sh build.sh` to create nuget packages
- 8) Commit and create a PR

## License

Mapbox binding library for iOS itself is released under the MIT license.
See [LICENSE](./LICENSE) for details.

This license doesn't override and/or replace [the licence from Mapbox](./artifacts/LICENSE.md).