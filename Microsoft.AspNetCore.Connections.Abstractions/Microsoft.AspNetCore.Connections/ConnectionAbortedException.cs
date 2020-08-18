using System;

namespace Microsoft.AspNetCore.Connections
{
	public class ConnectionAbortedException : OperationCanceledException
	{
		public ConnectionAbortedException()
		{
			throw null;
		}

		public ConnectionAbortedException(string message)
		{
			throw null;
		}

		public ConnectionAbortedException(string message, Exception inner)
		{
			throw null;
		}
	}
}
