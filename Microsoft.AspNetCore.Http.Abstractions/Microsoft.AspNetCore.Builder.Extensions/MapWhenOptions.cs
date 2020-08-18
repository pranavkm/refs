using Microsoft.AspNetCore.Http;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Builder.Extensions
{
	/// <summary>
	/// Options for the <see cref="T:Microsoft.AspNetCore.Builder.Extensions.MapWhenMiddleware" />.
	/// </summary>
	public class MapWhenOptions
	{
		/// <summary>
		/// The user callback that determines if the branch should be taken.
		/// </summary>
		public Func<HttpContext, bool>? Predicate
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// The branch taken for a positive match.
		/// </summary>
		public RequestDelegate? Branch
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

		public MapWhenOptions()
		{
			throw null;
		}
	}
}
