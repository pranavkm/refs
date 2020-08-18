using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.KeyManagement
{
	internal static class KeyEscrowServiceProviderExtensions
	{
		private sealed class AggregateKeyEscrowSink : IKeyEscrowSink
		{
			public AggregateKeyEscrowSink(List<IKeyEscrowSink> sinks)
			{
				throw null;
			}

			public void Store(Guid keyId, XElement element)
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets an aggregate <see cref="T:Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyEscrowSink" /> from the underlying <see cref="T:System.IServiceProvider" />.
		/// This method may return null if no sinks are registered.
		/// </summary>
		public static IKeyEscrowSink GetKeyEscrowSink(this IServiceProvider services)
		{
			throw null;
		}
	}
}
