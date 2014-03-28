using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scythe
{
	public class LuceneIndexReader
	{
		private Lucene.Net.Index.IndexReader IndexReader { get; set; }

		public LuceneIndexReader(string indexPath)
		{
			Lucene.Net.Store.Directory directory = Lucene.Net.Store.FSDirectory.Open(indexPath);
			this.IndexReader = Lucene.Net.Index.IndexReader.Open(directory, true);
		}

		public Lucene.Net.Index.ITermFreqVector[] GetVectorsForDoc(int docNumber)
		{
			return this.IndexReader.GetTermFreqVectors(docNumber);
		}
	}
}
