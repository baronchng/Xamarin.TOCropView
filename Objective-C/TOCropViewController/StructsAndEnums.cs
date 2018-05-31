using System;
using ObjCRuntime;

namespace TOCropViewController
{
	[Native]
	public enum TOCropViewCroppingStyle : nint
	{
		Default,
		Circular
	}

	[Native]
	public enum TOCropViewControllerAspectRatioPreset : nint
	{
		Original,
		Square,
		TOCropViewControllerAspectRatioPreset3x2,
		TOCropViewControllerAspectRatioPreset5x3,
		TOCropViewControllerAspectRatioPreset4x3,
		TOCropViewControllerAspectRatioPreset5x4,
		TOCropViewControllerAspectRatioPreset7x5,
		TOCropViewControllerAspectRatioPreset16x9,
		Custom
	}

	[Native]
	public enum TOCropViewControllerToolbarPosition : nint
	{
		Bottom,
		Top
	}
}
