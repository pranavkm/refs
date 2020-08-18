using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Routing
{
	[DebuggerDisplay("{TemplateText}")]
	internal class RouteTemplate
	{
		public string TemplateText
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public TemplateSegment[] Segments
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public int OptionalSegmentsCount
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool ContainsCatchAllSegment
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public RouteTemplate(string templateText, TemplateSegment[] segments)
		{
			throw null;
		}
	}
}
