using System.Reflection;

using Foundation;

// This attribute allows you to mark your assemblies as “safe to link”. 
// When the attribute is present, the linker—if enabled—will process the assembly 
// even if you’re using the “Link SDK assemblies only” option, which is the default for device builds.

[assembly: LinkerSafe]

// Information about this assembly is defined by the following attributes. 
// Change them to the values specific to your project.

[assembly: AssemblyTitle("Naxam.Mapbox.iOS")]
[assembly: AssemblyDescription("Xamarin.iOS binding library for Mapbox SDK")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("NAXAM CO.,LTD")]
[assembly: AssemblyProduct("X Bindings")]
[assembly: AssemblyCopyright("Copyright @ 2018 NAXAM")]
[assembly: AssemblyTrademark("NAXAM")]
[assembly: AssemblyCulture("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

[assembly: AssemblyVersion("4.3.0")]
[assembly: AssemblyInformationalVersion("4.3.0.2")]

// The following attributes are used to specify the signing key for the assembly, 
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]