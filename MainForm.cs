namespace OneBitSpriteGen
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		#region menu events
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result= openFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				Bitmap bitmap = new Bitmap(openFileDialog.FileName);
				this.pictureBoxImage.Image = bitmap;
				this.richTextBoxLogConsole.Text = ConvertToHex(bitmap, 6, 16);
			}
		}
		#endregion

		private string ConvertToHex(Bitmap bitmap, int spriteWidth, int spriteHeight)
		{
			// count the number of sprite in the image
			int spriteCountX = bitmap.Width / spriteWidth;
			int spriteCountY = bitmap.Height / spriteHeight;
			// count how many char is used vertically
			int charCount = spriteHeight / 8;
			int blackARGB = Color.Black.ToArgb();
			// declare the result string
			string result = string.Empty;

			// iterate on the image
			for (int sy = 0; sy < spriteCountY; sy++)
				for (int sx = 0; sx < spriteCountX; sx++)
				{
					result += "{";
					for (int ch = 0; ch < charCount; ch++)
					{
						int startY = (sy * spriteHeight) + (ch * 8);
						for (int x = 0; x < spriteWidth; x++)
						{
							int startX = (sx * spriteWidth) + x;
							byte pixels = 0;
							for (int y = 0; y < 8; y++)
							{
								if (bitmap.GetPixel(startX, startY + y).ToArgb() != blackARGB)
									pixels |= (byte)(1 << y);
							}
							result += "0x" + pixels.ToString("x") + ", ";
						}
					}
					result += "}, ";
				}
			return result;
		}
	}
}