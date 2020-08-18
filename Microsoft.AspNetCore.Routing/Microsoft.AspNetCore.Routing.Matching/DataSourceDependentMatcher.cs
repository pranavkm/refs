using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing.Matching
{
	internal sealed class DataSourceDependentMatcher : Matcher
	{
		public sealed class Lifetime : IDisposable
		{
			public DataSourceDependentCache<Matcher>? Cache
			{
				get
				{
					throw null;
				}
				set
				{
					throw null;
				}
			}

			public void Dispose()
			{
				throw null;
			}

			public Lifetime()
			{
				throw null;
			}
		}

		internal Matcher CurrentMatcher
		{
			get
			{
				throw null;
			}
		}

		public DataSourceDependentMatcher(EndpointDataSource dataSource, Lifetime lifetime, Func<MatcherBuilder> matcherBuilderFactory)
		{
			throw null;
		}

		public override Task MatchAsync(HttpContext httpContext)
		{
			throw null;
		}
	}
}
