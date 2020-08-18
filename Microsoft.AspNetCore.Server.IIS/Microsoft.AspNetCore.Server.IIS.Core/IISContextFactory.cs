namespace Microsoft.AspNetCore.Server.IIS.Core
{
	internal interface IISContextFactory
	{
		IISHttpContext CreateHttpContext(NativeSafeHandle pInProcessHandler);
	}
}
