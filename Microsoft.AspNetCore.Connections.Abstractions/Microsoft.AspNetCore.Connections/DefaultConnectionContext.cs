using Microsoft.AspNetCore.Connections.Features;
using Microsoft.AspNetCore.Http.Features;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Connections
{
	public class DefaultConnectionContext : ConnectionContext, IConnectionIdFeature, IConnectionItemsFeature, IConnectionTransportFeature, IConnectionUserFeature, IConnectionLifetimeFeature, IConnectionEndPointFeature
	{
		public override string ConnectionId
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(1)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public override IFeatureCollection Features
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ClaimsPrincipal? User
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

		public override IDictionary<object, object?> Items
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

		public IDuplexPipe? Application
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

		public override IDuplexPipe Transport
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(1)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public override CancellationToken ConnectionClosed
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

		public override EndPoint? LocalEndPoint
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

		public override EndPoint? RemoteEndPoint
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

		public DefaultConnectionContext()
		{
			throw null;
		}

		/// <summary>
		/// Creates the DefaultConnectionContext without Pipes to avoid upfront allocations.
		/// The caller is expected to set the <see cref="P:Microsoft.AspNetCore.Connections.DefaultConnectionContext.Transport" /> and <see cref="P:Microsoft.AspNetCore.Connections.DefaultConnectionContext.Application" /> pipes manually.
		/// </summary>
		/// <param name="id"></param>
		[System.Runtime.CompilerServices.NullableContext(1)]
		public DefaultConnectionContext(string id)
		{
			throw null;
		}

		[System.Runtime.CompilerServices.NullableContext(1)]
		public DefaultConnectionContext(string id, IDuplexPipe transport, IDuplexPipe application)
		{
			throw null;
		}

		public override void Abort(ConnectionAbortedException abortReason)
		{
			throw null;
		}

		public override ValueTask DisposeAsync()
		{
			throw null;
		}
	}
}
