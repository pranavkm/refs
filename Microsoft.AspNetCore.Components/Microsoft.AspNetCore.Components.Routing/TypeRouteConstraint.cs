using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.Components.Routing
{
	/// <summary>
	/// A route constraint that requires the value to be parseable as a specified type.
	/// </summary>
	/// <typeparam name="T">The type to which the value must be parseable.</typeparam>
	internal class TypeRouteConstraint<T> : RouteConstraint
	{
		public delegate bool TryParseDelegate(string str, [MaybeNullWhen(false)] out T result);

		public TypeRouteConstraint(TryParseDelegate parser)
		{
			throw null;
		}

		public override bool Match(string pathSegment, out object? convertedValue)
		{
			throw null;
		}
	}
}
