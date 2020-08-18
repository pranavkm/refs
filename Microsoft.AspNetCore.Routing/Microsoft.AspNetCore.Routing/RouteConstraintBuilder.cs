using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// A builder for produding a mapping of keys to see <see cref="T:Microsoft.AspNetCore.Routing.IRouteConstraint" />.
	/// </summary>
	/// <remarks>
	/// <see cref="T:Microsoft.AspNetCore.Routing.RouteConstraintBuilder" /> allows iterative building a set of route constraints, and will
	/// merge multiple entries for the same key.
	/// </remarks>
	public class RouteConstraintBuilder
	{
		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Routing.RouteConstraintBuilder" /> instance.
		/// </summary>
		/// <param name="inlineConstraintResolver">The <see cref="T:Microsoft.AspNetCore.Routing.IInlineConstraintResolver" />.</param>
		/// <param name="displayName">The display name (for use in error messages).</param>
		public RouteConstraintBuilder(IInlineConstraintResolver inlineConstraintResolver, string displayName)
		{
			throw null;
		}

		/// <summary>
		/// Builds a mapping of constraints.
		/// </summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IDictionary`2" /> of the constraints.</returns>
		public IDictionary<string, IRouteConstraint> Build()
		{
			throw null;
		}

		/// <summary>
		/// Adds a constraint instance for the given key.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <param name="value">
		/// The constraint instance. Must either be a string or an instance of <see cref="T:Microsoft.AspNetCore.Routing.IRouteConstraint" />.
		/// </param>
		/// <remarks>
		/// If the <paramref name="value" /> is a string, it will be converted to a <see cref="T:Microsoft.AspNetCore.Routing.Constraints.RegexRouteConstraint" />.
		///
		/// For example, the string <c>Product[0-9]+</c> will be converted to the regular expression
		/// <c>^(Product[0-9]+)</c>. See <see cref="T:System.Text.RegularExpressions.Regex" /> for more details.
		/// </remarks>
		public void AddConstraint(string key, object value)
		{
			throw null;
		}

		/// <summary>
		/// Adds a constraint for the given key, resolved by the <see cref="T:Microsoft.AspNetCore.Routing.IInlineConstraintResolver" />.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <param name="constraintText">The text to be resolved by <see cref="T:Microsoft.AspNetCore.Routing.IInlineConstraintResolver" />.</param>
		/// <remarks>
		/// The <see cref="T:Microsoft.AspNetCore.Routing.IInlineConstraintResolver" /> can create <see cref="T:Microsoft.AspNetCore.Routing.IRouteConstraint" /> instances
		/// based on <paramref name="constraintText" />. See <see cref="P:Microsoft.AspNetCore.Routing.RouteOptions.ConstraintMap" /> to register
		/// custom constraint types.
		/// </remarks>
		public void AddResolvedConstraint(string key, string constraintText)
		{
			throw null;
		}

		/// <summary>
		/// Sets the given key as optional.
		/// </summary>
		/// <param name="key">The key.</param>
		public void SetOptional(string key)
		{
			throw null;
		}
	}
}
