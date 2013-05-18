using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor {
	public partial class TypeWriter {

		private string openFile = null;
		private Color foreColor = new Color();
		private Color selectionColor = new Color();

		private void saveAction() {
			saveFileDialog.Filter = "txt files (*.txt)|*.txt|rich text files (*.rtf)|*.rtf|All files (*.*)|*.*";
			saveFileDialog.FilterIndex = 2;
			saveFileDialog.RestoreDirectory = true;
			saveFileDialog.Title = "Save";

			if(saveFileDialog.ShowDialog() == DialogResult.OK) {
				this.typeWriterField.ForeColor = System.Drawing.Color.Black;
				this.typeWriterField.SaveFile((this.openFile = Path.GetFullPath(this.saveFileDialog.FileName)) , RichTextBoxStreamType.RichText);
			}
			
		}

		private void openAction() {
			//.Set filter options and filter index.
			openFileDialog.Filter = "Text Files (.txt)|*.txt|rich text files (*.rtf)|*.rtf|All Files (*.*)|*.*";
			openFileDialog.FilterIndex = 2;

			openFileDialog.Multiselect = false;

			//.Call the ShowDialog method to show the dialog box.
			if(openFileDialog.ShowDialog() == DialogResult.OK) {
				openFile = Path.GetFullPath(openFileDialog.FileName);
				try {
					this.typeWriterField.Rtf = File.ReadAllText(openFile , Encoding.UTF8);
				}
				catch(Exception e) {
					throw new Exception("Cannot open file" , e);
				}
			}
				
		}

		private void setBold() {
			if(this.typeWriterField.SelectionFont.Style.HasFlag(FontStyle.Bold))
				this.typeWriterField.SelectionFont = new Font(this.typeWriterField.Font , this.typeWriterField.SelectionFont.Style ^ FontStyle.Bold);
			else
				this.typeWriterField.SelectionFont = new Font(this.typeWriterField.Font , this.typeWriterField.SelectionFont.Style | FontStyle.Bold);
		}

		private void setUnderline() {
			if(this.typeWriterField.SelectionFont.Style.HasFlag(FontStyle.Underline))
				this.typeWriterField.SelectionFont = new Font(this.typeWriterField.Font , this.typeWriterField.SelectionFont.Style ^ FontStyle.Underline);
			else
				this.typeWriterField.SelectionFont = new Font(this.typeWriterField.Font , this.typeWriterField.SelectionFont.Style | FontStyle.Underline);
		}

		private void setItalic() {
			if(this.typeWriterField.SelectionFont.Style.HasFlag(FontStyle.Italic))
				this.typeWriterField.SelectionFont = new Font(this.typeWriterField.Font , this.typeWriterField.SelectionFont.Style ^ FontStyle.Italic);
			else
				this.typeWriterField.SelectionFont = new Font(this.typeWriterField.Font , this.typeWriterField.SelectionFont.Style | FontStyle.Italic);
		}

		private void setTextForeColor() {
			this.typeWriterField.SelectionColor = System.Drawing.Color.Empty;
			this.typeWriterField.SelectAll();
			this.typeWriterField.SelectionColor = this.foreColor;
			this.typeWriterField.DeselectAll();
			this.typeWriterField.SelectionColor = this.selectionColor;
		}

		private void setTextForeColor(Color color) {
			this.typeWriterField.SelectionColor = System.Drawing.Color.Empty;
			this.typeWriterField.SelectAll();
			this.typeWriterField.SelectionColor = color;
			this.typeWriterField.DeselectAll();
			this.typeWriterField.SelectionColor = this.selectionColor;
		}

		private void uncheckAllBoxes() {
			foreach(var item in this.themes) 
				item.CheckState = CheckState.Unchecked;
		}
	}
}
