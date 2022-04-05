using System.Drawing.Drawing2D;
using System.Reflection;

namespace OneBitSpriteGen
{
	public partial class MainForm : Form
	{
		// the sprite parameters as displayed on the property grid
		private SpriteParameters mSpriteParameters = new SpriteParameters();

		// the currently edited bitmap
		private Bitmap mBitmap = new Bitmap(8,8);

		// pen for drawing the image
		private Pen mPixelGridPen = new Pen(Color.FromArgb(30,30,30), 1);
		private Pen mSpriteGridPen = new Pen(Color.Cyan, 1);

		public MainForm()
		{
			InitializeComponent();

			// assign the sprite parameter to the property grid
			propertyGridSpriteParameters.SelectedObject = mSpriteParameters;

			// increase the column width of the property grid
			//SetPropertyGridLabelColumnWidth(100);

			// clear the default image an redraw the image box
			Graphics gc = Graphics.FromImage(mBitmap);
			gc.Clear(Color.Black);
			RedrawImageBox(true);
		}

		//private void SetPropertyGridLabelColumnWidth(int width)
		//{
		//	#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
		//	#pragma warning disable CS8602 // Dereference of a possibly null reference.
		//	// get the grid view
		//	Control view = this.propertyGridSpriteParameters.GetType().GetField("gridView", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(this.propertyGridSpriteParameters) as Control;

		//	// set label width
		//	FieldInfo fi = view.GetType().GetField("labelWidth", BindingFlags.Instance | BindingFlags.NonPublic);
		//	fi.SetValue(view, width);

		//	#pragma warning restore CS8602 // Dereference of a possibly null reference.
		//	#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

		//	// refresh
		//	view.Invalidate();
		//}

		private void UpdateViewsAfterBitmapChange()
		{
			// reexport in text
			this.richTextBoxLogConsole.Text = mSpriteParameters.ConvertToHex(mBitmap);
		}

		#region menu events
		#region File menu
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result= openFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				// load the new bitmap from file
				mBitmap = new Bitmap(openFileDialog.FileName);
				// redraw the image box at the correct size
				RedrawImageBox(true);
				// update all the other views
				UpdateViewsAfterBitmapChange();
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		#endregion

		#region View menu
		private void pixelGridToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RedrawImageBox(true);
		}

		private void spriteGridToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RedrawImageBox(true);
		}
		#endregion
		#endregion

		#region the main image panel
		private void RedrawImageBox(bool shouldRefresh)
		{
			// compute if we need to add margin on top and bottom or left and right
			int widthScale = pictureBoxImage.Width / mBitmap.Width;

			// try to scale on width first
			int width = mBitmap.Width * widthScale;
			int height = mBitmap.Height * widthScale;
			int heightScale = height / mBitmap.Height;
			if (height > pictureBoxImage.Height)
			{
				// the height is too big, so scale according to height
				heightScale = pictureBoxImage.Height / mBitmap.Height;
				width = mBitmap.Width * heightScale;
				height = mBitmap.Height * heightScale;
				// recompute the width scale
				widthScale = width / mBitmap.Width;
			}

			// create a new bitmap for the picture box if different size or not assigned
			if ((this.pictureBoxImage.Image == null) || (this.pictureBoxImage.Image.Width != width) || (this.pictureBoxImage.Image.Height != height))
				this.pictureBoxImage.Image = new Bitmap(width, height);

			// get the gc from the image and set the correct modes
			Graphics gc = Graphics.FromImage(this.pictureBoxImage.Image);
			gc.CompositingMode = CompositingMode.SourceCopy;
			gc.InterpolationMode = InterpolationMode.NearestNeighbor;
			gc.SmoothingMode = SmoothingMode.None;
			gc.PixelOffsetMode = PixelOffsetMode.Half;

			// clear the image
			gc.Clear(Color.Black);

			// now copy the image
			gc.DrawImage(mBitmap, 0, 0, width, height);

			// draw the pixel grid first (if needed)
			if (this.pixelGridToolStripMenuItem.Checked)
			{
				// vertical lines
				for (int i = 0; i < mBitmap.Width; i++)
				{
					int x = i * widthScale;
					gc.DrawLine(mPixelGridPen, x, 0, x, height);
				}
				// horizontal lines
				for (int j = 0; j < mBitmap.Height; j++)
				{
					int y = j * heightScale;
					gc.DrawLine(mPixelGridPen, 0, y, width, y);
				}
			}

			// then draw the sprite grid
			if (this.spriteGridToolStripMenuItem.Checked)
			{
				// vertical lines
				int spriteWidth = mSpriteParameters.Width;
				int horizSpriteCount = (mBitmap.Width / spriteWidth) + 1;
				spriteWidth *= widthScale;
				for (int i = 0; i < horizSpriteCount; i++)
				{
					int x = i * spriteWidth;
					gc.DrawLine(mSpriteGridPen, x, 0, x, height);
				}
				// horizontal lines
				int spriteHeight = mSpriteParameters.Height;
				int vertSpriteCount = (mBitmap.Height / spriteHeight) + 1;
				spriteHeight *= heightScale;
				for (int j = 0; j < vertSpriteCount; j++)
				{
					int y = j * spriteHeight;
					gc.DrawLine(mSpriteGridPen, 0, y, width, y);
				}
			}

			// refresh if we need to
			if (shouldRefresh)
				this.pictureBoxImage.Refresh();
		}


		private void pictureBoxImage_SizeChanged(object sender, EventArgs e)
		{
			// redraw the image with widow is resized
			RedrawImageBox(false);
		}
		#endregion

		#region toolbox
		private void checkBoxDraw_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBoxSelect_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void propertyGridSpriteParameters_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			// we may have changed the sprite width or height
			RedrawImageBox(true);
		}
		#endregion
	}
}