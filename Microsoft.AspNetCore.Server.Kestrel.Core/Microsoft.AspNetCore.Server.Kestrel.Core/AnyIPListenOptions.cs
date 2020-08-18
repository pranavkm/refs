using Microsoft.AspNetCore.Server.Kestrel.Core.Internal;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core
{
	internal sealed class AnyIPListenOptions : ListenOptions
	{
		internal AnyIPListenOptions(int port)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CBindAsync_003Ed__1))]
		[DebuggerStepThrough]
		internal override Task BindAsync(AddressBindContext context)
		{
			throw null;
		}
	}
}
