using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Patterns
{
	/// <summary>
	/// Resprents a literal text part of a route pattern. Instances of <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternLiteralPart" />
	/// are immutable.
	/// </summary>
	[DebuggerDisplay("{DebuggerToString()}")]
	public sealed class RoutePatternLiteralPart : RoutePatternPart
	{
		/// <summary>
		/// Gets the text content.
		/// </summary>
		public string Content
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal RoutePatternLiteralPart(string content)
		{
			throw null;
		}

		internal override string DebuggerToString()
		{
			throw null;
		}
	}
}
