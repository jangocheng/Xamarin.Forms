using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using MTextField = MaterialComponents.TextField;

[assembly: ExportRenderer(typeof(Entry), typeof(Xamarin.Forms.Platform.iOS.Material.MaterialEntryRenderer), new[] { typeof(Visual.MaterialVisual) })]
namespace Xamarin.Forms.Platform.iOS.Material
{
	public class MaterialEntryRenderer : EntryRenderer
	{
		protected override UITextField CreateNativeControl()
		{
			return new MTextField();
		}
	}
}