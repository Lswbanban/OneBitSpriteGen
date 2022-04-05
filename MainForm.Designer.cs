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
			this.components = new System.ComponentModel.Container();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pixelGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.spriteGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainerToolAndImage = new System.Windows.Forms.SplitContainer();
			this.label3 = new System.Windows.Forms.Label();
			this.propertyGridSpriteParameters = new System.Windows.Forms.PropertyGrid();
			this.checkBoxSelect = new System.Windows.Forms.CheckBox();
			this.checkBoxDraw = new System.Windows.Forms.CheckBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.splitContainerImageAndInfo = new System.Windows.Forms.SplitContainer();
			this.splitContainerImageAndAnim = new System.Windows.Forms.SplitContainer();
			this.pictureBoxImage = new System.Windows.Forms.PictureBox();
			this.numericUpDownAnimTo = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownAnimFrom = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.trackBarScale = new System.Windows.Forms.TrackBar();
			this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
			this.richTextBoxLogConsole = new System.Windows.Forms.RichTextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.timerAnimation = new System.Windows.Forms.Timer(this.components);
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerToolAndImage)).BeginInit();
			this.splitContainerToolAndImage.Panel1.SuspendLayout();
			this.splitContainerToolAndImage.Panel2.SuspendLayout();
			this.splitContainerToolAndImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerImageAndInfo)).BeginInit();
			this.splitContainerImageAndInfo.Panel1.SuspendLayout();
			this.splitContainerImageAndInfo.Panel2.SuspendLayout();
			this.splitContainerImageAndInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerImageAndAnim)).BeginInit();
			this.splitContainerImageAndAnim.Panel1.SuspendLayout();
			this.splitContainerImageAndAnim.Panel2.SuspendLayout();
			this.splitContainerImageAndAnim.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimTo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimFrom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
			this.mainMenuStrip.TabIndex = 0;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.openToolStripMenuItem.Text = "&Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.saveAsToolStripMenuItem.Text = "Save &as...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.exitToolStripMenuItem.Text = "&Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pixelGridToolStripMenuItem,
            this.spriteGridToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// pixelGridToolStripMenuItem
			// 
			this.pixelGridToolStripMenuItem.Checked = true;
			this.pixelGridToolStripMenuItem.CheckOnClick = true;
			this.pixelGridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.pixelGridToolStripMenuItem.Name = "pixelGridToolStripMenuItem";
			this.pixelGridToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.pixelGridToolStripMenuItem.Text = "Pixel Grid";
			this.pixelGridToolStripMenuItem.Click += new System.EventHandler(this.pixelGridToolStripMenuItem_Click);
			// 
			// spriteGridToolStripMenuItem
			// 
			this.spriteGridToolStripMenuItem.Checked = true;
			this.spriteGridToolStripMenuItem.CheckOnClick = true;
			this.spriteGridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.spriteGridToolStripMenuItem.Name = "spriteGridToolStripMenuItem";
			this.spriteGridToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.spriteGridToolStripMenuItem.Text = "Sprite Grid";
			this.spriteGridToolStripMenuItem.Click += new System.EventHandler(this.spriteGridToolStripMenuItem_Click);
			// 
			// splitContainerToolAndImage
			// 
			this.splitContainerToolAndImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainerToolAndImage.Cursor = System.Windows.Forms.Cursors.VSplit;
			this.splitContainerToolAndImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerToolAndImage.Location = new System.Drawing.Point(0, 24);
			this.splitContainerToolAndImage.Name = "splitContainerToolAndImage";
			// 
			// splitContainerToolAndImage.Panel1
			// 
			this.splitContainerToolAndImage.Panel1.Controls.Add(this.label3);
			this.splitContainerToolAndImage.Panel1.Controls.Add(this.propertyGridSpriteParameters);
			this.splitContainerToolAndImage.Panel1.Controls.Add(this.checkBoxSelect);
			this.splitContainerToolAndImage.Panel1.Controls.Add(this.checkBoxDraw);
			this.splitContainerToolAndImage.Panel1.Controls.Add(this.pictureBox2);
			this.splitContainerToolAndImage.Panel1.Controls.Add(this.pictureBox1);
			this.splitContainerToolAndImage.Panel1.Controls.Add(this.label2);
			this.splitContainerToolAndImage.Panel1.Controls.Add(this.label1);
			this.splitContainerToolAndImage.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
			// 
			// splitContainerToolAndImage.Panel2
			// 
			this.splitContainerToolAndImage.Panel2.Controls.Add(this.splitContainerImageAndInfo);
			this.splitContainerToolAndImage.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
			this.splitContainerToolAndImage.Size = new System.Drawing.Size(800, 426);
			this.splitContainerToolAndImage.SplitterDistance = 172;
			this.splitContainerToolAndImage.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 15);
			this.label3.TabIndex = 9;
			this.label3.Text = "Sprite Parameters:";
			// 
			// propertyGridSpriteParameters
			// 
			this.propertyGridSpriteParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.propertyGridSpriteParameters.Location = new System.Drawing.Point(3, 103);
			this.propertyGridSpriteParameters.Name = "propertyGridSpriteParameters";
			this.propertyGridSpriteParameters.PropertySort = System.Windows.Forms.PropertySort.Categorized;
			this.propertyGridSpriteParameters.Size = new System.Drawing.Size(162, 316);
			this.propertyGridSpriteParameters.TabIndex = 8;
			this.propertyGridSpriteParameters.ToolbarVisible = false;
			this.propertyGridSpriteParameters.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridSpriteParameters_PropertyValueChanged);
			// 
			// checkBoxSelect
			// 
			this.checkBoxSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxSelect.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBoxSelect.Cursor = System.Windows.Forms.Cursors.Default;
			this.checkBoxSelect.Location = new System.Drawing.Point(3, 52);
			this.checkBoxSelect.Name = "checkBoxSelect";
			this.checkBoxSelect.Size = new System.Drawing.Size(162, 24);
			this.checkBoxSelect.TabIndex = 7;
			this.checkBoxSelect.Text = "Select";
			this.checkBoxSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxSelect.UseVisualStyleBackColor = true;
			this.checkBoxSelect.CheckedChanged += new System.EventHandler(this.checkBoxSelect_CheckedChanged);
			// 
			// checkBoxDraw
			// 
			this.checkBoxDraw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxDraw.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBoxDraw.Checked = true;
			this.checkBoxDraw.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxDraw.Cursor = System.Windows.Forms.Cursors.Default;
			this.checkBoxDraw.Location = new System.Drawing.Point(3, 3);
			this.checkBoxDraw.Name = "checkBoxDraw";
			this.checkBoxDraw.Size = new System.Drawing.Size(162, 24);
			this.checkBoxDraw.TabIndex = 6;
			this.checkBoxDraw.Text = "Draw";
			this.checkBoxDraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxDraw.UseVisualStyleBackColor = true;
			this.checkBoxDraw.CheckedChanged += new System.EventHandler(this.checkBoxDraw_CheckedChanged);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.Color.Black;
			this.pictureBox2.Location = new System.Drawing.Point(145, 31);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 15);
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Location = new System.Drawing.Point(37, 31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(16, 15);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(111, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "RMB:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "LMB:";
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
			this.splitContainerImageAndInfo.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
			// 
			// splitContainerImageAndInfo.Panel2
			// 
			this.splitContainerImageAndInfo.Panel2.Controls.Add(this.richTextBoxLogConsole);
			this.splitContainerImageAndInfo.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
			this.splitContainerImageAndInfo.Size = new System.Drawing.Size(624, 426);
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
			this.splitContainerImageAndAnim.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
			// 
			// splitContainerImageAndAnim.Panel2
			// 
			this.splitContainerImageAndAnim.Panel2.Controls.Add(this.numericUpDownAnimTo);
			this.splitContainerImageAndAnim.Panel2.Controls.Add(this.numericUpDownAnimFrom);
			this.splitContainerImageAndAnim.Panel2.Controls.Add(this.label5);
			this.splitContainerImageAndAnim.Panel2.Controls.Add(this.label4);
			this.splitContainerImageAndAnim.Panel2.Controls.Add(this.trackBarScale);
			this.splitContainerImageAndAnim.Panel2.Controls.Add(this.pictureBoxPreview);
			this.splitContainerImageAndAnim.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
			this.splitContainerImageAndAnim.Size = new System.Drawing.Size(624, 311);
			this.splitContainerImageAndAnim.SplitterDistance = 448;
			this.splitContainerImageAndAnim.TabIndex = 0;
			// 
			// pictureBoxImage
			// 
			this.pictureBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxImage.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxImage.Name = "pictureBoxImage";
			this.pictureBoxImage.Size = new System.Drawing.Size(444, 307);
			this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBoxImage.TabIndex = 0;
			this.pictureBoxImage.TabStop = false;
			this.pictureBoxImage.SizeChanged += new System.EventHandler(this.pictureBoxImage_SizeChanged);
			// 
			// numericUpDownAnimTo
			// 
			this.numericUpDownAnimTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDownAnimTo.Location = new System.Drawing.Point(124, 217);
			this.numericUpDownAnimTo.Name = "numericUpDownAnimTo";
			this.numericUpDownAnimTo.Size = new System.Drawing.Size(41, 23);
			this.numericUpDownAnimTo.TabIndex = 5;
			this.numericUpDownAnimTo.ValueChanged += new System.EventHandler(this.numericUpDownAnimTo_ValueChanged);
			// 
			// numericUpDownAnimFrom
			// 
			this.numericUpDownAnimFrom.Location = new System.Drawing.Point(45, 217);
			this.numericUpDownAnimFrom.Name = "numericUpDownAnimFrom";
			this.numericUpDownAnimFrom.Size = new System.Drawing.Size(41, 23);
			this.numericUpDownAnimFrom.TabIndex = 4;
			this.numericUpDownAnimFrom.ValueChanged += new System.EventHandler(this.numericUpDownAnimFrom_ValueChanged);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(96, 220);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(22, 15);
			this.label5.TabIndex = 3;
			this.label5.Text = "To:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 221);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 15);
			this.label4.TabIndex = 2;
			this.label4.Text = "From:";
			// 
			// trackBarScale
			// 
			this.trackBarScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.trackBarScale.Location = new System.Drawing.Point(3, 171);
			this.trackBarScale.Minimum = 1;
			this.trackBarScale.Name = "trackBarScale";
			this.trackBarScale.Size = new System.Drawing.Size(162, 45);
			this.trackBarScale.TabIndex = 1;
			this.trackBarScale.Value = 1;
			this.trackBarScale.ValueChanged += new System.EventHandler(this.trackBarScale_ValueChanged);
			// 
			// pictureBoxPreview
			// 
			this.pictureBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxPreview.Location = new System.Drawing.Point(3, 3);
			this.pictureBoxPreview.Name = "pictureBoxPreview";
			this.pictureBoxPreview.Size = new System.Drawing.Size(162, 162);
			this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBoxPreview.TabIndex = 0;
			this.pictureBoxPreview.TabStop = false;
			// 
			// richTextBoxLogConsole
			// 
			this.richTextBoxLogConsole.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBoxLogConsole.Location = new System.Drawing.Point(0, 0);
			this.richTextBoxLogConsole.Name = "richTextBoxLogConsole";
			this.richTextBoxLogConsole.Size = new System.Drawing.Size(620, 107);
			this.richTextBoxLogConsole.TabIndex = 0;
			this.richTextBoxLogConsole.Text = "";
			// 
			// openFileDialog
			// 
			this.openFileDialog.Title = "Open Image";
			// 
			// timerAnimation
			// 
			this.timerAnimation.Interval = 17;
			this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.splitContainerToolAndImage.Panel1.ResumeLayout(false);
			this.splitContainerToolAndImage.Panel1.PerformLayout();
			this.splitContainerToolAndImage.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerToolAndImage)).EndInit();
			this.splitContainerToolAndImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.splitContainerImageAndInfo.Panel1.ResumeLayout(false);
			this.splitContainerImageAndInfo.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerImageAndInfo)).EndInit();
			this.splitContainerImageAndInfo.ResumeLayout(false);
			this.splitContainerImageAndAnim.Panel1.ResumeLayout(false);
			this.splitContainerImageAndAnim.Panel2.ResumeLayout(false);
			this.splitContainerImageAndAnim.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerImageAndAnim)).EndInit();
			this.splitContainerImageAndAnim.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimTo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimFrom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
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
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem saveAsToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem exitToolStripMenuItem;
		private SaveFileDialog saveFileDialog;
		private CheckBox checkBoxSelect;
		private CheckBox checkBoxDraw;
		private PictureBox pictureBox2;
		private PictureBox pictureBox1;
		private Label label2;
		private Label label1;
		private Label label3;
		private PropertyGrid propertyGridSpriteParameters;
		private ToolStripMenuItem viewToolStripMenuItem;
		private ToolStripMenuItem pixelGridToolStripMenuItem;
		private ToolStripMenuItem spriteGridToolStripMenuItem;
		private NumericUpDown numericUpDownAnimTo;
		private NumericUpDown numericUpDownAnimFrom;
		private Label label5;
		private Label label4;
		private TrackBar trackBarScale;
		private PictureBox pictureBoxPreview;
		private System.Windows.Forms.Timer timerAnimation;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem;
	}
}