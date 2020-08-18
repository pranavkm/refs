using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Diagnostics
{
	/// <summary>
	/// Describes a failure compiling a specific file.
	/// </summary>
	public class CompilationFailure
	{
		/// <summary>
		/// Path of the file that produced the compilation failure.
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
		/// Contents of the file.
		/// </summary>
		public string SourceFileContent
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Contents being compiled.
		/// </summary>
		/// <remarks>
		/// For templated files, the <see cref="P:Microsoft.AspNetCore.Diagnostics.CompilationFailure.SourceFileContent" /> represents the original content and
		/// <see cref="P:Microsoft.AspNetCore.Diagnostics.CompilationFailure.CompiledContent" /> represents the transformed content. This property can be null if
		/// the exception is encountered during transformation.
		/// </remarks>
		public string CompiledContent
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a sequence of <see cref="T:Microsoft.AspNetCore.Diagnostics.DiagnosticMessage" /> produced as a result of compilation.
		/// </summary>
		public IEnumerable<DiagnosticMessage> Messages
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Summary message or instructions to fix the failure.
		/// </summary>
		public string FailureSummary
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of <see cref="T:Microsoft.AspNetCore.Diagnostics.CompilationFailure" />.
		/// </summary>
		/// <param name="sourceFilePath">Path for the file that produced the compilation failure.</param>
		/// <param name="sourceFileContent">Contents of the file being compiled.</param>
		/// <param name="compiledContent">For templated languages (such as Asp.Net Core Razor), the generated content.
		/// </param>
		/// <param name="messages">One or or more <see cref="T:Microsoft.AspNetCore.Diagnostics.DiagnosticMessage" /> instances.</param>
		public CompilationFailure(string sourceFilePath, string sourceFileContent, string compiledContent, IEnumerable<DiagnosticMessage> messages)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of <see cref="T:Microsoft.AspNetCore.Diagnostics.CompilationFailure" />.
		/// </summary>
		/// <param name="sourceFilePath">Path for the file that produced the compilation failure.</param>
		/// <param name="sourceFileContent">Contents of the file being compiled.</param>
		/// <param name="compiledContent">For templated languages (such as Asp.Net Core Razor), the generated content.
		/// </param>
		/// <param name="messages">One or or more <see cref="T:Microsoft.AspNetCore.Diagnostics.DiagnosticMessage" /> instances.</param>
		/// <param name="failureSummary">Summary message or instructions to fix the failure.</param>
		public CompilationFailure(string sourceFilePath, string sourceFileContent, string compiledContent, IEnumerable<DiagnosticMessage> messages, string failureSummary)
		{
			throw null;
		}
	}
}
