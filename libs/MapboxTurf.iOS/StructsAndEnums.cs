using ObjCRuntime;

namespace MapboxMobileEvents
{
	[Native]
	public enum MMEErrorNumber : long
	{
		NoError = 0,
		ErrorException = 10001,
		ErrorEventInit = 10002,
		ErrorEventInitMissingKey = 10003,
		ErrorEventInitException = 10004,
		ErrorEventInitInvalid = 10005,
		ErrorEventEncoding = 10006,
		ErrorEventCounting = 10007,
		ErrorConfigUpdateError = 10008
	}
}
