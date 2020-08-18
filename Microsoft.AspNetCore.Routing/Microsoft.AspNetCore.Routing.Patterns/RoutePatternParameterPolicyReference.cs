using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Patterns
{
	/// <summary>
	/// The parsed representation of a policy in a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" /> parameter. Instances
	/// of <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference" /> are immutable.
	/// </summary>
	[DebuggerDisplay("{DebuggerToString()}")]
	public sealed class RoutePatternParameterPolicyReference
	{
		/// <summary>
		/// Gets the constraint text.
		/// </summary>
		public string? Content
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a pre-existing <see cref="T:Microsoft.AspNetCore.Routing.IParameterPolicy" /> that was used to construct this reference.
		/// </summary>
		public IParameterPolicy? ParameterPolicy
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		[System.Runtime.CompilerServices.NullableContext(1)]
		internal RoutePatternParameterPolicyReference(string content)
		{
			throw null;
		}

		[System.Runtime.CompilerServices.NullableContext(1)]
		internal RoutePatternParameterPolicyReference(IParameterPolicy parameterPolicy)
		{
			throw null;
		}
	}
}
