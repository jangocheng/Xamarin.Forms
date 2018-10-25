using System;
using System.ComponentModel;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Views;
using Xamarin.Forms.Internals;
using AView = Android.Views.View;
using AMotionEventActions = Android.Views.MotionEventActions;
using static System.String;
using Android.Support.V4.View;
using Xamarin.Forms.Platform.Android.Material;
using Xamarin.Forms;

// this won't go here permanently it's just for testing at this point
[assembly: ExportRenderer(typeof(Entry), typeof(MaterialTextViewRenderer), new[] { typeof(Visual.MaterialVisual) })]
namespace Xamarin.Forms.Platform.Android.Material
{
	public class MaterialTextViewRenderer : ViewRenderer<Entry, global::Android.Support.Design.Widget.TextInputLayout>
	{
		public MaterialTextViewRenderer(Context context) : base(context)
		{
		}

		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);


			var layout = new global::Android.Support.Design.Widget.TextInputLayout(Context);
			var editText = new global::Android.Support.Design.Widget.TextInputEditText(Context);
			layout.AddView(editText);

			editText.Hint = "Visions of disorder";
			layout.Hint = "Visions of disorder";
			SetNativeControl(layout);
		}
	}
}