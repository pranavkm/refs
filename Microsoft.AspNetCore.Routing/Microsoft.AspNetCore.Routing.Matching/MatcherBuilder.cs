namespace Microsoft.AspNetCore.Routing.Matching
{
	internal abstract class MatcherBuilder
	{
		public abstract void AddEndpoint(RouteEndpoint endpoint);

		public abstract Matcher Build();

		protected MatcherBuilder()
		{
			throw null;
		}
	}
}
