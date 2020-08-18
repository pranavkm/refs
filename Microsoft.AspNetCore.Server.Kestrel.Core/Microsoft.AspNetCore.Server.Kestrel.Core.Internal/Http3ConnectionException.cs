using System;
using System.Runtime.Serialization;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	[Serializable]
	internal class Http3ConnectionException : Exception
	{
		public Http3ConnectionException()
		{
			throw null;
		}

		public Http3ConnectionException(string message)
		{
			throw null;
		}

		public Http3ConnectionException(string message, Exception innerException)
		{
			throw null;
		}

		protected Http3ConnectionException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}
	}
}
