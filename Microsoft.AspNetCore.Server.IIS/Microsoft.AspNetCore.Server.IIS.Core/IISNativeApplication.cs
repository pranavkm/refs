using System;

namespace Microsoft.AspNetCore.Server.IIS.Core
{
	internal class IISNativeApplication
	{
		public IISNativeApplication(NativeSafeHandle nativeApplication)
		{
			throw null;
		}

		public void StopIncomingRequests()
		{
			throw null;
		}

		public void StopCallsIntoManaged()
		{
			throw null;
		}

		public void RegisterCallbacks(NativeMethods.PFN_REQUEST_HANDLER requestHandler, NativeMethods.PFN_SHUTDOWN_HANDLER shutdownHandler, NativeMethods.PFN_DISCONNECT_HANDLER disconnectHandler, NativeMethods.PFN_ASYNC_COMPLETION onAsyncCompletion, NativeMethods.PFN_REQUESTS_DRAINED_HANDLER requestDrainedHandler, IntPtr requestContext, IntPtr shutdownContext)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}

		~IISNativeApplication()
		{
			throw null;
		}
	}
}
