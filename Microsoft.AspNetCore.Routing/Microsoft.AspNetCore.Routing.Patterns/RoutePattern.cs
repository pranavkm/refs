using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Patterns
{
	/// <summary>
	/// Represents a parsed route template with default values and constraints.
	/// Use <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternFactory" /> to create <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" />
	/// instances. Instances of <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" /> are immutable.
	/// </summary>
	[DebuggerDisplay("{DebuggerToString()}")]
	public sealed class RoutePattern
	{
		[DebuggerDisplay("{DebuggerToString(),nq}")]
		private class RequiredValueAnySentinal
		{
			public RequiredValueAnySentinal()
			{
				throw null;
			}
		}

		/// <summary>
		/// A marker object that can be used in <see cref="P:Microsoft.AspNetCore.Routing.Patterns.RoutePattern.RequiredValues" /> to designate that
		/// any non-null or non-empty value is required.
		/// </summary>
		/// <remarks>
		/// <see cref="F:Microsoft.AspNetCore.Routing.Patterns.RoutePattern.RequiredValueAny" /> is only use in routing is in <see cref="P:Microsoft.AspNetCore.Routing.Patterns.RoutePattern.RequiredValues" />.
		/// <see cref="F:Microsoft.AspNetCore.Routing.Patterns.RoutePattern.RequiredValueAny" /> is not valid as a route value, and will convert to the null/empty string.
		/// </remarks>
		public static readonly object RequiredValueAny;

		/// <summary>
		/// Gets the set of default values for the route pattern.
		/// The keys of <see cref="P:Microsoft.AspNetCore.Routing.Patterns.RoutePattern.Defaults" /> are the route parameter names.
		/// </summary>
		public IReadOnlyDictionary<string, object?> Defaults
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the set of parameter policy references for the route pattern.
		/// The keys of <see cref="P:Microsoft.AspNetCore.Routing.Patterns.RoutePattern.ParameterPolicies" /> are the route parameter names.
		/// </summary>
		public IReadOnlyDictionary<string, IReadOnlyList<RoutePatternParameterPolicyReference>> ParameterPolicies
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a collection of route values that must be provided for this route pattern to be considered
		/// applicable.
		/// </summary>
		/// <remarks>
		/// <para>
		/// <see cref="P:Microsoft.AspNetCore.Routing.Patterns.RoutePattern.RequiredValues" /> allows a framework to substitute route values into a parameterized template
		/// so that the same route template specification can be used to create multiple route patterns.
		/// <example>
		/// This example shows how a route template can be used with required values to substitute known
		/// route values for parameters.
		/// <code>
		/// Route Template: "{controller=Home}/{action=Index}/{id?}"
		/// Route Values: { controller = "Store", action = "Index" }
		/// </code>
		///
		/// A route pattern produced in this way will match and generate URL paths like: <c>/Store</c>, 
		/// <c>/Store/Index</c>, and <c>/Store/Index/17</c>.
		/// </example>
		/// </para>
		/// </remarks>
		public IReadOnlyDictionary<string, object?> RequiredValues
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the precedence value of the route pattern for URL matching.
		/// </summary>
		/// <remarks>
		/// Precedence is a computed value based on the structure of the route pattern
		/// used for building URL matching data structures.
		/// </remarks>
		public decimal InboundPrecedence
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the precedence value of the route pattern for URL generation.
		/// </summary>
		/// <remarks>
		/// Precedence is a computed value based on the structure of the route pattern
		/// used for building URL generation data structures.
		/// </remarks>
		public decimal OutboundPrecedence
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the raw text supplied when parsing the route pattern. May be null.
		/// </summary>
		public string? RawText
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the list of route parameters.
		/// </summary>
		public IReadOnlyList<RoutePatternParameterPart> Parameters
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the list of path segments.
		/// </summary>
		public IReadOnlyList<RoutePatternPathSegment> PathSegments
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal static bool IsRequiredValueAny(object? value)
		{
			throw null;
		}

		internal RoutePattern(string? rawText, IReadOnlyDictionary<string, object?> defaults, IReadOnlyDictionary<string, IReadOnlyList<RoutePatternParameterPolicyReference>> parameterPolicies, IReadOnlyDictionary<string, object?> requiredValues, IReadOnlyList<RoutePatternParameterPart> parameters, IReadOnlyList<RoutePatternPathSegment> pathSegments)
		{
			throw null;
		}

		/// <summary>
		/// Gets the parameter matching the given name.
		/// </summary>
		/// <param name="name">The name of the parameter to match.</param>
		/// <returns>The matching parameter or <c>null</c> if no parameter matches the given name.</returns>
		public RoutePatternParameterPart? GetParameter(string name)
		{
			throw null;
		}

		internal string DebuggerToString()
		{
			throw null;
		}
	}
}
