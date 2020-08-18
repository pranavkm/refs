using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Connections
{
	public class ConnectionBuilder : IConnectionBuilder
	{
		public IServiceProvider ApplicationServices
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ConnectionBuilder(IServiceProvider applicationServices)
		{
			throw null;
		}

		public IConnectionBuilder Use(Func<ConnectionDelegate, ConnectionDelegate> middleware)
		{
			throw null;
		}

		public ConnectionDelegate Build()
		{
			throw null;
		}
	}
}
