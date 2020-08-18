using Microsoft.AspNetCore.Server.Kestrel.Core.Internal;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core
{
	internal sealed class LocalhostListenOptions : ListenOptions
	{
		internal LocalhostListenOptions(int port)
		{
			throw null;
		}

		/// <summary>
		/// Gets the name of this endpoint to display on command-line when the web server starts.
		/// </summary>
		internal override string GetDisplayName()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CBindAsync_003Ed__2))]
		[DebuggerStepThrough]
		internal override Task BindAsync(AddressBindContext context)
		{
			throw null;
		}

		internal ListenOptions Clone(IPAddress address)
		{
			throw null;
		}
	}
}
