namespace Microsoft.AspNetCore.Routing.Patterns
{
	/// <summary>
	/// Defines the kinds of <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart" /> instances.
	/// </summary>
	public enum RoutePatternParameterKind
	{
		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterKind" /> of a standard parameter
		/// without optional or catch all behavior.
		/// </summary>
		Standard,
		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterKind" /> of an optional parameter.
		/// </summary>
		Optional,
		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterKind" /> of a catch-all parameter.
		/// </summary>
		CatchAll
	}
}
