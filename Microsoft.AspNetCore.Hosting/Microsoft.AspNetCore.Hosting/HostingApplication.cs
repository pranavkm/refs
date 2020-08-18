using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Hosting
{
	internal class HostingApplication : IHttpApplication<HostingApplication.Context>
	{
		internal class Context
		{
			public HttpContext HttpContext
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				set
				{
					throw null;
				}
			}

			public IDisposable Scope
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				set
				{
					throw null;
				}
			}

			public Activity Activity
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				set
				{
					throw null;
				}
			}

			internal HostingRequestStartingLog StartLog
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				set
				{
					throw null;
				}
			}

			public long StartTimestamp
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				set
				{
					throw null;
				}
			}

			internal bool HasDiagnosticListener
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				set
				{
					throw null;
				}
			}

			public bool EventLogEnabled
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				set
				{
					throw null;
				}
			}

			public void Reset()
			{
				throw null;
			}

			public Context()
			{
				throw null;
			}
		}

		public HostingApplication(RequestDelegate application, ILogger logger, DiagnosticListener diagnosticSource, IHttpContextFactory httpContextFactory)
		{
			throw null;
		}

		public Context CreateContext(IFeatureCollection contextFeatures)
		{
			throw null;
		}

		public Task ProcessRequestAsync(Context context)
		{
			throw null;
		}

		public void DisposeContext(Context context, Exception exception)
		{
			throw null;
		}
	}
}
