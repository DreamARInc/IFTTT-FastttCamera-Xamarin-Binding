﻿using System;
using ObjCRuntime;

namespace IFTTTFastttCamera
{
	[Native]
	public enum FastttCameraDevice : long
	{
		Front,
		Rear
	}

	[Native]
	public enum FastttCameraFlashMode : long
	{
		Off,
		On,
		Auto
	}

	[Native]
	public enum FastttCameraTorchMode : long
	{
		Off,
		On,
		Auto
	}
}
