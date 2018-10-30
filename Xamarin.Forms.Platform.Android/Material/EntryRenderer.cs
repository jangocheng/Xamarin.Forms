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
using Xamarin.Forms.Platform.Android.FastRenderers;

// this won't go here permanently it's just for testing at this point
[assembly: ExportRenderer(typeof(Entry), typeof(MaterialTextViewRenderer), new[] { typeof(Visual.MaterialVisual) })]
namespace Xamarin.Forms.Platform.Android.Material
{
	public class MaterialTextViewRenderer : ViewRenderer<Entry, global::Android.Support.Design.Widget.TextInputLayout>
	{
		TextColorSwitcher _hintColorSwitcher;
		TextColorSwitcher _textColorSwitcher;
		public MaterialTextViewRenderer(Context context) : base(context)
		{
		}

		global::Android.Support.Design.Widget.TextInputEditText _textInputEditText = null;
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			HandleKeyboardOnFocus = true;

			if (e.OldElement == null)
			{
				var layout = new global::Android.Support.Design.Widget.TextInputLayout(Context);
				_textInputEditText = new global::Android.Support.Design.Widget.TextInputEditText(Context);

				layout.AddView(_textInputEditText);
				layout.Hint = Element.Placeholder;
				SetNativeControl(layout);


				//var textView = CreateNativeControl();

				//textView.AddTextChangedListener(this);
				//textView.SetOnEditorActionListener(this);
				//textView.OnKeyboardBackPressed += OnKeyboardBackPressed;
				//textView.SelectionChanged += SelectionChanged;

				var useLegacyColorManagement = e.NewElement.UseLegacyColorManagement();

				_textColorSwitcher = new TextColorSwitcher(_textInputEditText.TextColors, useLegacyColorManagement);
				_hintColorSwitcher = new TextColorSwitcher(_textInputEditText.HintTextColors, useLegacyColorManagement);
				//SetNativeControl(textView);
			}

			// When we set the control text, it triggers the SelectionChanged event, which updates CursorPosition and SelectionLength;
			// These one-time-use variables will let us initialize a CursorPosition and SelectionLength via ctor/xaml/etc.
			//_cursorPositionChangePending = Element.IsSet(Entry.CursorPositionProperty);
			//_selectionLengthChangePending = Element.IsSet(Entry.SelectionLengthProperty);

			Control.Hint = Element.Placeholder;
			_textInputEditText.Text = Element.Text;
			//UpdateInputType();

			//UpdateColor();
			//UpdateAlignment();
			//UpdateFont();
			UpdatePlaceholderColor();
			/*UpdateMaxLength();
			UpdateImeOptions();
			UpdateReturnType();

			if (_cursorPositionChangePending || _selectionLengthChangePending)
				UpdateCursorSelection();*/
		}

		void UpdatePlaceholderColor()
		{
			_hintColorSwitcher.UpdateTextColor(_textInputEditText, Element.PlaceholderColor, _textInputEditText.SetHintTextColor);
		}
	}
}