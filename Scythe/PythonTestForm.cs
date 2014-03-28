using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IronPython.Hosting;
using IronPython.Runtime;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using Microsoft.Scripting.Utils;

namespace Scythe
{
	public partial class PythonTestForm : Form
	{

		#region Properties
		private ScriptEngine PythonEngine { get; set; }
		private ScriptRuntime PythonRuntime { get; set; }
		private ScriptScope PythonScope { get; set; }
		#endregion

		public PythonTestForm()
		{
			InitializeComponent();

			this.PythonEngine = Python.CreateEngine();
			this.PythonScope = this.PythonEngine.CreateScope();

		}

		private void RunScript(object sender, EventArgs e)
		{
			ScriptSource source = this.PythonEngine.CreateScriptSourceFromString(pythonSourceTextBox.Text, 
				SourceCodeKind.Statements);
			CompiledCode code = source.Compile();

			code.Execute(this.PythonScope);

			object myClass = this.PythonEngine.Operations.Invoke(this.PythonScope.GetVariable("MyClass"));
			Func<int, bool> IsOdd = this.PythonEngine.Operations.GetMember<Func<int, bool>>(myClass, "isodd");
			StringBuilder builder = new StringBuilder();
			builder.Append("Is 2 odd? ");
			builder.Append(IsOdd(2));
			builder.Append(" Is 3 odd? ");
			builder.Append(IsOdd(3));
			outputTextBox.Text = builder.ToString();
		}
	}
}
