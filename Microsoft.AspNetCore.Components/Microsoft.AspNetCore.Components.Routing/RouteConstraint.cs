namespace Microsoft.AspNetCore.Components.Routing
{
	internal abstract class RouteConstraint
	{
		public abstract bool Match(string pathSegment, out object? convertedValue);

		public static RouteConstraint Parse(string template, string segment, string constraint)
		{
			throw null;
		}

		protected RouteConstraint()
		{
			throw null;
		}
	}
}
