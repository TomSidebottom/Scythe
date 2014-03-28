using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using Lucene.Net.Documents;
using Lucene.Net.Index;

namespace Scythe.Core
{
	class Store
	{
		#region Consts and Statics
		public const string INDEX_RELATIVE_PATH = "\\Index";
		#endregion
		#region Properties
		public string DirectoryPath { get; set; }
		public string LuceneIndexPath { get; set; }
		#endregion

		public Store(string directoryPath, bool createIndex)
		{
			this.DirectoryPath = directoryPath;
			this.LuceneIndexPath = this.DirectoryPath + INDEX_RELATIVE_PATH;

		}

		#region File handling
		public void CreateIndex()
		{

		}

		public void OpenIndex()
		{
		}
		#endregion
	}
}
