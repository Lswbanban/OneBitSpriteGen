namespace OneBitSpriteGen
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainerToolAndImage = new System.Windows.Forms.SplitContainer();
			this.splitContainerImageAndInfo = new System.Windows.Forms.SplitContainer();
			this.splitContainerImageAndAnim = new System.Windows.Forms.SplitContainer();
			this.pictureBoxImage = new System.Windows.Forms.PictureBox();
			this.richTextBoxLogConsole = new System.Windows.Forms.RichTextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.mainMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerToolAndImage)).BeginInit();
			this.splitContainerToolAndImage.Panel2.SuspendLayout();
			this.splitContainerToolAndImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerImageAndInfo)).BeginInit();
			this.splitContainerImageAndInfo.Panel1.SuspendLayout();
			this.splitContainerImageAndInfo.Panel2.SuspendLayout();
			this.splitContainerImageAndInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerImageAndAnim)).BeginInit();
			this.splitContainerImageAndAnim.Panel1.SuspendLayout();
			this.splitContainerImageAndAnim.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
			this.mainMenuStrip.TabIndex = 0;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// splitContainerToolAndImage
			// 
			this.splitContainerToolAndImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainerToolAndImage.Cursor = System.Windows.Forms.Cursors.VSplit;
			this.splitContainerToolAndImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerToolAndImage.Location = new System.Drawing.Point(0, 24);
			this.splitContainerToolAndImage.Name = "splitContainerToolAndImage";
			// 
			// splitContainerToolAndImage.Panel2
			// 
			this.splitContainerToolAndImage.Panel2.Controls.Add(this.splitContainerImageAndInfo);
			this.splitContainerToolAndImage.Size = new System.Drawing.Size(800, 426);
			this.splitContainerToolAndImage.SplitterDistance = 85;
			this.splitContainerToolAndImage.TabIndex = 1;
			// 
			// splitContainerImageAndInfo
			// 
			this.splitContainerImageAndInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainerImageAndInfo.Cursor = System.Windows.Forms.Cursors.HSplit;
			this.splitContainerImageAndInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerImageAndInfo.Location = new System.Drawing.Point(0, 0);
			this.splitContainerImageAndInfo.Name = "splitContainerImageAndInfo";
			this.splitContainerImageAndInfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerImageAndInfo.Panel1
			// 
			this.splitContainerImageAndInfo.Panel1.Controls.Add(this.splitContainerImageAndAnim);
			// 
			// splitContainerImageAndInfo.Panel2
			// 
			this.splitContainerImageAndInfo.Panel2.Controls.Add(this.richTextBoxLogConsole);
			this.splitContainerImageAndInfo.Size = new System.Drawing.Size(711, 426);
			this.splitContainerImageAndInfo.SplitterDistance = 311;
			this.splitContainerImageAndInfo.TabIndex = 0;
			// 
			// splitContainerImageAndAnim
			// 
			this.splitContainerImageAndAnim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainerImageAndAnim.Cursor = System.Windows.Forms.Cursors.VSplit;
			this.splitContainerImageAndAnim.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerImageAndAnim.Location = new System.Drawing.Point(0, 0);
			this.splitContainerImageAndAnim.Name = "splitContainerImageAndAnim";
			// 
			// splitContainerImageAndAnim.Panel1
			// 
			this.splitContainerImageAndAnim.Panel1.Controls.Add(this.pictureBoxImage);
			this.splitContainerImageAndAnim.Size = new System.Drawing.Size(711, 311);
			this.splitContainerImageAndAnim.SplitterDistance = 512;
			this.splitContainerImageAndAnim.TabIndex = 0;
			// 
			// pictureBoxImage
			// 
			this.pictureBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxImage.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxImage.Name = "pictureBoxImage";
			this.pictureBoxImage.Size = new System.Drawing.Size(508, 307);
			this.pictureBoxImage.TabIndex = 0;
			this.pictureBoxImage.TabStop = false;
			// 
			// richTextBoxLogConsole
			// 
			this.richTextBoxLogConsole.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBoxLogConsole.Location = new System.Drawing.Point(0, 0);
			this.richTextBoxLogConsole.Name = "richTextBoxLogConsole";
			this.richTextBoxLogConsole.Size = new System.Drawing.Size(707, 107);
			this.richTextBoxLogConsole.TabIndex = 0;
			this.richTextBoxLogConsole.Text = "";
			// 
			// openFileDialog
			// 
			this.openFileDialog.Title = "Open Image";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.splitContainerToolAndImage);
			this.Controls.Add(this.mainMenuStrip);
			this.MainMenuStrip = this.mainMenuStrip;
			this.Name = "MainForm";
			this.Text = "One Bit Sprite Gen";
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.splitContainerToolAndImage.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerToolAndImage)).EndInit();
			this.splitContainerToolAndImage.ResumeLayout(false);
			this.splitContainerImageAndInfo.Panel1.ResumeLayout(false);
			this.splitContainerImageAndInfo.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerImageAndInfo)).EndInit();
			this.splitContainerImageAndInfo.ResumeLayout(false);
			this.splitContainerImageAndAnim.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerImageAndAnim)).EndInit();
			this.splitContainerImageAndAnim.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip mainMenuStrip;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private SplitContainer splitContainerToolAndImage;
		private SplitContainer splitContainerImageAndInfo;
		private SplitContainer splitContainerImageAndAnim;
		private PictureBox pictureBoxImage;
		private RichTextBox richTextBoxLogConsole;
		private OpenFileDialog openFileDialog;
	}
}