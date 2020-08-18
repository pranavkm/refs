namespace Microsoft.AspNetCore.Routing.Matching
{
	internal abstract class MatcherFactory
	{
		public abstract Matcher CreateMatcher(EndpointDataSource dataSource);

		protected MatcherFactory()
		{
			throw null;
		}
	}
}
