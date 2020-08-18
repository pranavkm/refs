using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.Routing
{
	internal class DefaultLinkParser : LinkParser, IDisposable
	{
		internal readonly struct MatcherState
		{
			public readonly RoutePatternMatcher Matcher;

			public readonly Dictionary<string, List<IRouteConstraint>> Constraints;

			public MatcherState(RoutePatternMatcher matcher, Dictionary<string, List<IRouteConstraint>> constraints)
			{
				throw null;
			}

			public void Deconstruct(out RoutePatternMatcher matcher, out Dictionary<string, List<IRouteConstraint>> constraints)
			{
				throw null;
			}
		}

		private static class Log
		{
			public static class EventIds
			{
				public static readonly EventId EndpointsFound;

				public static readonly EventId EndpointsNotFound;

				public static readonly EventId PathParsingSucceeded;

				public static readonly EventId PathParsingFailed;
			}

			public static void EndpointsFound(ILogger logger, object address, IEnumerable<Endpoint> endpoints)
			{
				throw null;
			}

			public static void EndpointsNotFound(ILogger logger, object address)
			{
				throw null;
			}

			public static void PathParsingSucceeded(ILogger logger, PathString path, Endpoint endpoint)
			{
				throw null;
			}

			public static void PathParsingFailed(ILogger logger, PathString path, IEnumerable<Endpoint> endpoints)
			{
				throw null;
			}
		}

		public DefaultLinkParser(ParameterPolicyFactory parameterPolicyFactory, EndpointDataSource dataSource, ILogger<DefaultLinkParser> logger, IServiceProvider serviceProvider)
		{
			throw null;
		}

		public override RouteValueDictionary? ParsePathByAddress<TAddress>(TAddress address, PathString path)
		{
			throw null;
		}

		internal MatcherState GetMatcherState(RouteEndpoint endpoint)
		{
			throw null;
		}

		internal bool TryParse(RouteEndpoint endpoint, PathString path, [NotNullWhen(true)] out RouteValueDictionary? values)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
