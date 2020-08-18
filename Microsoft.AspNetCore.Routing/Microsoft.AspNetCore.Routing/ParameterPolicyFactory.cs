using Microsoft.AspNetCore.Routing.Patterns;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Defines an abstraction for resolving inline parameter policies as instances of <see cref="T:Microsoft.AspNetCore.Routing.IParameterPolicy" />.
	/// </summary>
	public abstract class ParameterPolicyFactory
	{
		/// <summary>
		/// Creates a parameter policy.
		/// </summary>
		/// <param name="parameter">The parameter the parameter policy is being created for.</param>
		/// <param name="inlineText">The inline text to resolve.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.IParameterPolicy" /> for the parameter.</returns>
		public abstract IParameterPolicy Create(RoutePatternParameterPart? parameter, string inlineText);

		/// <summary>
		/// Creates a parameter policy.
		/// </summary>
		/// <param name="parameter">The parameter the parameter policy is being created for.</param>
		/// <param name="parameterPolicy">An existing parameter policy.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.IParameterPolicy" /> for the parameter.</returns>
		public abstract IParameterPolicy Create(RoutePatternParameterPart? parameter, IParameterPolicy parameterPolicy);

		/// <summary>
		/// Creates a parameter policy.
		/// </summary>
		/// <param name="parameter">The parameter the parameter policy is being created for.</param>
		/// <param name="reference">The reference to resolve.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.IParameterPolicy" /> for the parameter.</returns>
		public IParameterPolicy Create(RoutePatternParameterPart? parameter, RoutePatternParameterPolicyReference reference)
		{
			throw null;
		}

		protected ParameterPolicyFactory()
		{
			throw null;
		}
	}
}
