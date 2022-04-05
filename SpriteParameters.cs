using System.ComponentModel;

namespace OneBitSpriteGen
{
	internal class SpriteParameters
	{
		[Category("Sprite")]
		[Description("Width of each sprite in pixel.")]
		[DefaultValue(8)]
		public int Width
		{
			get { return mWidth; }
			set { mWidth = (value > 0) ? value : 1; }
		}
		private int mWidth = 8;

		[Category("Sprite")]
		[Description("Height of each sprite in pixel. This can only be a multiple of 8.")]
		[DefaultValue(8)]
		public int Height
		{
			get { return mHeight; }
			set
			{
				mHeight = value;
				if (mHeight < 8)
				{
					mHeight = 8;
				}
				else if ((mHeight % 8) != 0)
				{
					mHeight = ((mHeight / 8) + 1) * 8;
				}
			}
		}
		private int mHeight = 8;

		[Category("Export")]
		[DisplayName("Sprite Prefix")]
		[Description("The string that should be placed before each new sprite.")]
		[DefaultValue("{")]
		public string SpritePrefix
		{
			get { return mSpritePrefix; }
			set { mSpritePrefix = value; }
		}
		private string mSpritePrefix = "{";

		[Category("Export")]
		[DisplayName("Sprite Postfix")]
		[Description("The string that should be placed after each new sprite.")]
		[DefaultValue("}, ")]
		public string SpritePostfix
		{
			get { return mSpritePostfix; }
			set { mSpritePostfix = value; }
		}
		private string mSpritePostfix = "}, ";

		[Category("Animation")]
		[DisplayName("Is Anim Looping")]
		[Description("Check if the animation is looping.")]
		[DefaultValue(true)]
		public bool IsAnimLooping
		{
			get { return mIsAnimLooping; }
			set { mIsAnimLooping = value; }
		}
		private bool mIsAnimLooping = true;

		[Category("Animation")]
		[DisplayName("Game Framerate")]
		[Description("Number of frame per second that the game run.")]
		[DefaultValue(60)]
		public int GameFramerate
		{
			get { return mGameFramerate; }
			set { mGameFramerate = value; }
		}
		private int mGameFramerate = 60;

		[Category("Animation")]
		[DisplayName("Anim Frame Duration")]
		[Description("Game frame count spent in each sprite anim frame.")]
		public List<int> AnimFrameDuration
		{
			get { return mAnimFrameDuration; }
			set { mAnimFrameDuration = value; }
		}
		private List<int> mAnimFrameDuration = new List<int>(new int[]{4});

		public string ConvertToHex(Bitmap bitmap)
		{
			// count the number of sprite in the image
			int spriteCountX = bitmap.Width / Width;
			int spriteCountY = bitmap.Height / Height;
			// count how many char is used vertically
			int charCount = Height / 8;
			int blackARGB = Color.Black.ToArgb();
			// declare the result string
			string result = string.Empty;

			// iterate on the image
			for (int sy = 0; sy < spriteCountY; sy++)
				for (int sx = 0; sx < spriteCountX; sx++)
				{
					result += SpritePrefix;
					for (int ch = 0; ch < charCount; ch++)
					{
						int startY = (sy * Height) + (ch * 8);
						for (int x = 0; x < Width; x++)
						{
							int startX = (sx * Width) + x;
							byte pixels = 0;
							for (int y = 0; y < 8; y++)
							{
								if (bitmap.GetPixel(startX, startY + y).ToArgb() != blackARGB)
									pixels |= (byte)(1 << y);
							}
							result += "0x" + pixels.ToString("x") + ", ";
						}
					}
					result += SpritePostfix;
				}
			return result;
		}
	}
}
