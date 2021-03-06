using System;
using ObjCRuntime;

namespace IFTTTFastttCamera
{
	[Native]
	public enum FastttCameraDevice : nint
	{
		Front,
		Rear
	}

	[Native]
	public enum FastttCameraFlashMode : nint
	{
		Off,
		On,
		Auto
	}

	[Native]
	public enum FastttCameraTorchMode : nint
	{
		Off,
		On,
		Auto
	}
}
