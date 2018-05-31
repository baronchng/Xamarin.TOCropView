# TOCropViewController / CropViewController

<p align="center">
<img src="https://github.com/TimOliver/TOCropViewController/raw/master/screenshot.jpg" width="890" style="margin:0 auto" />
</p>

Xamarin.iOS bindings for [TOCropViewController](https://github.com/TimOliver/TOCropViewController).

## Features
* Crop images by dragging the edges of a grid overlay.
* Optionally, crop circular copies of images.
* Rotate images in 90-degree segments.
* Clamp the crop box to a specific aspect ratio.
* A reset button to completely undo all changes.
* iOS 7/8 translucency to make it easier to view the cropped region.
* The choice of having the controller return the cropped image to a delegate, or immediately pass it to a `UIActivityViewController`.
* A custom animation and layout when the device is rotated to landscape mode.
* Custom 'opening' and 'dismissal' animations.
* Localized in 18 languages.

## System Requirements
iOS 8.0 or above

## Installation

Available on NuGet

### Basic Implementation
```c#
void Button_TouchUpInside(object sender, EventArgs e)
{
	var cropVC = new TOCropViewController(TOCropViewCroppingStyle.Default, imageView.Image);
	cropVC.Delegate = new MyCropVCDelegate();
	this.PresentViewController(cropVC, true, null);
}

class MyCropVCDelegate : TOCropViewControllerDelegate
{
	public override void DidCropImageToRect(TOCropViewController cropViewController, CGRect cropRect, nint angle)
	{
		cropViewController.PresentingViewController.DismissViewController(true, null);
		var myImage = cropViewController.FinalImage;
	}
}
```

## Credits
`TOCropViewController` was originally created by [Tim Oliver](http://twitter.com/TimOliverAU) as a component for [iComics](http://icomics.co), a comic reader app for iOS.

Thanks also goes to `TOCropViewController`'s growing list of [contributors](https://github.com/TimOliver/TOCropViewController/graphs/contributors)!

iOS Device mockups used in the screenshot created by [Pixeden](http://www.pixeden.com).

Baron Chng just made the binding for Xamarin.iOS.

## License
TOCropViewController is licensed under the MIT License, please see the [LICENSE](LICENSE) file. ![analytics](https://ga-beacon.appspot.com/UA-5643664-16/TOCropViewController/README.md?pixel)
