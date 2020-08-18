using System.Net;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.HttpOverrides
{
	public class IPNetwork
	{
		public IPAddress Prefix
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The CIDR notation of the subnet mask 
		/// </summary>
		public int PrefixLength
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IPNetwork(IPAddress prefix, int prefixLength)
		{
			throw null;
		}

		public bool Contains(IPAddress address)
		{
			throw null;
		}
	}
}
