using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Patterns
{
	/// <summary>
	/// Represents a parameter part in a route pattern. Instances of <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart" />
	/// are immutable.
	/// </summary>
	[DebuggerDisplay("{DebuggerToString()}")]
	public sealed class RoutePatternParameterPart : RoutePatternPart
	{
		/// <summary>
		/// Gets the list of parameter policies associated with this parameter.
		/// </summary>
		public IReadOnlyList<RoutePatternParameterPolicyReference> ParameterPolicies
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the value indicating if slashes in current parameter's value should be encoded.
		/// </summary>
		public bool EncodeSlashes
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the default value of this route parameter. May be null.
		/// </summary>
		public object? Default
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Returns <c>true</c> if this part is a catch-all parameter.
		/// Otherwise returns <c>false</c>.
		/// </summary>
		public bool IsCatchAll
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Returns <c>true</c> if this part is an optional parameter.
		/// Otherwise returns <c>false</c>.
		/// </summary>
		public bool IsOptional
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterKind" /> of this parameter.
		/// </summary>
		public RoutePatternParameterKind ParameterKind
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the parameter name.
		/// </summary>
		public string Name
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal RoutePatternParameterPart(string parameterName, object? @default, RoutePatternParameterKind parameterKind, RoutePatternParameterPolicyReference[] parameterPolicies)
		{
			throw null;
		}

		internal RoutePatternParameterPart(string parameterName, object? @default, RoutePatternParameterKind parameterKind, RoutePatternParameterPolicyReference[] parameterPolicies, bool encodeSlashes)
		{
			throw null;
		}

		internal override string DebuggerToString()
		{
			throw null;
		}
	}
}
