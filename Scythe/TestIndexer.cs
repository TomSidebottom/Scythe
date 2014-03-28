using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scythe
{
	public partial class TestIndexer : Form
	{

		public class DocResult
		{
			public LuceneClient LuceneClient { get; set; }
			public Lucene.Net.Search.ScoreDoc ScoreDoc { get; set; }

			public DocResult(LuceneClient client, Lucene.Net.Search.ScoreDoc scoreDoc)
			{
				this.LuceneClient = client;
				this.ScoreDoc = scoreDoc;
			}

			public string Description
			{
				get
				{
					Lucene.Net.Documents.Document document = this.LuceneClient.DocForID(this.ScoreDoc.Doc);
					return document.Get("filepath") + " score: " + this.ScoreDoc.Score.ToString();
				}
			}
		}

		public LuceneClient LuceneClient { get; set; }

		public TestIndexer()
		{
			InitializeComponent();
		}

		private void Search(object sender, EventArgs e)
		{
			Lucene.Net.Search.TopDocs result = this.LuceneClient.Search(searchTermTextBox.Text);

			resultListBox.Items.Clear();
			foreach (Lucene.Net.Search.ScoreDoc scoreDoc in result.ScoreDocs.OrderByDescending(doc => doc.Score))
			{
				resultListBox.Items.Add(new DocResult(this.LuceneClient, scoreDoc));
			}
		}

		private void NewIndexClicked(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				this.LuceneClient = new LuceneClient(saveFileDialog.FileName, true);
			}
		}

		private void OpenIndexClicked(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				this.LuceneClient = new LuceneClient(folderBrowserDialog.SelectedPath, false);
			}
		}

		private void IndexNewFiles(object sender, EventArgs e)
		{
			openFileDialog.Multiselect = true;
			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				this.LuceneClient.IndexFiles(openFileDialog.FileNames);
			}
		}

		private void DocSelected(object sender, EventArgs e)
		{
			DocResult result = (DocResult)resultListBox.SelectedItem;


		}
	}
}
