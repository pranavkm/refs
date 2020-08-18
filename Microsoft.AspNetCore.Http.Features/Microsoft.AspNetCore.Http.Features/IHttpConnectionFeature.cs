using System.Net;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http.Features
{
	/// <summary>
	/// Information regarding the TCP/IP connection carrying the request.
	/// </summary>
	public interface IHttpConnectionFeature
	{
		/// <summary>
		/// The unique identifier for the connection the request was received on. This is primarily for diagnostic purposes.
		/// </summary>
		string ConnectionId
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			get;
			[System.Runtime.CompilerServices.NullableContext(1)]
			set;
		}

		/// <summary>
		/// The IPAddress of the client making the request. Note this may be for a proxy rather than the end user.
		/// </summary>
		IPAddress? RemoteIpAddress
		{
			get;
			set;
		}

		/// <summary>
		/// The local IPAddress on which the request was received.
		/// </summary>
		IPAddress? LocalIpAddress
		{
			get;
			set;
		}

		/// <summary>
		/// The remote port of the client making the request.
		/// </summary>
		int RemotePort
		{
			get;
			set;
		}

		/// <summary>
		/// The local port on which the request was received.
		/// </summary>
		int LocalPort
		{
			get;
			set;
		}
	}
}
