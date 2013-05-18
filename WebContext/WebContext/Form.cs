using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace WebContext {
	public partial class MainWindow : Form {

		wikiContent htmlCode = new wikiContent();

		public MainWindow() {
			InitializeComponent();
			AddedComponents();
		}

		private void AddedComponents() {
			this.makeBox.GotFocus += this.makeBox_GotFocus;
			this.modelBox.GotFocus += this.modelBox_GotFocus;
		}

		private void searchButton_Click(object sender , EventArgs e) {
			string url = "http://wikipedia.org/wiki/" + htmlCode.formatText(makeBox.Text) + "_" + htmlCode.formatText(modelBox.Text);
			this.UrlBox.Text = htmlCode.getWikiImage();
			this.wikiDisplay.DocumentText = htmlCode.getHTMLCode(url);
			this.wikiPicture.ImageLocation = htmlCode.getWikiImage();
		}

		private void modelBox_GotFocus(Object sender , EventArgs e) {
			modelBox.SelectAll();
		}

		private void makeBox_GotFocus(object sender , System.EventArgs e) {
			makeBox.SelectAll();
		}

		private void saveButton_Click(object sender , System.EventArgs e) {
			Stream stream;
			if(saveFileDialog.ShowDialog() == DialogResult.OK) {
				if((stream = this.saveFileDialog.OpenFile()) != null) {
					stream.Write(Encoding.ASCII.GetBytes(wikiDisplay.DocumentText) , 0 , wikiDisplay.DocumentText.Length);
					stream.Close();
				}
				
			}
		}
	}
}
