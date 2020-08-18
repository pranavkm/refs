using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.StackTrace.Sources;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Diagnostics.RazorViews
{
	/// <summary>
	/// Holds data to be displayed on the compilation error page.
	/// </summary>
	internal class CompilationErrorPageModel
	{
		/// <summary>
		/// Options for what output to display.
		/// </summary>
		public DeveloperExceptionPageOptions Options
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Detailed information about each parse or compilation error.
		/// </summary>
		public IList<ExceptionDetails> ErrorDetails
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the generated content that produced the corresponding <see cref="P:Microsoft.AspNetCore.Diagnostics.RazorViews.CompilationErrorPageModel.ErrorDetails" />.
		/// </summary>
		public IList<string> CompiledContent
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public CompilationErrorPageModel()
		{
			throw null;
		}
	}
}
