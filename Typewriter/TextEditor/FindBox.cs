using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor {
	public partial class FindBox : Form {
		public FindBox() {
			InitializeComponent();
		}

		private void findButton_Click(object sender , EventArgs e) {
			if(TypeWriter.text.Contains(this.findTextBox.Text)) {
				MessageBox.Show("Yes");
			}
			else {
				MessageBox.Show("No");
			}
		}
	}
}
