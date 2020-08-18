using System;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http3
{
	internal class Http3StreamErrorException : Exception
	{
		public System.Net.Http.Http3ErrorCode ErrorCode
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Http3StreamErrorException(string message, System.Net.Http.Http3ErrorCode errorCode)
		{
			throw null;
		}
	}
}
