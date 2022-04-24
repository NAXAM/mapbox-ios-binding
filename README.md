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
Please follow the official guide [here](https://www.mapbox.com/ios-sdk/).

## Upgrade
It takes time to do the binding library and/or upgrade it. Microsoft intends to make it a lot simpler in the future, but not now.

Here are steps if you want to make changes and/or upgrade to the libraries

- 1) Download latest artifacts from Mapbox as per its installation guide
- 2) Run `chmod +x ./gen.sh`
- 3) Run `./gen.sh`
- 4) Compile and correct any errors shown up

## License

Mapbox binding library for iOS itself is released under the MIT license.
See [LICENSE](./LICENSE) for details.

This license doesn't override and/or replace [the licence from Mapbox](./artifacts/LICENSE.md).