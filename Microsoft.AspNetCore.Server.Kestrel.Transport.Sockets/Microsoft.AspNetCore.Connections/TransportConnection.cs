using Microsoft.AspNetCore.Connections.Features;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Microsoft.AspNetCore.Connections
{
	internal abstract class TransportConnection : ConnectionContext, IFeatureCollection, IEnumerable<KeyValuePair<Type, object>>, IEnumerable, IConnectionIdFeature, IConnectionTransportFeature, IConnectionItemsFeature, IMemoryPoolFeature, IConnectionLifetimeFeature
	{
		public override EndPoint LocalEndPoint
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

		public override EndPoint RemoteEndPoint
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

		public override string ConnectionId
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

		public override IFeatureCollection Features
		{
			get
			{
				throw null;
			}
		}

		public virtual MemoryPool<byte> MemoryPool
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public override IDuplexPipe Transport
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

		public IDuplexPipe Application
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

		public override IDictionary<object, object> Items
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

		bool IFeatureCollection.IsReadOnly
		{
			get
			{
				throw null;
			}
		}

		int IFeatureCollection.Revision
		{
			get
			{
				throw null;
			}
		}

		object IFeatureCollection.this[Type key]
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

		MemoryPool<byte> IMemoryPoolFeature.MemoryPool
		{
			get
			{
				throw null;
			}
		}

		IDuplexPipe IConnectionTransportFeature.Transport
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

		IDictionary<object, object> IConnectionItemsFeature.Items
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

		CancellationToken IConnectionLifetimeFeature.ConnectionClosed
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

		public TransportConnection()
		{
			throw null;
		}

		public override void Abort(ConnectionAbortedException abortReason)
		{
			throw null;
		}

		internal void ResetFeatureCollection()
		{
			throw null;
		}

		TFeature IFeatureCollection.Get<TFeature>()
		{
			throw null;
		}

		void IFeatureCollection.Set<TFeature>(TFeature feature)
		{
			throw null;
		}

		IEnumerator<KeyValuePair<Type, object>> IEnumerable<KeyValuePair<Type, object>>.GetEnumerator()
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		void IConnectionLifetimeFeature.Abort()
		{
			throw null;
		}
	}
}
