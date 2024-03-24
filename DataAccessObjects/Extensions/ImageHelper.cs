using System.Drawing;

namespace DataAccessObjects.Extensions
{
	public static class ImageHelper
	{
		public static Image ResizeImage(this Image inputImage, int width, int height)
		{
			// Create a new Bitmap with the desired dimensions
			Bitmap resizedImage = new(width, height);

			// Create a Graphics object from the resized image
			using (Graphics graphics = Graphics.FromImage(resizedImage))
			{
				// Set the interpolation mode to HighQualityBicubic to ensure high-quality resizing
				graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

				// Draw the input image onto the resized image using the desired dimensions
				graphics.DrawImage(inputImage, 0, 0, width, height);
			}

			// Return the resized image
			return resizedImage;
		}
	}
}

