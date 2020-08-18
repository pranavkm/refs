using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// An <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> implementation that compares objects as-if
	/// they were route value strings.
	/// </summary>
	/// <remarks>
	/// Values that are are not strings are converted to strings using
	/// <c>Convert.ToString(x, CultureInfo.InvariantCulture)</c>. <c>null</c> values are converted
	/// to the empty string.
	///
	/// strings are compared using <see cref="F:System.StringComparison.OrdinalIgnoreCase" />.
	/// </remarks>
	public class RouteValueEqualityComparer : IEqualityComparer<object?>
	{
		public static readonly RouteValueEqualityComparer Default;

		/// <inheritdoc />
		public new bool Equals(object? x, object? y)
		{
			throw null;
		}

		/// <inheritdoc />
		public int GetHashCode(object obj)
		{
			throw null;
		}

		public RouteValueEqualityComparer()
		{
			throw null;
		}
	}
}
