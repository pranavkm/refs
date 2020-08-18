using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	internal class AddressBinder
	{
		private interface IStrategy
		{
			Task BindAsync(AddressBindContext context);
		}

		private class DefaultAddressStrategy : IStrategy
		{
			[AsyncStateMachine(typeof(_003CBindAsync_003Ed__0))]
			[DebuggerStepThrough]
			public Task BindAsync(AddressBindContext context)
			{
				throw null;
			}

			public DefaultAddressStrategy()
			{
				throw null;
			}
		}

		private class OverrideWithAddressesStrategy : AddressesStrategy
		{
			public OverrideWithAddressesStrategy(IReadOnlyCollection<string> addresses)
			{
				throw null;
			}

			public override Task BindAsync(AddressBindContext context)
			{
				throw null;
			}
		}

		private class OverrideWithEndpointsStrategy : EndpointsStrategy
		{
			public OverrideWithEndpointsStrategy(IReadOnlyCollection<ListenOptions> endpoints, string[] originalAddresses)
			{
				throw null;
			}

			public override Task BindAsync(AddressBindContext context)
			{
				throw null;
			}
		}

		private class EndpointsStrategy : IStrategy
		{
			public EndpointsStrategy(IReadOnlyCollection<ListenOptions> endpoints)
			{
				throw null;
			}

			[AsyncStateMachine(typeof(_003CBindAsync_003Ed__2))]
			[DebuggerStepThrough]
			public virtual Task BindAsync(AddressBindContext context)
			{
				throw null;
			}
		}

		private class AddressesStrategy : IStrategy
		{
			protected readonly IReadOnlyCollection<string> _addresses;

			public AddressesStrategy(IReadOnlyCollection<string> addresses)
			{
				throw null;
			}

			[AsyncStateMachine(typeof(_003CBindAsync_003Ed__2))]
			[DebuggerStepThrough]
			public virtual Task BindAsync(AddressBindContext context)
			{
				throw null;
			}
		}

		[AsyncStateMachine(typeof(_003CBindAsync_003Ed__0))]
		[DebuggerStepThrough]
		public static Task BindAsync(IEnumerable<ListenOptions> listenOptions, AddressBindContext context)
		{
			throw null;
		}

		/// <summary>
		/// Returns an <see cref="T:System.Net.IPEndPoint" /> for the given host an port.
		/// If the host parameter isn't "localhost" or an IP address, use IPAddress.Any.
		/// </summary>
		protected internal static bool TryCreateIPEndPoint(BindingAddress address, out IPEndPoint endpoint)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CBindEndpointAsync_003Ed__3))]
		[DebuggerStepThrough]
		internal static Task BindEndpointAsync(ListenOptions endpoint, AddressBindContext context)
		{
			throw null;
		}

		internal static ListenOptions ParseAddress(string address, out bool https)
		{
			throw null;
		}

		public AddressBinder()
		{
			throw null;
		}
	}
}
