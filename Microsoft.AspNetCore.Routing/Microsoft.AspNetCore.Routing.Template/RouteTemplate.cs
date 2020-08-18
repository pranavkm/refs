using Microsoft.AspNetCore.Routing.Patterns;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Template
{
	[DebuggerDisplay("{DebuggerToString()}")]
	public class RouteTemplate
	{
		public string? TemplateText
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IList<TemplatePart> Parameters
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IList<TemplateSegment> Segments
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public RouteTemplate(RoutePattern other)
		{
			throw null;
		}

		public RouteTemplate(string template, List<TemplateSegment> segments)
		{
			throw null;
		}

		public TemplateSegment? GetSegment(int index)
		{
			throw null;
		}

		/// <summary>
		/// Gets the parameter matching the given name.
		/// </summary>
		/// <param name="name">The name of the parameter to match.</param>
		/// <returns>The matching parameter or <c>null</c> if no parameter matches the given name.</returns>
		public TemplatePart? GetParameter(string name)
		{
			throw null;
		}

		/// <summary>
		/// Converts the <see cref="T:Microsoft.AspNetCore.Routing.Template.RouteTemplate" /> to the equivalent 
		/// <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" />
		/// </summary>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" />.</returns>
		public RoutePattern ToRoutePattern()
		{
			throw null;
		}
	}
}
