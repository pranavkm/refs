using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Template;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	internal sealed class DefaultLinkGenerator : LinkGenerator, IDisposable
	{
		private static class Log
		{
			public static class EventIds
			{
				public static readonly EventId EndpointsFound;

				public static readonly EventId EndpointsNotFound;

				public static readonly EventId TemplateSucceeded;

				public static readonly EventId TemplateFailedRequiredValues;

				public static readonly EventId TemplateFailedConstraint;

				public static readonly EventId TemplateFailedExpansion;

				public static readonly EventId LinkGenerationSucceeded;

				public static readonly EventId LinkGenerationFailed;
			}

			public static void EndpointsFound(ILogger logger, object address, IEnumerable<Endpoint> endpoints)
			{
				throw null;
			}

			public static void EndpointsNotFound(ILogger logger, object address)
			{
				throw null;
			}

			public static void TemplateSucceeded(ILogger logger, RouteEndpoint endpoint, PathString path, QueryString query)
			{
				throw null;
			}

			public static void TemplateFailedRequiredValues(ILogger logger, RouteEndpoint endpoint, RouteValueDictionary ambientValues, RouteValueDictionary values)
			{
				throw null;
			}

			public static void TemplateFailedConstraint(ILogger logger, RouteEndpoint endpoint, string parameterName, IRouteConstraint constraint, RouteValueDictionary values)
			{
				throw null;
			}

			public static void TemplateFailedExpansion(ILogger logger, RouteEndpoint endpoint, RouteValueDictionary values)
			{
				throw null;
			}

			public static void LinkGenerationSucceeded(ILogger logger, IEnumerable<Endpoint> endpoints, string uri)
			{
				throw null;
			}

			public static void LinkGenerationFailed(ILogger logger, IEnumerable<Endpoint> endpoints)
			{
				throw null;
			}
		}

		public DefaultLinkGenerator(ParameterPolicyFactory parameterPolicyFactory, TemplateBinderFactory binderFactory, EndpointDataSource dataSource, IOptions<RouteOptions> routeOptions, ILogger<DefaultLinkGenerator> logger, IServiceProvider serviceProvider)
		{
			throw null;
		}

		public override string? GetPathByAddress<TAddress>(HttpContext httpContext, TAddress address, RouteValueDictionary values, RouteValueDictionary? ambientValues = null, PathString? pathBase = null, FragmentString fragment = default(FragmentString), LinkOptions? options = null)
		{
			throw null;
		}

		public override string? GetPathByAddress<TAddress>(TAddress address, RouteValueDictionary values, PathString pathBase = default(PathString), FragmentString fragment = default(FragmentString), LinkOptions? options = null)
		{
			throw null;
		}

		public override string? GetUriByAddress<TAddress>(HttpContext httpContext, TAddress address, RouteValueDictionary values, RouteValueDictionary? ambientValues = null, string? scheme = null, HostString? host = null, PathString? pathBase = null, FragmentString fragment = default(FragmentString), LinkOptions? options = null)
		{
			throw null;
		}

		public override string? GetUriByAddress<TAddress>(TAddress address, RouteValueDictionary values, string scheme, HostString host, PathString pathBase = default(PathString), FragmentString fragment = default(FragmentString), LinkOptions? options = null)
		{
			throw null;
		}

		public string? GetUriByEndpoints(List<RouteEndpoint> endpoints, RouteValueDictionary values, RouteValueDictionary? ambientValues, string scheme, HostString host, PathString pathBase, FragmentString fragment, LinkOptions? options)
		{
			throw null;
		}

		internal TemplateBinder GetTemplateBinder(RouteEndpoint endpoint)
		{
			throw null;
		}

		internal bool TryProcessTemplate(HttpContext? httpContext, RouteEndpoint endpoint, RouteValueDictionary values, RouteValueDictionary? ambientValues, LinkOptions? options, out (PathString path, QueryString query) result)
		{
			throw null;
		}

		public static RouteValueDictionary? GetAmbientValues(HttpContext? httpContext)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
