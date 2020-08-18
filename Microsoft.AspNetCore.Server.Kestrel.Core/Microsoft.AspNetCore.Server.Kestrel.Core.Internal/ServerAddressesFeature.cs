using Microsoft.AspNetCore.Hosting.Server.Features;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	internal class ServerAddressesFeature : IServerAddressesFeature
	{
		public ServerAddressesCollection InternalCollection
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		ICollection<string> IServerAddressesFeature.Addresses
		{
			get
			{
				throw null;
			}
		}

		public bool PreferHostingUrls
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

		public ServerAddressesFeature()
		{
			throw null;
		}
	}
}
