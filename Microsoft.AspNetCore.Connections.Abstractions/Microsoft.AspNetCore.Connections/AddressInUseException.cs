using System;

namespace Microsoft.AspNetCore.Connections
{
	public class AddressInUseException : InvalidOperationException
	{
		public AddressInUseException(string message)
		{
			throw null;
		}

		public AddressInUseException(string message, Exception inner)
		{
			throw null;
		}
	}
}
