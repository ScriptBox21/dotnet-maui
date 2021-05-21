namespace Microsoft.Maui.Controls.Compatibility.Platform.GTK.Extensions
{
	public static class GtkRectangleExtensions
	{
		public static Size ToSize(this Gdk.Rectangle rect)
		{
			return new Size(rect.Width, rect.Height);
		}
	}
}
