using System;
using System.IO;

namespace Microsoft.AspNetCore.Connections
{
	public class ConnectionResetException : IOException
	{
		public ConnectionResetException(string message)
		{
			throw null;
		}

		public ConnectionResetException(string message, Exception inner)
		{
			throw null;
		}
	}
}
