using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Patterns
{
	/// <summary>
	/// Represents a part of a route pattern.
	/// </summary>
	public abstract class RoutePatternPart
	{
		/// <summary>
		/// Gets the <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternPartKind" /> of this part.
		/// </summary>
		public RoutePatternPartKind PartKind
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Returns <c>true</c> if this part is literal text. Otherwise returns <c>false</c>.
		/// </summary>
		public bool IsLiteral
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Returns <c>true</c> if this part is a route parameter. Otherwise returns <c>false</c>.
		/// </summary>
		public bool IsParameter
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Returns <c>true</c> if this part is an optional separator. Otherwise returns <c>false</c>.
		/// </summary>
		public bool IsSeparator
		{
			get
			{
				throw null;
			}
		}

		private protected RoutePatternPart(RoutePatternPartKind partKind)
		{
			throw null;
		}

		internal abstract string DebuggerToString();
	}
}
