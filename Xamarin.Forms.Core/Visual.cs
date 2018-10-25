namespace Xamarin.Forms
{
	public static class Visual
	{
		public static IVisual Default { get; } = new DefaultVisual();
		public static IVisual Material { get; } = new MaterialVisual();

		public sealed class MaterialVisual : IVisual { }
		public sealed class DefaultVisual : IVisual { }
	}

	public interface IVisual { }
}