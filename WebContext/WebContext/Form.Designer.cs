namespace WebContext {
	partial class MainWindow {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.UrlBox = new System.Windows.Forms.RichTextBox();
			this.wikiDisplay = new System.Windows.Forms.WebBrowser();
			this.makeBox = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.wikiPicture = new System.Windows.Forms.PictureBox();
			this.modelBox = new System.Windows.Forms.TextBox();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.saveButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.wikiPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// UrlBox
			// 
			this.UrlBox.Location = new System.Drawing.Point(21, 433);
			this.UrlBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.UrlBox.Multiline = false;
			this.UrlBox.Name = "UrlBox";
			this.UrlBox.ReadOnly = true;
			this.UrlBox.Size = new System.Drawing.Size(524, 33);
			this.UrlBox.TabIndex = 0;
			this.UrlBox.TabStop = false;
			this.UrlBox.Text = "";
			// 
			// wikiDisplay
			// 
			this.wikiDisplay.Location = new System.Drawing.Point(584, 12);
			this.wikiDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.wikiDisplay.MinimumSize = new System.Drawing.Size(29, 32);
			this.wikiDisplay.Name = "wikiDisplay";
			this.wikiDisplay.Size = new System.Drawing.Size(665, 647);
			this.wikiDisplay.TabIndex = 4;
			this.wikiDisplay.TabStop = false;
			// 
			// makeBox
			// 
			this.makeBox.Location = new System.Drawing.Point(21, 502);
			this.makeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.makeBox.Name = "makeBox";
			this.makeBox.Size = new System.Drawing.Size(221, 32);
			this.makeBox.TabIndex = 0;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(21, 585);
			this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(107, 37);
			this.searchButton.TabIndex = 2;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// wikiPicture
			// 
			this.wikiPicture.Location = new System.Drawing.Point(21, 12);
			this.wikiPicture.Name = "wikiPicture";
			this.wikiPicture.Size = new System.Drawing.Size(524, 266);
			this.wikiPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.wikiPicture.TabIndex = 6;
			this.wikiPicture.TabStop = false;
			// 
			// modelBox
			// 
			this.modelBox.Location = new System.Drawing.Point(324, 502);
			this.modelBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.modelBox.Name = "modelBox";
			this.modelBox.Size = new System.Drawing.Size(221, 32);
			this.modelBox.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(21, 585);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 37);
			this.button1.TabIndex = 2;
			this.button1.Text = "Search";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(21, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(524, 266);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(438, 585);
			this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(107, 37);
			this.saveButton.TabIndex = 2;
			this.saveButton.TabStop = false;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// MainWindow
			// 
			this.AcceptButton = this.searchButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(1262, 673);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.wikiPicture);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.modelBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.makeBox);
			this.Controls.Add(this.wikiDisplay);
			this.Controls.Add(this.UrlBox);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainWindow";
			this.Text = "Page Summary";
			((System.ComponentModel.ISupportInitialize)(this.wikiPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private System.Windows.Forms.RichTextBox UrlBox;
		private System.Windows.Forms.WebBrowser wikiDisplay;
		private System.Windows.Forms.TextBox makeBox;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.PictureBox wikiPicture;
		private System.Windows.Forms.TextBox modelBox;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button saveButton;
	}
}

