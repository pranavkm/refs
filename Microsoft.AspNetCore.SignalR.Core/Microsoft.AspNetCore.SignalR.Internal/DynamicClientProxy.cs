using System.Dynamic;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class DynamicClientProxy : DynamicObject
	{
		public DynamicClientProxy(IClientProxy clientProxy)
		{
			throw null;
		}

		public override bool TryInvokeMember(InvokeMemberBinder binder, object?[]? args, out object? result)
		{
			throw null;
		}
	}
}
