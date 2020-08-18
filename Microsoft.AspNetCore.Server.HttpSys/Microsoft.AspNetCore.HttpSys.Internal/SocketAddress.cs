using System.Net;
using System.Net.Sockets;
using System.Reflection;

namespace Microsoft.AspNetCore.HttpSys.Internal
{
	/// <devdoc>
	///    <para>
	///       This class is used when subclassing EndPoint, and provides indication
	///       on how to format the memory buffers that winsock uses for network addresses.
	///    </para>
	/// </devdoc>
	[DefaultMember("Item")]
	internal class SocketAddress
	{
		internal const int IPv6AddressSize = 28;

		internal const int IPv4AddressSize = 16;

		internal byte[] Buffer
		{
			get
			{
				throw null;
			}
		}

		internal AddressFamily Family
		{
			get
			{
				throw null;
			}
		}

		internal int Size
		{
			get
			{
				throw null;
			}
		}

		/// <devdoc>
		///    <para>[To be supplied.]</para>
		/// </devdoc>
		public SocketAddress(AddressFamily family, int size)
		{
			throw null;
		}

		internal int GetPort()
		{
			throw null;
		}

		public override bool Equals(object comparand)
		{
			throw null;
		}

		public override int GetHashCode()
		{
			throw null;
		}

		internal IPAddress GetIPAddress()
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}

		internal string GetIPAddressString()
		{
			throw null;
		}
	}
}
