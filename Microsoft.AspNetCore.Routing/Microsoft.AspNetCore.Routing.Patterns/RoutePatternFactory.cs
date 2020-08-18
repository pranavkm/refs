using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing.Patterns
{
	/// <summary>
	/// Contains factory methods for creating <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" /> and related types.
	/// Use <see cref="M:Microsoft.AspNetCore.Routing.Patterns.RoutePatternFactory.Parse(System.String)" /> to parse a route pattern in
	/// string format.
	/// </summary>
	public static class RoutePatternFactory
	{
		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" /> from its string representation.
		/// </summary>
		/// <param name="pattern">The route pattern string to parse.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" />.</returns>
		public static RoutePattern Parse(string pattern)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" /> from its string representation along
		/// with provided default values and parameter policies.
		/// </summary>
		/// <param name="pattern">The route pattern string to parse.</param>
		/// <param name="defaults">
		/// Additional default values to associated with the route pattern. May be null.
		/// The provided object will be converted to key-value pairs using <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" />
		/// and then merged into the parsed route pattern.
		/// </param>
		/// <param name="parameterPolicies">
		/// Additional parameter policies to associated with the route pattern. May be null.
		/// The provided object will be converted to key-value pairs using <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" />
		/// and then merged into the parsed route pattern.
		/// Multiple policies can be specified for a key by providing a collection as the value.
		/// </param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" />.</returns>
		public static RoutePattern Parse(string pattern, object? defaults, object? parameterPolicies)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" /> from its string representation along
		/// with provided default values and parameter policies.
		/// </summary>
		/// <param name="pattern">The route pattern string to parse.</param>
		/// <param name="defaults">
		/// Additional default values to associated with the route pattern. May be null.
		/// The provided object will be converted to key-value pairs using <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" />
		/// and then merged into the parsed route pattern.
		/// </param>
		/// <param name="parameterPolicies">
		/// Additional parameter policies to associated with the route pattern. May be null.
		/// The provided object will be converted to key-value pairs using <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" />
		/// and then merged into the parsed route pattern.
		/// Multiple policies can be specified for a key by providing a collection as the value.
		/// </param>
		/// <param name="requiredValues">
		/// Route values that can be substituted for parameters in the route pattern. See remarks on <see cref="P:Microsoft.AspNetCore.Routing.Patterns.RoutePattern.RequiredValues" />.
		/// </param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" />.</returns>
		public static RoutePattern Parse(string pattern, object? defaults, object? parameterPolicies, object? requiredValues)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" /> from a collection of segments.
		/// </summary>
		/// <param name="segments">The collection of segments.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" />.</returns>
		public static RoutePattern Pattern(IEnumerable<RoutePatternPathSegment> segments)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" /> from a collection of segments.
		/// </summary>
		/// <param name="rawText">The raw text to associate with the route pattern. May be null.</param>
		/// <param name="segments">The collection of segments.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" />.</returns>
		public static RoutePattern Pattern(string? rawText, IEnumerable<RoutePatternPathSegment> segments)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" /> from a collection of segments along
		/// with provided default values and parameter policies.
		/// </summary>
		/// <param name="defaults">
		/// Additional default values to associated with the route pattern. May be null.
		/// The provided object will be converted to key-value pairs using <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" />
		/// and then merged into the route pattern.
		/// </param>
		/// <param name="parameterPolicies">
		/// Additional parameter policies to associated with the route pattern. May be null.
		/// The provided object will be converted to key-value pairs using <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" />
		/// and then merged into the route pattern.
		/// Multiple policies can be specified for a key by providing a collection as the value.
		/// </param>
		/// <param name="segments">The collection of segments.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" />.</returns>
		public static RoutePattern Pattern(object? defaults, object? parameterPolicies, IEnumerable<RoutePatternPathSegment> segments)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" /> from a collection of segments along
		/// with provided default values and parameter policies.
		/// </summary>
		/// <param name="rawText">The raw text to associate with the route pattern. May be null.</param>
		/// <param name="defaults">
		/// Additional default values to associated with the route pattern. May be null.
		/// The provided object will be converted to key-value pairs using <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" />
		/// and then merged into the route pattern.
		/// </param>
		/// <param name="parameterPolicies">
		/// Additional parameter policies to associated with the route pattern. May be null.
		/// The provided object will be converted to key-value pairs using <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" />
		/// and then merged into the route pattern.
		/// Multiple policies can be specified for a key by providing a collection as the value.
		/// </param>
		/// <param name="segments">The collection of segments.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" />.</returns>
		public static RoutePattern Pattern(string? rawText, object? defaults, object? parameterPolicies, IEnumerable<RoutePatternPathSegment> segments)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" /> from a collection of segments.
		/// </summary>
		/// <param name="segments">The collection of segments.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" />.</returns>
		public static RoutePattern Pattern(params RoutePatternPathSegment[] segments)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" /> from a collection of segments.
		/// </summary>
		/// <param name="rawText">The raw text to associate with the route pattern. May be null.</param>
		/// <param name="segments">The collection of segments.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" />.</returns>
		public static RoutePattern Pattern(string rawText, params RoutePatternPathSegment[] segments)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" /> from a collection of segments along
		/// with provided default values and parameter policies.
		/// </summary>
		/// <param name="defaults">
		/// Additional default values to associated with the route pattern. May be null.
		/// The provided object will be converted to key-value pairs using <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" />
		/// and then merged into the route pattern.
		/// </param>
		/// <param name="parameterPolicies">
		/// Additional parameter policies to associated with the route pattern. May be null.
		/// The provided object will be converted to key-value pairs using <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" />
		/// and then merged into the route pattern.
		/// Multiple policies can be specified for a key by providing a collection as the value.
		/// </param>
		/// <param name="segments">The collection of segments.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" />.</returns>
		public static RoutePattern Pattern(object? defaults, object? parameterPolicies, params RoutePatternPathSegment[] segments)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" /> from a collection of segments along
		/// with provided default values and parameter policies.
		/// </summary>
		/// <param name="rawText">The raw text to associate with the route pattern.</param>
		/// <param name="defaults">
		/// Additional default values to associated with the route pattern. May be null.
		/// The provided object will be converted to key-value pairs using <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" />
		/// and then merged into the route pattern.
		/// </param>
		/// <param name="parameterPolicies">
		/// Additional parameter policies to associated with the route pattern. May be null.
		/// The provided object will be converted to key-value pairs using <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" />
		/// and then merged into the route pattern.
		/// Multiple policies can be specified for a key by providing a collection as the value.
		/// </param>
		/// <param name="segments">The collection of segments.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" />.</returns>
		public static RoutePattern Pattern(string? rawText, object? defaults, object? parameterPolicies, params RoutePatternPathSegment[] segments)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment" /> from the provided collection
		/// of parts.
		/// </summary>
		/// <param name="parts">The collection of parts.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment" />.</returns>
		public static RoutePatternPathSegment Segment(IEnumerable<RoutePatternPart> parts)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment" /> from the provided collection
		/// of parts.
		/// </summary>
		/// <param name="parts">The collection of parts.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment" />.</returns>
		public static RoutePatternPathSegment Segment(params RoutePatternPart[] parts)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternLiteralPart" /> from the provided text
		/// content.
		/// </summary>
		/// <param name="content">The text content.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternLiteralPart" />.</returns>
		public static RoutePatternLiteralPart LiteralPart(string content)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternSeparatorPart" /> from the provided text
		/// content.
		/// </summary>
		/// <param name="content">The text content.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternSeparatorPart" />.</returns>
		public static RoutePatternSeparatorPart SeparatorPart(string content)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart" /> from the provided parameter name.
		/// </summary>
		/// <param name="parameterName">The parameter name.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart" />.</returns>
		public static RoutePatternParameterPart ParameterPart(string parameterName)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart" /> from the provided parameter name
		/// and default value.
		/// </summary>
		/// <param name="parameterName">The parameter name.</param>
		/// <param name="default">The parameter default value. May be <c>null</c>.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart" />.</returns>
		public static RoutePatternParameterPart ParameterPart(string parameterName, object @default)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart" /> from the provided parameter name
		/// and default value, and parameter kind.
		/// </summary>
		/// <param name="parameterName">The parameter name.</param>
		/// <param name="default">The parameter default value. May be <c>null</c>.</param>
		/// <param name="parameterKind">The parameter kind.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart" />.</returns>
		public static RoutePatternParameterPart ParameterPart(string parameterName, object? @default, RoutePatternParameterKind parameterKind)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart" /> from the provided parameter name
		/// and default value, parameter kind, and parameter policies.
		/// </summary>
		/// <param name="parameterName">The parameter name.</param>
		/// <param name="default">The parameter default value. May be <c>null</c>.</param>
		/// <param name="parameterKind">The parameter kind.</param>
		/// <param name="parameterPolicies">The parameter policies to associated with the parameter.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart" />.</returns>
		public static RoutePatternParameterPart ParameterPart(string parameterName, object? @default, RoutePatternParameterKind parameterKind, IEnumerable<RoutePatternParameterPolicyReference> parameterPolicies)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart" /> from the provided parameter name
		/// and default value, parameter kind, and parameter policies.
		/// </summary>
		/// <param name="parameterName">The parameter name.</param>
		/// <param name="default">The parameter default value. May be <c>null</c>.</param>
		/// <param name="parameterKind">The parameter kind.</param>
		/// <param name="parameterPolicies">The parameter policies to associated with the parameter.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPart" />.</returns>
		public static RoutePatternParameterPart ParameterPart(string parameterName, object? @default, RoutePatternParameterKind parameterKind, params RoutePatternParameterPolicyReference[] parameterPolicies)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference" /> from the provided contraint.
		/// </summary>
		/// <param name="constraint">
		/// The constraint object, which must be of type <see cref="T:Microsoft.AspNetCore.Routing.IRouteConstraint" />
		/// or <see cref="T:System.String" />. If the constraint object is a <see cref="T:System.String" />
		/// then it will be tranformed into an instance of <see cref="T:Microsoft.AspNetCore.Routing.Constraints.RegexRouteConstraint" />.
		/// </param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference" />.</returns>
		public static RoutePatternParameterPolicyReference Constraint(object constraint)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference" /> from the provided constraint.
		/// </summary>
		/// <param name="constraint">
		/// The constraint object.
		/// </param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference" />.</returns>
		public static RoutePatternParameterPolicyReference Constraint(IRouteConstraint constraint)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference" /> from the provided constraint.
		/// </summary>
		/// <param name="constraint">
		/// The constraint text, which will be resolved by <see cref="T:Microsoft.AspNetCore.Routing.ParameterPolicyFactory" />.
		/// </param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference" />.</returns>
		public static RoutePatternParameterPolicyReference Constraint(string constraint)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference" /> from the provided object.
		/// </summary>
		/// <param name="parameterPolicy">
		/// The parameter policy object.
		/// </param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference" />.</returns>
		public static RoutePatternParameterPolicyReference ParameterPolicy(IParameterPolicy parameterPolicy)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference" /> from the provided object.
		/// </summary>
		/// <param name="parameterPolicy">
		/// The parameter policy text, which will be resolved by <see cref="T:Microsoft.AspNetCore.Routing.ParameterPolicyFactory" />.
		/// </param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternParameterPolicyReference" />.</returns>
		public static RoutePatternParameterPolicyReference ParameterPolicy(string parameterPolicy)
		{
			throw null;
		}
	}
}
