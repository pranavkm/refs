using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Diagnostics
{
	/// <summary>
	/// A single diagnostic message.
	/// </summary>
	public class DiagnosticMessage
	{
		/// <summary>
		/// Path of the file that produced the message.
		/// </summary>
		public string SourceFilePath
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the error message.
		/// </summary>
		public string Message
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the one-based line index for the start of the compilation error.
		/// </summary>
		public int StartLine
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the zero-based column index for the start of the compilation error.
		/// </summary>
		public int StartColumn
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the one-based line index for the end of the compilation error.
		/// </summary>
		public int EndLine
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the zero-based column index for the end of the compilation error.
		/// </summary>
		public int EndColumn
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the formatted error message.
		/// </summary>
		public string FormattedMessage
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public DiagnosticMessage(string message, string formattedMessage, string filePath, int startLine, int startColumn, int endLine, int endColumn)
		{
			throw null;
		}
	}
}
