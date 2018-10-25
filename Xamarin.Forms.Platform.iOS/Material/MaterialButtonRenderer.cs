using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using MButton = MaterialComponents.Button;

[assembly: ExportRenderer(typeof(Button), typeof(Xamarin.Forms.Platform.iOS.Material.MaterialButtonRenderer), new[] { typeof(Visual.MaterialVisual) })]
namespace Xamarin.Forms.Platform.iOS.Material
{
	public class MaterialButtonRenderer : ButtonRenderer
	{
		protected override UIButton CreateNativeControl()
		{
			return new MButton();
		}
	}
}