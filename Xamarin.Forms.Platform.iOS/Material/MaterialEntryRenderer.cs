using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using MaterialComponents;
using UIKit;
using Xamarin.Forms;
using MTextField = MaterialComponents.TextField;
using MTextInputControllerOutlined = MaterialComponents.TextInputControllerOutlined;
using MTextInputControllerUnderline = MaterialComponents.TextInputControllerUnderline;

[assembly: ExportRenderer(typeof(Entry), typeof(Xamarin.Forms.Platform.iOS.Material.MaterialEntryRenderer), new[] { typeof(Visual.MaterialVisual) })]
namespace Xamarin.Forms.Platform.iOS.Material
{
	public class MaterialEntryRenderer : ViewRenderer<Entry, UITextField>
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);
			SetNativeControl(CreateNativeControl());
		}

		public override UIViewController ViewController => base.ViewController;

		public override UIInputViewController InputViewController => base.InputViewController;

		protected override UITextField CreateNativeControl()
		{
			var controller = base.ViewController;
			var field = new MTextField(); 
			field.ClearButtonMode = UITextFieldViewMode.UnlessEditing;			
			var controllerUnderline = new MTextInputControllerUnderline(field);
			controllerUnderline.PlaceholderText = (string)Element.GetValue(AutomationProperties.HelpTextProperty);
			return field;
		}
	}

}