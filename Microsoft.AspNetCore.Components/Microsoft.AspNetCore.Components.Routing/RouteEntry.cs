using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Routing
{
	[DebuggerDisplay("Handler = {Handler}, Template = {Template}")]
	internal class RouteEntry
	{
		public RouteTemplate Template
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public string[] UnusedRouteParameterNames
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Type Handler
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public RouteEntry(RouteTemplate template, Type handler, string[] unusedRouteParameterNames)
		{
			throw null;
		}

		internal void Match(RouteContext context)
		{
			throw null;
		}
	}
}
