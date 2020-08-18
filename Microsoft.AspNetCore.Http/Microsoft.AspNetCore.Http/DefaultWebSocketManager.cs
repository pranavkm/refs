using Microsoft.AspNetCore.Http.Features;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http
{
	internal sealed class DefaultWebSocketManager : WebSocketManager
	{
		private struct FeatureInterfaces
		{
			public IHttpRequestFeature? Request;

			public IHttpWebSocketFeature? WebSockets;
		}

		public override bool IsWebSocketRequest
		{
			get
			{
				throw null;
			}
		}

		public override IList<string> WebSocketRequestedProtocols
		{
			get
			{
				throw null;
			}
		}

		public DefaultWebSocketManager(IFeatureCollection features)
		{
			throw null;
		}

		public void Initialize(IFeatureCollection features)
		{
			throw null;
		}

		public void Initialize(IFeatureCollection features, int revision)
		{
			throw null;
		}

		public void Uninitialize()
		{
			throw null;
		}

		public override Task<WebSocket> AcceptWebSocketAsync(string? subProtocol)
		{
			throw null;
		}
	}
}
