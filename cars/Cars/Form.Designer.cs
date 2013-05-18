namespace Cars
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MakeLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.MakeBox = new System.Windows.Forms.TextBox();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveLocationBox = new System.Windows.Forms.TextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GoogleTabBrowser = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.WikipediaTabBrowser = new System.Windows.Forms.WebBrowser();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(183, 38);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchBox.Size = new System.Drawing.Size(346, 22);
            this.SearchBox.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(49, 41);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(128, 20);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search For Your Car";
            this.Search.UseCompatibleTextRendering = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(554, 37);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Go!";
            this.ToolTip.SetToolTip(this.SearchButton, "Searches available cars");
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MakeLabel
            // 
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Location = new System.Drawing.Point(82, 75);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(42, 17);
            this.MakeLabel.TabIndex = 4;
            this.MakeLabel.Text = "Make";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(304, 75);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(46, 17);
            this.ModelLabel.TabIndex = 5;
            this.ModelLabel.Text = "Model";
            // 
            // MakeBox
            // 
            this.MakeBox.BackColor = System.Drawing.SystemColors.Window;
            this.MakeBox.Location = new System.Drawing.Point(49, 95);
            this.MakeBox.Name = "MakeBox";
            this.MakeBox.ReadOnly = true;
            this.MakeBox.Size = new System.Drawing.Size(109, 22);
            this.MakeBox.TabIndex = 4;
            // 
            // ModelBox
            // 
            this.ModelBox.BackColor = System.Drawing.SystemColors.Window;
            this.ModelBox.Location = new System.Drawing.Point(272, 95);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.ReadOnly = true;
            this.ModelBox.Size = new System.Drawing.Size(109, 22);
            this.ModelBox.TabIndex = 5;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(532, 75);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(41, 17);
            this.ColorLabel.TabIndex = 5;
            this.ColorLabel.Text = "Color";
            // 
            // ColorBox
            // 
            this.ColorBox.BackColor = System.Drawing.SystemColors.Window;
            this.ColorBox.Location = new System.Drawing.Point(500, 95);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.ReadOnly = true;
            this.ColorBox.Size = new System.Drawing.Size(109, 22);
            this.ColorBox.TabIndex = 6;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(762, 75);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(38, 17);
            this.YearLabel.TabIndex = 5;
            this.YearLabel.Text = "Year";
            // 
            // YearBox
            // 
            this.YearBox.BackColor = System.Drawing.SystemColors.Window;
            this.YearBox.Location = new System.Drawing.Point(730, 95);
            this.YearBox.Name = "YearBox";
            this.YearBox.ReadOnly = true;
            this.YearBox.Size = new System.Drawing.Size(109, 22);
            this.YearBox.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(49, 163);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.ToolTip.SetToolTip(this.SaveButton, "Save Button");
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(554, 162);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ToolTip.SetToolTip(this.ClearButton, "Clears text in fields");
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(49, 134);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Add";
            this.ToolTip.SetToolTip(this.AddButton, "Adds car to existing file");
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SaveLocationBox
            // 
            this.SaveLocationBox.Location = new System.Drawing.Point(130, 164);
            this.SaveLocationBox.Name = "SaveLocationBox";
            this.SaveLocationBox.Size = new System.Drawing.Size(399, 22);
            this.SaveLocationBox.TabIndex = 11;
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Location = new System.Drawing.Point(12, 215);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(955, 527);
            this.TabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GoogleTabBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(947, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Google Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GoogleTabBrowser
            // 
            this.GoogleTabBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoogleTabBrowser.Location = new System.Drawing.Point(3, 3);
            this.GoogleTabBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.GoogleTabBrowser.Name = "GoogleTabBrowser";
            this.GoogleTabBrowser.ScriptErrorsSuppressed = true;
            this.GoogleTabBrowser.Size = new System.Drawing.Size(941, 492);
            this.GoogleTabBrowser.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.WikipediaTabBrowser);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(947, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wikipedia Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // WikipediaTabBrowser
            // 
            this.WikipediaTabBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WikipediaTabBrowser.Location = new System.Drawing.Point(3, 3);
            this.WikipediaTabBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WikipediaTabBrowser.Name = "WikipediaTabBrowser";
            this.WikipediaTabBrowser.ScriptErrorsSuppressed = true;
            this.WikipediaTabBrowser.Size = new System.Drawing.Size(941, 492);
            this.WikipediaTabBrowser.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(979, 754);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.SaveLocationBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.MakeBox);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.MakeLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchBox);
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Cars";
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label MakeLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox MakeBox;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TextBox ColorBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox SaveLocationBox;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser GoogleTabBrowser;
        private System.Windows.Forms.WebBrowser WikipediaTabBrowser;
    }
}

