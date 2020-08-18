namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal interface IDebugger
	{
		bool IsAttached
		{
			get;
		}
	}
}
