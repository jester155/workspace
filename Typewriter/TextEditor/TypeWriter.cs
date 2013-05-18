using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Documents;

namespace TextEditor {
	public partial class TypeWriter : Form {

		private string stringToPrint;
		public static string text;

		List<ToolStripMenuItem> themes = new List<ToolStripMenuItem>();

		private PrintDocument printDocument = new PrintDocument();
		private int wordCount;
		private int pageCount = 1;

		public TypeWriter() {
			InitializeComponent();

			this.typeWriterField.ContextMenuStrip = this.contextMenu;
			this.typeWriterField.TextChanged += this.typeWriterField_TextChanged;
			this.printDocument.PrintPage += this.printDocument_PrintPage;
			//this.typeWriterField.KeyDown += new KeyEventHandler(this.typeWriter_KeyDown);

			this.wordCount = Regex.Matches(((System.Windows.Forms.RichTextBox) this.typeWriterField).Text , @"[\S]+").Count;
			this.toolStripStatusLabel3.Text = this.wordCount.ToString();
			this.toolStripStatusLabel4.Text = this.pageCount.ToString();
			this.foreColor = this.typeWriterField.ForeColor;
			this.selectionColor = this.typeWriterField.SelectionColor;
			
			this.themes.Add(this.defaultToolStripMenuItem);
			this.themes.Add(this.classicToolStripMenuItem);
			this.themes.Add(this.grayToolStripMenuItem);
			this.themes.Add(this.professionalToolStripMenuItem);
			this.themes.Add(this.cyberProfessionalToolStripMenuItem);
			this.themes.Add(this.cyberToolStripMenuItem);
		}

		private void typeWriter_KeyDown(object sender , KeyEventArgs e) {
			if(
				(e.KeyValue >= 65 && e.KeyValue <= 90) ||
				(e.KeyValue >= 48 && e.KeyValue <= 57) ||
				(e.KeyValue >= 69 && e.KeyValue <= 111)
			)
			(new System.Media.SoundPlayer(@"Sounds\typewriter-key-1.wav")).Play();
			else
				e.Handled = false;
		}

		private void typeWriterField_TextChanged(object sender , EventArgs e) {
			this.toolStripStatusLabel3.Text = Regex.Matches(((System.Windows.Forms.RichTextBox) sender).Text , @"[\S]+").Count.ToString();

			if(Regex.Matches(((System.Windows.Forms.RichTextBox) sender).Text , @"[\S]+").Count > (wordCount += 500)) {
				this.pageCount++;
				this.toolStripStatusLabel4.Text = this.pageCount.ToString();
			}
		}

		//.STUFF FOR PRINTING
		private void printDocument_PrintPage(object sender , PrintPageEventArgs e) {

			Font font1 = new Font(
				this.typeWriterField.Font.FontFamily ,
				this.typeWriterField.Font.Size ,
				this.typeWriterField.Font.Style
			);

			int charactersOnPage = 0;
			int linesPerPage = 0;

			//.Sets the value of charactersOnPage to the number of characters 
			//.of stringToPrint that will fit within the bounds of the page.
			e.Graphics.MeasureString(stringToPrint , font1 ,
			    e.MarginBounds.Size , StringFormat.GenericTypographic ,
			    out charactersOnPage , out linesPerPage
			);

			//.Draws the string within the bounds of the page
			e.Graphics.DrawString(stringToPrint , font1 , System.Drawing.Brushes.Black ,
			    e.MarginBounds , StringFormat.GenericTypographic);

			//.Remove the portion of the string that has been printed.
			stringToPrint = stringToPrint.Substring(charactersOnPage);

			//.Check to see if more pages are to be printed.
			e.HasMorePages = (stringToPrint.Length > 0);
		}

		private void printToolStripMenuItem_Click(object sender , EventArgs e) {
			try {
				printDocument.Print();
			}
			catch(Exception ex) {
				throw new Exception("Exception Occured While Printing" , ex);
			}
		}

		private void printPreviewToolStripMenuItem_Click(object sender , EventArgs e) {
			this.printPreviewDialog.ClientSize = new System.Drawing.Size(800 , 720);
			this.stringToPrint = this.typeWriterField.Text;
			printPreviewDialog.Document = this.printDocument;
			printPreviewDialog.ShowDialog();
		}
		
		//.MENU ITEMS
		//.FONT STYLES
		private void boldToolStripMenuItem_Click(object sender , EventArgs e) {
			setBold();
		}

		private void underlineToolStripMenuItem_Click(object sender , EventArgs e) {
			setUnderline();
		}

		private void italicToolStripMenuItem_Click(object sender , EventArgs e) {
			setItalic();
		}

		//.EDIT TOOLS
		private void pasteToolStripMenuItem_Click(object sender , EventArgs e) {
			this.typeWriterField.Paste();
		}

		private void pasteToolStripMenuItem1_Click(object sender , EventArgs e) {
			this.typeWriterField.Paste();
		}

		private void cutToolStripMenuItem1_Click(object sender , EventArgs e) {
			this.typeWriterField.Cut();
		}

		private void cutToolStripMenuItem_Click(object sender , EventArgs e) {
			this.typeWriterField.Cut();
		}

		private void copyToolStripMenuItem_Click(object sender , EventArgs e) {
			this.typeWriterField.Copy();
		}

		private void copyToolStripMenuItem1_Click(object sender , EventArgs e) {
			this.typeWriterField.Copy();
		}

		private void selectAllToolStripMenuItem_Click(object sender , EventArgs e) {
			this.typeWriterField.SelectAll();
		}

		//.FILE TOOLS
		private void findToolStripMenuItem_Click(object sender , EventArgs e) {
			FindBox findBox = new FindBox();
			text = this.typeWriterField.Text;
			findBox.Show();
		}

		private void saveToolStripMenuItem_Click(object sender , EventArgs e) {
			if(openFile == null) {
				this.saveAction();
				this.setTextForeColor();
			}
			else {
				this.setTextForeColor(System.Drawing.Color.Black);
				this.typeWriterField.SaveFile(this.openFile , RichTextBoxStreamType.RichText);
				this.setTextForeColor();
			}
				
		}

		private void newToolStripMenuItem_Click(object sender , EventArgs e) {
			System.Windows.Forms.Application.Restart();
		}

		private void openToolStripMenuItem_Click(object sender , EventArgs e) {
			this.openAction();
			this.setTextForeColor();
		}

		private void exitToolStripMenuItem_Click(object sender , EventArgs e) {
			Environment.Exit(0);
		}

		//.THEMES
		private void defaultToolStripMenuItem_Click(object sender , EventArgs e) {
			this.uncheckAllBoxes();
			
			this.typeWriterField.BackColor = System.Drawing.Color.Black;
			this.typeWriterField.ForeColor = (this.foreColor = System.Drawing.Color.Lime);
			this.typeWriterField.Font = new Font("Courier New" , 12 , this.typeWriterField.Font.Style);
			
			if(this.defaultToolStripMenuItem.Checked == false)
				this.defaultToolStripMenuItem.CheckState = CheckState.Checked;
		}

		private void classicToolStripMenuItem_Click(object sender , EventArgs e) {
			this.uncheckAllBoxes();

			this.typeWriterField.BackColor = System.Drawing.Color.White;
			this.typeWriterField.ForeColor = (this.foreColor = System.Drawing.Color.Black);
			this.typeWriterField.Font = new Font("Courier New" , 12 , this.typeWriterField.Font.Style);

			if(this.classicToolStripMenuItem.Checked == false)
				this.classicToolStripMenuItem.CheckState = CheckState.Checked;
		}

		private void grayToolStripMenuItem_Click(object sender , EventArgs e) {
			this.uncheckAllBoxes();

			this.typeWriterField.BackColor = System.Drawing.Color.DarkGray;
			this.typeWriterField.ForeColor = (this.foreColor = System.Drawing.Color.WhiteSmoke);
			this.typeWriterField.Font = new Font("Courier New" , 12 , this.typeWriterField.Font.Style);

			if(this.classicToolStripMenuItem.Checked == false)
				this.grayToolStripMenuItem.CheckState = CheckState.Checked;
		}

		private void professionalToolStripMenuItem_Click(object sender , EventArgs e) {
			this.uncheckAllBoxes();

			this.typeWriterField.BackColor = System.Drawing.Color.White;
			this.typeWriterField.ForeColor = (this.foreColor = System.Drawing.Color.Black);
			this.typeWriterField.Font = new Font("Times New Roman" , 12 , this.typeWriterField.Font.Style);

			if(this.professionalToolStripMenuItem.Checked == false)
				this.professionalToolStripMenuItem.CheckState = CheckState.Checked;
		}

		private void cyberProfessionalToolStripMenuItem_Click(object sender , EventArgs e) {
			this.uncheckAllBoxes();

			this.typeWriterField.BackColor = System.Drawing.Color.Black;
			this.typeWriterField.ForeColor = (this.foreColor = System.Drawing.Color.Lime);
			this.typeWriterField.Font = new Font("Times New Roman" , 12 , this.typeWriterField.Font.Style);

			if(this.cyberProfessionalToolStripMenuItem.Checked == false)
				this.cyberProfessionalToolStripMenuItem.CheckState = CheckState.Checked;
		}

		private void cyberToolStripMenuItem_Click(object sender , EventArgs e) {
			this.uncheckAllBoxes();

			this.typeWriterField.BackColor = System.Drawing.Color.Black;
			this.typeWriterField.ForeColor = (this.foreColor = System.Drawing.Color.Lime);
			this.typeWriterField.Font = new Font("Lucida Console Regular" , 12 , this.typeWriterField.Font.Style);

			if(this.cyberToolStripMenuItem.Checked == false)
				this.cyberToolStripMenuItem.CheckState = CheckState.Checked;
		}

		private void orangeToolStripMenuItem_Click(object sender , EventArgs e) {
			this.uncheckAllBoxes();

			this.typeWriterField.BackColor = System.Drawing.Color.Black;
			this.typeWriterField.ForeColor = (this.foreColor = System.Drawing.Color.Orange);
			this.typeWriterField.Font = new Font("Courier New" , 12 , this.typeWriterField.Font.Style);

			if(this.cyberToolStripMenuItem.Checked == false)
				this.orangeToolStripMenuItem.CheckState = CheckState.Checked;
		}

		private void pageSetupToolStripMenuItem_Click(object sender , EventArgs e) {
			this.pageSetupDialog1.Document = this.printDocument;
			
			this.pageSetupDialog1.ShowDialog();
		}

		private void soundEnabledToolStripMenuItem_Click(object sender , EventArgs e) {
		}

		//.OTHER
	}
}
