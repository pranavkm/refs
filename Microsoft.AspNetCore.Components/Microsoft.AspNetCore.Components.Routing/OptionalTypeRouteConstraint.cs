namespace Microsoft.AspNetCore.Components.Routing
{
	/// <summary>
	/// A route constraint that allows the value to be null or parseable as the specified
	/// type.
	/// </summary>
	/// <typeparam name="T">The type to which the value must be parseable.</typeparam>
	internal class OptionalTypeRouteConstraint<T> : RouteConstraint
	{
		public delegate bool TryParseDelegate(string str, out T result);

		public OptionalTypeRouteConstraint(TryParseDelegate parser)
		{
			throw null;
		}

		public override bool Match(string pathSegment, out object? convertedValue)
		{
			throw null;
		}
	}
}
