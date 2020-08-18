using System;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	internal class NonDefaultHubProtocolAttribute : Attribute
	{
		public NonDefaultHubProtocolAttribute()
		{
			throw null;
		}
	}
}
