using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
			this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
			this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
		}

		private int checkPrint;
		private void btnPageSetup_Click(object sender , System.EventArgs e) {
			pageSetupDialog1.ShowDialog();
		}

		private void btnPrintPreview_Click(object sender , System.EventArgs e) {
			printPreviewDialog1.ShowDialog();
		}

		private void btnPrint_Click(object sender , System.EventArgs e) {
			if(printDialog1.ShowDialog() == DialogResult.OK)
				printDocument1.Print();
		}

		private void printDocument1_BeginPrint(object sender , System.Drawing.Printing.PrintEventArgs e) {
			checkPrint = 0;
		}

		private void printDocument1_PrintPage(object sender , System.Drawing.Printing.PrintPageEventArgs e) {
			// Print the content of RichTextBox. Store the last character printed.
			checkPrint = richTextBoxPrintCtrl1.Print(checkPrint , richTextBoxPrintCtrl1.TextLength , e);

			// Check for more pages
			if(checkPrint < richTextBoxPrintCtrl1.TextLength)
				e.HasMorePages = true;
			else
				e.HasMorePages = false;
		}
	}
}
