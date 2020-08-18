using MessagePack;
using Microsoft.AspNetCore.SignalR.Protocol;
using System;

namespace Microsoft.AspNetCore.Components.Server.BlazorPack
{
	internal sealed class BlazorPackHubProtocolWorker : MessagePackHubProtocolWorker
	{
		protected override object DeserializeObject(ref MessagePackReader reader, Type type, string field)
		{
			throw null;
		}

		protected override void Serialize(ref MessagePackWriter writer, Type type, object value)
		{
			throw null;
		}

		public BlazorPackHubProtocolWorker()
		{
			throw null;
		}
	}
}
