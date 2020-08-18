using Microsoft.Extensions.Options;
using System;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// The default implementation of <see cref="T:Microsoft.AspNetCore.Routing.IInlineConstraintResolver" />. Resolves constraints by parsing
	/// a constraint key and constraint arguments, using a map to resolve the constraint type, and calling an
	/// appropriate constructor for the constraint type.
	/// </summary>
	public class DefaultInlineConstraintResolver : IInlineConstraintResolver
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.DefaultInlineConstraintResolver" /> class.
		/// </summary>
		/// <param name="routeOptions">Accessor for <see cref="T:Microsoft.AspNetCore.Routing.RouteOptions" /> containing the constraints of interest.</param>
		/// <param name="serviceProvider">The <see cref="T:System.IServiceProvider" /> to get service arguments from.</param>
		public DefaultInlineConstraintResolver(IOptions<RouteOptions> routeOptions, IServiceProvider serviceProvider)
		{
			throw null;
		}

		/// <inheritdoc />
		/// <example>
		/// A typical constraint looks like the following
		/// "exampleConstraint(arg1, arg2, 12)".
		/// Here if the type registered for exampleConstraint has a single constructor with one argument,
		/// The entire string "arg1, arg2, 12" will be treated as a single argument.
		/// In all other cases arguments are split at comma.
		/// </example>
		public virtual IRouteConstraint? ResolveConstraint(string inlineConstraint)
		{
			throw null;
		}
	}
}
