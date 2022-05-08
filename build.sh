msbuild -t:Clean,Build -p:Configuration=Release ./mapbox-ios.sln
nuget pack mapboxcommon-ios.nuspec
nuget pack mapboxcoremaps-ios.nuspec
nuget pack mapboxturf-ios.nuspec
nuget pack mapboxmobileevents-ios.nuspec
nuget pack mapboxmaps-ios.nuspec
nuget pack mapboxmapsobjc-ios.nuspec