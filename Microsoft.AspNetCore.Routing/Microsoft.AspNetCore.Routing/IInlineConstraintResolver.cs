namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Defines an abstraction for resolving inline constraints as instances of <see cref="T:Microsoft.AspNetCore.Routing.IRouteConstraint" />.
	/// </summary>
	public interface IInlineConstraintResolver
	{
		/// <summary>
		/// Resolves the inline constraint.
		/// </summary>
		/// <param name="inlineConstraint">The inline constraint to resolve.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.IRouteConstraint" /> the inline constraint was resolved to.</returns>
		IRouteConstraint? ResolveConstraint(string inlineConstraint);
	}
}
