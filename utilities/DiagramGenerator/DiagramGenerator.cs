using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.Fonts;
using SixLabors.ImageSharp.Drawing;

public class DiagramGenerator
{
	// Configuration constants
	private const int CellWidth     = 200;
	private const int CellHeight    = 120;
	private const int FontSizeLarge = 36;
	private const int FontSizeSmall = 18;
	private const int Padding       = 10;

	// Path to a font file (using System fonts for this example)
	private readonly Font _fontLarge;
	private readonly Font _fontSmall;

	public DiagramGenerator()
	{
		// Attempt to find a Monospace font on the system (Consolas, Menlo, Courier)
		// In a real app, you might embed a .ttf file and load it specifically.
		var fontFamily = SystemFonts.Get("IosevkaRikai Nerd Font");
		_fontLarge = fontFamily.CreateFont(FontSizeLarge, FontStyle.Regular);
		_fontSmall = fontFamily.CreateFont(FontSizeSmall, FontStyle.Regular);
	}

	public void Generate(List<ColorEntry> colors, int columns, string outputPath)
	{
		// 1. Calculate Canvas Dimensions
		int rows   = (int)Math.Ceiling((double)colors.Count / columns);
		int width  = columns * CellWidth;
		int height = rows    * CellHeight;

		// 2. Create the Image
		using (var image = new Image<Rgba32>(width, height))
		{
			// Set a default background (optional, usually covered by cells)
			image.Mutate(ctx => ctx.Fill(Color.Transparent));

			// 3. Loop through colors and draw cells
			for (int i = 0; i < colors.Count; i++)
			{
				var entry = colors[i];

				// Calculate grid position
				int row = i   / columns;
				int col = i   % columns;
				int x   = col * CellWidth;
				int y   = row * CellHeight;

				// Draw the specific cell
				image.Mutate(ctx => DrawCell(ctx, entry, x, y));
			}

			// 4. Save
			image.Save(outputPath);
			Console.WriteLine($"Generated palette at {outputPath}");
		}
	}

	private void DrawCell(IImageProcessingContext ctx, ColorEntry entry, int x, int y)
	{
		// Parse the Hex color
		Color bgColor = Color.ParseHex(entry.HexCode);

		// Define the rectangle area
		var rect = new RectangleF(x, y, CellWidth, CellHeight);

		// -- DRAW BACKGROUND --
		ctx.Fill(bgColor, rect);

		// -- CALCULATE TEXT COLOR --
		// To emulate the pro look, we need high contrast text.
		// We check luminance: if dark bg -> white text, if light bg -> dark text.
		// (ImageSharp's Color doesn't expose Luminance easily directly in Rgba32 
		// without casting, so we use a simple math approximation).
		Color textColor    = GetContrastingTextColor(entry.HexCode);
		Color dimTextColor = textColor.WithAlpha(0.6f); // Slightly transparent for secondary info

		// -- DRAW TEXT --

		// 1. Index (Top Right)
		var indexOpts = new RichTextOptions(_fontSmall)
		{
			Origin              = new PointF(x + CellWidth - Padding, y + Padding),
			HorizontalAlignment = HorizontalAlignment.Right,
			VerticalAlignment   = VerticalAlignment.Top
		};
		ctx.DrawText(indexOpts, entry.Index.ToString(), dimTextColor);

		// 2. Name (Center)
		var nameOpts = new RichTextOptions(_fontLarge)
		{
			Origin              = new PointF(x + (CellWidth / 2), y + (CellHeight / 2) - 10),
			HorizontalAlignment = HorizontalAlignment.Center,
			VerticalAlignment   = VerticalAlignment.Center
		};
		ctx.DrawText(nameOpts, entry.Name, textColor);

		// 3. Hex Code (Bottom Center)
		var hexOpts = new RichTextOptions(_fontSmall)
		{
			Origin              = new PointF(x + (CellWidth / 2), y + CellHeight - Padding - 5),
			HorizontalAlignment = HorizontalAlignment.Center,
			VerticalAlignment   = VerticalAlignment.Bottom
		};
		
		// If no hexcode provided, treat as an empty
		if (Color.ParseHex(entry.HexCode) == Color.Transparent)
		{
			ctx.DrawText(hexOpts, "", dimTextColor);
		}
		else 
		{
			ctx.DrawText(hexOpts, entry.HexCode, dimTextColor);
		}
	}

	private Color GetContrastingTextColor(string hex)
	{
		var c = Color.ParseHex(hex);
		// Convert to Rgba32 to access components
		Rgba32 pixel = c.ToPixel<Rgba32>();

		// Perceived brightness formula
		// https://www.w3.org/TR/AERT/#color-contrast
		double brightness = (pixel.R * 299 + pixel.G * 587 + pixel.B * 114) / 1000;

		// If brightness > 128, color is light, so return Black text. Else White.
		return brightness > 128 ? Color.FromRgba(30, 30, 30, 255) : Color.FromRgba(235, 235, 235, 255);
	}
}