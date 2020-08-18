using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal sealed class DebuggerWrapper : IDebugger
	{
		public static IDebugger Singleton
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool IsAttached
		{
			get
			{
				throw null;
			}
		}
	}
}
