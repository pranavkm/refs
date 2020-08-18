using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Connections
{
	public class MultiplexedConnectionBuilder : IMultiplexedConnectionBuilder
	{
		public IServiceProvider ApplicationServices
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public MultiplexedConnectionBuilder(IServiceProvider applicationServices)
		{
			throw null;
		}

		public IMultiplexedConnectionBuilder Use(Func<MultiplexedConnectionDelegate, MultiplexedConnectionDelegate> middleware)
		{
			throw null;
		}

		public MultiplexedConnectionDelegate Build()
		{
			throw null;
		}
	}
}
