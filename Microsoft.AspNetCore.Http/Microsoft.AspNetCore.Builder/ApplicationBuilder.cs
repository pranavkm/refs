using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Builder
{
	public class ApplicationBuilder : IApplicationBuilder
	{
		public IServiceProvider ApplicationServices
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public IFeatureCollection ServerFeatures
		{
			get
			{
				throw null;
			}
		}

		public IDictionary<string, object?> Properties
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ApplicationBuilder(IServiceProvider serviceProvider)
		{
			throw null;
		}

		public ApplicationBuilder(IServiceProvider serviceProvider, object server)
		{
			throw null;
		}

		public IApplicationBuilder Use(Func<RequestDelegate, RequestDelegate> middleware)
		{
			throw null;
		}

		public IApplicationBuilder New()
		{
			throw null;
		}

		public RequestDelegate Build()
		{
			throw null;
		}
	}
}
