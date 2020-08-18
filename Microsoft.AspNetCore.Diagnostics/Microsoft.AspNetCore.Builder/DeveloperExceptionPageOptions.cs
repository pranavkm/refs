using Microsoft.Extensions.FileProviders;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Options for the <see cref="T:Microsoft.AspNetCore.Diagnostics.DeveloperExceptionPageMiddleware" />.
	/// </summary>
	public class DeveloperExceptionPageOptions
	{
		/// <summary>
		/// Determines how many lines of code to include before and after the line of code
		/// present in an exception's stack frame. Only applies when symbols are available and
		/// source code referenced by the exception stack trace is present on the server.
		/// </summary>
		public int SourceCodeLineCount
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
		/// Provides files containing source code used to display contextual information of an exception.
		/// </summary>
		/// <remarks>
		/// If <c>null</c> <see cref="T:Microsoft.AspNetCore.Diagnostics.DeveloperExceptionPageMiddleware" /> will use a <see cref="T:Microsoft.Extensions.FileProviders.PhysicalFileProvider" />.
		/// </remarks>
		public IFileProvider FileProvider
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
		/// Create an instance with the default options settings.
		/// </summary>
		public DeveloperExceptionPageOptions()
		{
			throw null;
		}
	}
}
