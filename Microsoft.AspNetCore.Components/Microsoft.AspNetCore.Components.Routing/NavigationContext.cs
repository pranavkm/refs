using System.Runtime.CompilerServices;
using System.Threading;

namespace Microsoft.AspNetCore.Components.Routing
{
	/// <summary>
	/// Provides information about the current asynchronous navigation event
	/// including the target path and the cancellation token.
	/// </summary>
	public sealed class NavigationContext
	{
		public string Path
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public CancellationToken CancellationToken
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal NavigationContext(string path, CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
