using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing
{
	internal static class Resources
	{
		internal static ResourceManager ResourceManager
		{
			get
			{
				throw null;
			}
		}

		internal static CultureInfo Culture
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>Value must be greater than or equal to {0}.</summary>
		internal static string ArgumentMustBeGreaterThanOrEqualTo
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The value for argument '{0}' should be less than or equal to the value for the argument '{1}'.</summary>
		internal static string RangeConstraint_MinShouldBeLessThanOrEqualToMax
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The '{0}' property of '{1}' must not be null.</summary>
		internal static string PropertyOfTypeCannotBeNull
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The supplied route name '{0}' is ambiguous and matched more than one route.</summary>
		internal static string NamedRoutes_AmbiguousRoutesFound
		{
			get
			{
				throw null;
			}
		}

		/// <summary>A default handler must be set on the {0}.</summary>
		internal static string DefaultHandler_MustBeSet
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The constructor to use for activating the constraint type '{0}' is ambiguous. Multiple constructors were found with the following number of parameters: {1}.</summary>
		internal static string DefaultInlineConstraintResolver_AmbiguousCtors
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Could not find a constructor for constraint type '{0}' with the following number of parameters: {1}.</summary>
		internal static string DefaultInlineConstraintResolver_CouldNotFindCtor
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The constraint type '{0}' which is mapped to constraint key '{1}' must implement the '{2}' interface.</summary>
		internal static string DefaultInlineConstraintResolver_TypeNotConstraint
		{
			get
			{
				throw null;
			}
		}

		/// <summary>A path segment that contains more than one section, such as a literal section or a parameter, cannot contain a catch-all parameter.</summary>
		internal static string TemplateRoute_CannotHaveCatchAllInMultiSegment
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The route parameter '{0}' has both an inline default value and an explicit default value specified. A route parameter cannot contain an inline default value when a default value is specified explicitly. Consider removing one of them.</summary>
		internal static string TemplateRoute_CannotHaveDefaultValueSpecifiedInlineAndExplicitly
		{
			get
			{
				throw null;
			}
		}

		/// <summary>A path segment cannot contain two consecutive parameters. They must be separated by a '/' or by a literal string.</summary>
		internal static string TemplateRoute_CannotHaveConsecutiveParameters
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The route template separator character '/' cannot appear consecutively. It must be separated by either a parameter or a literal value.</summary>
		internal static string TemplateRoute_CannotHaveConsecutiveSeparators
		{
			get
			{
				throw null;
			}
		}

		/// <summary>A catch-all parameter cannot be marked optional.</summary>
		internal static string TemplateRoute_CatchAllCannotBeOptional
		{
			get
			{
				throw null;
			}
		}

		/// <summary>An optional parameter cannot have default value.</summary>
		internal static string TemplateRoute_OptionalCannotHaveDefaultValue
		{
			get
			{
				throw null;
			}
		}

		/// <summary>A catch-all parameter can only appear as the last segment of the route template.</summary>
		internal static string TemplateRoute_CatchAllMustBeLast
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The literal section '{0}' is invalid. Literal sections cannot contain the '?' character.</summary>
		internal static string TemplateRoute_InvalidLiteral
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The route parameter name '{0}' is invalid. Route parameter names must be non-empty and cannot contain these characters: '{{', '}}', '/'. The '?' character marks a parameter as optional, and can occur only at the end of the parameter. The '*' character mark ...</summary>
		internal static string TemplateRoute_InvalidParameterName
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The route template cannot start with a '~' character unless followed by a '/'.</summary>
		internal static string TemplateRoute_InvalidRouteTemplate
		{
			get
			{
				throw null;
			}
		}

		/// <summary>There is an incomplete parameter in the route template. Check that each '{' character has a matching '}' character.</summary>
		internal static string TemplateRoute_MismatchedParameter
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The route parameter name '{0}' appears more than one time in the route template.</summary>
		internal static string TemplateRoute_RepeatedParameter
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The constraint entry '{0}' - '{1}' on the route '{2}' must have a string value or be of a type which implements '{3}'.</summary>
		internal static string RouteConstraintBuilder_ValidationMustBeStringOrCustomConstraint
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The constraint entry '{0}' - '{1}' on the route '{2}' could not be resolved by the constraint resolver of type '{3}'.</summary>
		internal static string RouteConstraintBuilder_CouldNotResolveConstraint
		{
			get
			{
				throw null;
			}
		}

		/// <summary>In a route parameter, '{' and '}' must be escaped with '{{' and '}}'.</summary>
		internal static string TemplateRoute_UnescapedBrace
		{
			get
			{
				throw null;
			}
		}

		/// <summary>In the segment '{0}', the optional parameter '{1}' is preceded by an invalid segment '{2}'. Only a period (.) can precede an optional parameter.</summary>
		internal static string TemplateRoute_OptionalParameterCanbBePrecededByPeriod
		{
			get
			{
				throw null;
			}
		}

		/// <summary>An optional parameter must be at the end of the segment. In the segment '{0}', optional parameter '{1}' is followed by '{2}'.</summary>
		internal static string TemplateRoute_OptionalParameterHasTobeTheLast
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Two or more routes named '{0}' have different templates.</summary>
		internal static string AttributeRoute_DifferentLinkGenerationEntries_SameName
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Unable to find the required services. Please add all the required services by calling '{0}.{1}' inside the call to '{2}' in the application startup code.</summary>
		internal static string UnableToFindServices
		{
			get
			{
				throw null;
			}
		}

		/// <summary>An error occurred while creating the route with name '{0}' and template '{1}'.</summary>
		internal static string TemplateRoute_Exception
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The request matched multiple endpoints. Matches: {0}{0}{1}</summary>
		internal static string AmbiguousEndpoints
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Value cannot be null or empty.</summary>
		internal static string Argument_NullOrEmpty
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The collection cannot be empty.</summary>
		internal static string RoutePatternBuilder_CollectionCannotBeEmpty
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The constraint entry '{0}' - '{1}' must have a string value or be of a type which implements '{2}'.</summary>
		internal static string ConstraintMustBeStringOrConstraint
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Invalid constraint '{0}'. A constraint must be of type 'string' or '{1}'.</summary>
		internal static string RoutePattern_InvalidConstraintReference
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Invalid constraint '{0}' for parameter '{1}'. A constraint must be of type 'string', '{2}', or '{3}'.</summary>
		internal static string RoutePattern_InvalidParameterConstraintReference
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The constraint reference '{0}' could not be resolved to a type. Register the constraint type with '{1}.{2}'.</summary>
		internal static string RoutePattern_ConstraintReferenceNotFound
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Invalid constraint type '{0}' registered as '{1}'. A constraint  type must either implement '{2}', or inherit from '{3}'.</summary>
		internal static string RoutePattern_InvalidStringConstraintReference
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Endpoints with endpoint name '{0}':</summary>
		internal static string DuplicateEndpointNameEntry
		{
			get
			{
				throw null;
			}
		}

		/// <summary>The following endpoints with a duplicate endpoint name were found.</summary>
		internal static string DuplicateEndpointNameHeader
		{
			get
			{
				throw null;
			}
		}

		/// <summary>No media type found for format '{0}'.</summary>
		internal static string FormatterMapping_MediaTypeInvalid
		{
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static string GetResourceString(string resourceKey, string defaultValue = null)
		{
			throw null;
		}

		/// <summary>Value must be greater than or equal to {0}.</summary>
		internal static string FormatArgumentMustBeGreaterThanOrEqualTo(object p0)
		{
			throw null;
		}

		/// <summary>The value for argument '{0}' should be less than or equal to the value for the argument '{1}'.</summary>
		internal static string FormatRangeConstraint_MinShouldBeLessThanOrEqualToMax(object p0, object p1)
		{
			throw null;
		}

		/// <summary>The '{0}' property of '{1}' must not be null.</summary>
		internal static string FormatPropertyOfTypeCannotBeNull(object p0, object p1)
		{
			throw null;
		}

		/// <summary>The supplied route name '{0}' is ambiguous and matched more than one route.</summary>
		internal static string FormatNamedRoutes_AmbiguousRoutesFound(object p0)
		{
			throw null;
		}

		/// <summary>A default handler must be set on the {0}.</summary>
		internal static string FormatDefaultHandler_MustBeSet(object p0)
		{
			throw null;
		}

		/// <summary>The constructor to use for activating the constraint type '{0}' is ambiguous. Multiple constructors were found with the following number of parameters: {1}.</summary>
		internal static string FormatDefaultInlineConstraintResolver_AmbiguousCtors(object p0, object p1)
		{
			throw null;
		}

		/// <summary>Could not find a constructor for constraint type '{0}' with the following number of parameters: {1}.</summary>
		internal static string FormatDefaultInlineConstraintResolver_CouldNotFindCtor(object p0, object p1)
		{
			throw null;
		}

		/// <summary>The constraint type '{0}' which is mapped to constraint key '{1}' must implement the '{2}' interface.</summary>
		internal static string FormatDefaultInlineConstraintResolver_TypeNotConstraint(object p0, object p1, object p2)
		{
			throw null;
		}

		/// <summary>The route parameter '{0}' has both an inline default value and an explicit default value specified. A route parameter cannot contain an inline default value when a default value is specified explicitly. Consider removing one of them.</summary>
		internal static string FormatTemplateRoute_CannotHaveDefaultValueSpecifiedInlineAndExplicitly(object p0)
		{
			throw null;
		}

		/// <summary>The literal section '{0}' is invalid. Literal sections cannot contain the '?' character.</summary>
		internal static string FormatTemplateRoute_InvalidLiteral(object p0)
		{
			throw null;
		}

		/// <summary>The route parameter name '{0}' is invalid. Route parameter names must be non-empty and cannot contain these characters: '{{', '}}', '/'. The '?' character marks a parameter as optional, and can occur only at the end of the parameter. The '*' character mark ...</summary>
		internal static string FormatTemplateRoute_InvalidParameterName(object p0)
		{
			throw null;
		}

		/// <summary>The route parameter name '{0}' appears more than one time in the route template.</summary>
		internal static string FormatTemplateRoute_RepeatedParameter(object p0)
		{
			throw null;
		}

		/// <summary>The constraint entry '{0}' - '{1}' on the route '{2}' must have a string value or be of a type which implements '{3}'.</summary>
		internal static string FormatRouteConstraintBuilder_ValidationMustBeStringOrCustomConstraint(object p0, object p1, object p2, object p3)
		{
			throw null;
		}

		/// <summary>The constraint entry '{0}' - '{1}' on the route '{2}' could not be resolved by the constraint resolver of type '{3}'.</summary>
		internal static string FormatRouteConstraintBuilder_CouldNotResolveConstraint(object p0, object p1, object p2, object p3)
		{
			throw null;
		}

		/// <summary>In the segment '{0}', the optional parameter '{1}' is preceded by an invalid segment '{2}'. Only a period (.) can precede an optional parameter.</summary>
		internal static string FormatTemplateRoute_OptionalParameterCanbBePrecededByPeriod(object p0, object p1, object p2)
		{
			throw null;
		}

		/// <summary>An optional parameter must be at the end of the segment. In the segment '{0}', optional parameter '{1}' is followed by '{2}'.</summary>
		internal static string FormatTemplateRoute_OptionalParameterHasTobeTheLast(object p0, object p1, object p2)
		{
			throw null;
		}

		/// <summary>Two or more routes named '{0}' have different templates.</summary>
		internal static string FormatAttributeRoute_DifferentLinkGenerationEntries_SameName(object p0)
		{
			throw null;
		}

		/// <summary>Unable to find the required services. Please add all the required services by calling '{0}.{1}' inside the call to '{2}' in the application startup code.</summary>
		internal static string FormatUnableToFindServices(object p0, object p1, object p2)
		{
			throw null;
		}

		/// <summary>An error occurred while creating the route with name '{0}' and template '{1}'.</summary>
		internal static string FormatTemplateRoute_Exception(object p0, object p1)
		{
			throw null;
		}

		/// <summary>The request matched multiple endpoints. Matches: {0}{0}{1}</summary>
		internal static string FormatAmbiguousEndpoints(object p0, object p1)
		{
			throw null;
		}

		/// <summary>The constraint entry '{0}' - '{1}' must have a string value or be of a type which implements '{2}'.</summary>
		internal static string FormatConstraintMustBeStringOrConstraint(object p0, object p1, object p2)
		{
			throw null;
		}

		/// <summary>Invalid constraint '{0}'. A constraint must be of type 'string' or '{1}'.</summary>
		internal static string FormatRoutePattern_InvalidConstraintReference(object p0, object p1)
		{
			throw null;
		}

		/// <summary>Invalid constraint '{0}' for parameter '{1}'. A constraint must be of type 'string', '{2}', or '{3}'.</summary>
		internal static string FormatRoutePattern_InvalidParameterConstraintReference(object p0, object p1, object p2, object p3)
		{
			throw null;
		}

		/// <summary>The constraint reference '{0}' could not be resolved to a type. Register the constraint type with '{1}.{2}'.</summary>
		internal static string FormatRoutePattern_ConstraintReferenceNotFound(object p0, object p1, object p2)
		{
			throw null;
		}

		/// <summary>Invalid constraint type '{0}' registered as '{1}'. A constraint  type must either implement '{2}', or inherit from '{3}'.</summary>
		internal static string FormatRoutePattern_InvalidStringConstraintReference(object p0, object p1, object p2, object p3)
		{
			throw null;
		}

		/// <summary>Endpoints with endpoint name '{0}':</summary>
		internal static string FormatDuplicateEndpointNameEntry(object p0)
		{
			throw null;
		}

		/// <summary>No media type found for format '{0}'.</summary>
		internal static string FormatFormatterMapping_MediaTypeInvalid(object p0)
		{
			throw null;
		}
	}
}
