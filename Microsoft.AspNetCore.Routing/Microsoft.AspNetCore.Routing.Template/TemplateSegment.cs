using Microsoft.AspNetCore.Routing.Patterns;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Template
{
	[DebuggerDisplay("{DebuggerToString()}")]
	public class TemplateSegment
	{
		public bool IsSimple
		{
			get
			{
				throw null;
			}
		}

		public List<TemplatePart> Parts
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public TemplateSegment()
		{
			throw null;
		}

		public TemplateSegment(RoutePatternPathSegment other)
		{
			throw null;
		}

		internal string DebuggerToString()
		{
			throw null;
		}

		public RoutePatternPathSegment ToRoutePatternPathSegment()
		{
			throw null;
		}
	}
}
