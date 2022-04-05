using System;
using System.ComponentModel;
using System.Text;

namespace OneBitSpriteGen
{
	internal class SpriteParameters
	{
		[Category("Sprite")]
		[Description("Width of each sprite in pixel.")]
		[DefaultValue(8)]
		public int Width => mWidth;
		private int mWidth = 8;

		[Category("Sprite")]
		[Description("Height of each sprite in pixel.")]
		[DefaultValue(8)]
		public int Height => mHeight;
		private int mHeight = 8;

		[Category("Export")]
		[DisplayName("Sprite Prefix")]
		[Description("The string that should be placed before each new sprite.")]
		[DefaultValue("{")]
		public string SpritePrefix => mSpritePrefix;
		private string mSpritePrefix = "{";

		[Category("Export")]
		[DisplayName("Sprite Postfix")]
		[Description("The string that should be placed after each new sprite.")]
		[DefaultValue("}, ")]
		public string SpritePostfix => mSpritePostfix;
		private string mSpritePostfix = "}, ";
	}
}
