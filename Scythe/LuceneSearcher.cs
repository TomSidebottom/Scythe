using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scythe
{
	public class LuceneSearcher
	{
		private Lucene.Net.Search.IndexSearcher IndexSearcher { get; set; }

		public LuceneSearcher(string indexPath)
		{
			this.IndexSearcher = new Lucene.Net.Search.IndexSearcher(Lucene.Net.Store.FSDirectory.Open(indexPath));
		}

		public void Close()
		{
			this.IndexSearcher.Dispose();
		}

		public Lucene.Net.Search.TopDocs Search(string queryString)
		{
			Lucene.Net.QueryParsers.QueryParser parser = new Lucene.Net.QueryParsers.QueryParser(Lucene.Net.Util.Version.LUCENE_30, 
				"contents", 
				new Lucene.Net.Analysis.Standard.StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30));

			Lucene.Net.Search.Query query = parser.Parse(queryString);

			return this.IndexSearcher.Search(query, 100);
		}

		public Lucene.Net.Documents.Document DocForID(int docID)
		{
			return this.IndexSearcher.Doc(docID);
		}
	}
}
