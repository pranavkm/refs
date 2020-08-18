namespace Microsoft.AspNetCore.Routing.Patterns
{
	/// <summary>
	/// A singleton service that provides transformations on <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" />.
	/// </summary>
	public abstract class RoutePatternTransformer
	{
		/// <summary>
		/// Attempts to substitute the provided <paramref name="requiredValues" /> into the provided
		/// <paramref name="original" />.
		/// </summary>
		/// <param name="original">The original <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" />.</param>
		/// <param name="requiredValues">The required values to substitute.</param>
		/// <returns>
		/// A new <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" /> if substitution succeeds, otherwise <c>null</c>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// Substituting required values into a route pattern is intended for us with a general-purpose
		/// parameterize route specification that can match many logical endpoints. Calling 
		/// <see cref="M:Microsoft.AspNetCore.Routing.Patterns.RoutePatternTransformer.SubstituteRequiredValues(Microsoft.AspNetCore.Routing.Patterns.RoutePattern,System.Object)" /> can produce a derived route pattern
		/// for each set of route values that corresponds to an endpoint.
		/// </para>
		/// <para>
		/// The substitution process considers default values and <see cref="T:Microsoft.AspNetCore.Routing.IRouteConstraint" /> implementations
		/// when examining a required value. <see cref="M:Microsoft.AspNetCore.Routing.Patterns.RoutePatternTransformer.SubstituteRequiredValues(Microsoft.AspNetCore.Routing.Patterns.RoutePattern,System.Object)" /> will
		/// return <c>null</c> if any required value cannot be substituted.
		/// </para>
		/// </remarks>
		public abstract RoutePattern? SubstituteRequiredValues(RoutePattern original, object requiredValues);

		protected RoutePatternTransformer()
		{
			throw null;
		}
	}
}
