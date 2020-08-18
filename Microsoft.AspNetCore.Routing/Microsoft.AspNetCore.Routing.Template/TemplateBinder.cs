using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Patterns;
using Microsoft.Extensions.ObjectPool;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Encodings.Web;

namespace Microsoft.AspNetCore.Routing.Template
{
	public class TemplateBinder
	{
		[DebuggerDisplay("explicit null")]
		private class SentinullValue
		{
			public static object Instance;

			public override string ToString()
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Routing.Template.TemplateBinder" />.
		/// </summary>
		/// <param name="urlEncoder">The <see cref="T:System.Text.Encodings.Web.UrlEncoder" />.</param>
		/// <param name="pool">The <see cref="T:Microsoft.Extensions.ObjectPool.ObjectPool`1" />.</param>
		/// <param name="template">The <see cref="T:Microsoft.AspNetCore.Routing.Template.RouteTemplate" /> to bind values to.</param>
		/// <param name="defaults">The default values for <paramref name="template" />.</param>
		internal TemplateBinder(UrlEncoder urlEncoder, ObjectPool<UriBuildingContext> pool, RouteTemplate template, RouteValueDictionary defaults)
		{
			throw null;
		}

		internal TemplateBinder(UrlEncoder urlEncoder, ObjectPool<UriBuildingContext> pool, RoutePattern pattern, RouteValueDictionary? defaults, IEnumerable<string>? requiredKeys, IEnumerable<(string parameterName, IParameterPolicy policy)>? parameterPolicies)
		{
			throw null;
		}

		internal TemplateBinder(UrlEncoder urlEncoder, ObjectPool<UriBuildingContext> pool, RoutePattern pattern, IEnumerable<(string parameterName, IParameterPolicy policy)> parameterPolicies)
		{
			throw null;
		}

		public TemplateValuesResult? GetValues(RouteValueDictionary? ambientValues, RouteValueDictionary values)
		{
			throw null;
		}

		public bool TryProcessConstraints(HttpContext? httpContext, RouteValueDictionary combinedValues, out string? parameterName, out IRouteConstraint? constraint)
		{
			throw null;
		}

		public string? BindValues(RouteValueDictionary acceptedValues)
		{
			throw null;
		}

		internal bool TryBindValues(RouteValueDictionary acceptedValues, LinkOptions? options, LinkOptions globalOptions, out (PathString path, QueryString query) result)
		{
			throw null;
		}

		/// <summary>
		/// Compares two objects for equality as parts of a case-insensitive path.
		/// </summary>
		/// <param name="a">An object to compare.</param>
		/// <param name="b">An object to compare.</param>
		/// <returns>True if the object are equal, otherwise false.</returns>
		public static bool RoutePartsEqual(object? a, object? b)
		{
			throw null;
		}
	}
}
