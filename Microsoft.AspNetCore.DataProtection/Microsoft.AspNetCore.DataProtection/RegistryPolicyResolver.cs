using Microsoft.AspNetCore.DataProtection.Internal;
using Microsoft.Win32;

namespace Microsoft.AspNetCore.DataProtection
{
	/// <summary>
	/// A type which allows reading policy from the system registry.
	/// </summary>
	internal sealed class RegistryPolicyResolver : IRegistryPolicyResolver
	{
		public RegistryPolicyResolver(IActivator activator)
		{
			throw null;
		}

		internal RegistryPolicyResolver(RegistryKey policyRegKey, IActivator activator)
		{
			throw null;
		}

		public RegistryPolicy ResolvePolicy()
		{
			throw null;
		}
	}
}
