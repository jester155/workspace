using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace WebContext {
	class wikiContent {
		
		private string url;
		private string wikiImageUrl;

		public wikiContent() {
				
		}

		public void setUrlString(string wikiSite) { //.Sets the url that is going to be used.
			this.url = wikiSite;
		}

		public string getHTMLCode(string url) { //.Draws up the html to display in a browser window. (overloaded)
			var wikipedia = new WebClient();
			var wikiContents = new StringBuilder();
			try {
				wikiContents.Append(wikipedia.DownloadString(url));
			}
			catch(Exception) {
				MessageBox.Show("please enter in a proper value\nCheck your spelling!");
			}

			if(wikiContents.Length > 0) {
				int start = wikiContents.ToString().IndexOf("<table class=\"infobox");
				if(start < 1)
					start = 0;
				int stop = wikiContents.ToString().IndexOf("</table>" , start + 1);
				string sub = wikiContents.ToString().Substring(start , stop - start) + "</table>";

				var htmlBuilder = new StringBuilder(sub);

				int imgStart = sub.IndexOf("src=\"");
				int imgStop = sub.IndexOf("\"" , imgStart + 5);
				this.wikiImageUrl = sub.Substring(imgStart + 7 , imgStop - imgStart - 7);

				int removeImageStart = sub.IndexOf("<a");
				int removeImageStop = sub.IndexOf("/a>" , removeImageStart);
				htmlBuilder.Remove(removeImageStart , removeImageStop - removeImageStart + 3);

				htmlBuilder.Replace("//" + wikiImageUrl , "http://" + wikiImageUrl);
				htmlBuilder.Replace("â€“" , "-");
				htmlBuilder.Replace("Â" , "");

				return htmlBuilder.ToString();
			}
			else
				return null;

		}

		public string formatText(string text) {
			if(text.Length > 0) {
				var firstLetter = text.Substring(0 , 1).ToUpper();
				var sb = new StringBuilder(text);
				sb.Remove(0 , 1);
				sb.Insert(0 , firstLetter);
				return sb.ToString();
			}
			return null;
		}

		public void setWikiImg(string url) {

		}

		public string getWikiImage() {
			return "http://" + this.wikiImageUrl;
		}
	}
}
