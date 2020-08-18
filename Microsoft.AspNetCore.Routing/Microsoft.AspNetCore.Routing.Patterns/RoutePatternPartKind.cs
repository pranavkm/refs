namespace Microsoft.AspNetCore.Routing.Patterns
{
	/// <summary>
	/// Defines the kinds of <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternPart" /> instances.
	/// </summary>
	public enum RoutePatternPartKind
	{
		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternPartKind" /> of a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternLiteralPart" />.
		/// </summary>
		Literal,
		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternPartKind" /> of a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart" />.
		/// </summary>
		Parameter,
		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternPartKind" /> of a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternSeparatorPart" />.
		/// </summary>
		Separator
	}
}
