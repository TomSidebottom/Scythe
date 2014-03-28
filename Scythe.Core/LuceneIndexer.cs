using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scythe.Core
{
	class LuceneIndexer
	{
		public Lucene.Net.Index.IndexWriter IndexWriter { get; set; }
		public string IndexPath { get; set; }

		public LuceneIndexer(string indexPath, bool createIndex)
		{
			this.IndexPath = indexPath;
			Lucene.Net.Store.Directory directory = Lucene.Net.Store.FSDirectory.Open(indexPath);
			this.IndexWriter = new Lucene.Net.Index.IndexWriter(directory,
				new Lucene.Net.Analysis.Standard.StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30),
				createIndex,
				Lucene.Net.Index.IndexWriter.MaxFieldLength.UNLIMITED);
		}

		public void Close()
		{
			this.IndexWriter.Flush(true, true, true);
			this.IndexWriter.Close();
		}

		public void IndexFile(string filePath)
		{
			Lucene.Net.Documents.Document document = new Lucene.Net.Documents.Document();

			System.IO.StreamReader reader = new System.IO.StreamReader(filePath);

			document.Add(new Lucene.Net.Documents.Field("contents", reader));
			document.Add(new Lucene.Net.Documents.Field("filepath", filePath, Lucene.Net.Documents.Field.Store.YES, Lucene.Net.Documents.Field.Index.NOT_ANALYZED));

			this.IndexWriter.AddDocument(document);
		}
	}
}
