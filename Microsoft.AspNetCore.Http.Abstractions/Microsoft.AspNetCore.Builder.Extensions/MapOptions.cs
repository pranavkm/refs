using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Builder.Extensions
{
	/// <summary>
	/// Options for the <see cref="T:Microsoft.AspNetCore.Builder.Extensions.MapMiddleware" />.
	/// </summary>
	public class MapOptions
	{
		/// <summary>
		/// The path to match.
		/// </summary>
		public PathString PathMatch
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

		/// <summary>
		/// If false, matched path would be removed from Request.Path and added to Request.PathBase
		/// Defaults to false.
		/// </summary>
		public bool PreserveMatchedPathSegment
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

		public MapOptions()
		{
			throw null;
		}
	}
}
