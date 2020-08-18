using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Routing
{
	internal class TemplateSegment
	{
		public string Value
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool IsParameter
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool IsOptional
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool IsCatchAll
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public RouteConstraint[] Constraints
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public TemplateSegment(string template, string segment, bool isParameter)
		{
			throw null;
		}

		public bool Match(string pathSegment, out object? matchedParameterValue)
		{
			throw null;
		}
	}
}
