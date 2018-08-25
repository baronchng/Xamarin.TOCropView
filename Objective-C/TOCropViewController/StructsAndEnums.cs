using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace Xamarin.TOCropView
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

	static class CFunctions
	{
		// NSBundle * TO_CROP_VIEW_RESOURCE_BUNDLE_FOR_OBJECT (NSObject *object);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern NSBundle TO_CROP_VIEW_RESOURCE_BUNDLE_FOR_OBJECT (NSObject @object);
	}
}
