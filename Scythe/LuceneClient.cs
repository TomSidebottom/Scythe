using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scythe
{
	public class LuceneClient
	{
		public bool CreateIndex { get; set; }
		public string IndexDirectoryPath { get; set; }
		
		public LuceneSearcher Searcher { get; set; }

		public LuceneClient(string indexPath, bool createIndex)
		{
			this.IndexDirectoryPath = indexPath;
			this.CreateIndex = createIndex;
		}

		public void IndexFiles(string [] filePaths)
		{
			if (this.Searcher != null)
			{
				this.Searcher.Close();
				this.Searcher = null;
			}

			LuceneIndexer indexer = new LuceneIndexer(this.IndexDirectoryPath, this.CreateIndex);
			this.CreateIndex = false;

			foreach (string filePath in filePaths)
			{
				indexer.IndexFile(filePath);
			}

			indexer.Close();
		}

		private void InitializeSearch()
		{
			if (this.Searcher == null)
			{
				this.Searcher = new LuceneSearcher(this.IndexDirectoryPath);
			}
		}

		public Lucene.Net.Search.TopDocs Search(string queryString)
		{
			InitializeSearch();
			return this.Searcher.Search(queryString);
		}

		public Lucene.Net.Documents.Document DocForID(int docID)
		{
			InitializeSearch();
			return this.Searcher.DocForID(docID);
		}
	}
}
