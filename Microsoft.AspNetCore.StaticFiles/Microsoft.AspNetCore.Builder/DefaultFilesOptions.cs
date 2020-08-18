using Microsoft.AspNetCore.StaticFiles.Infrastructure;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Options for selecting default file names.
	/// </summary>
	public class DefaultFilesOptions : SharedOptionsBase
	{
		/// <summary>
		/// An ordered list of file names to select by default. List length and ordering may affect performance.
		/// </summary>
		public IList<string> DefaultFileNames
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
		/// Configuration for the DefaultFilesMiddleware.
		/// </summary>
		public DefaultFilesOptions()
		{
			throw null;
		}

		/// <summary>
		/// Configuration for the DefaultFilesMiddleware.
		/// </summary>
		/// <param name="sharedOptions"></param>
		public DefaultFilesOptions(SharedOptions sharedOptions)
		{
			throw null;
		}
	}
}
