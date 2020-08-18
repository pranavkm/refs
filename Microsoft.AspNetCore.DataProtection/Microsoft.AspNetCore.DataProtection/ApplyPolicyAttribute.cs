using System;

namespace Microsoft.AspNetCore.DataProtection
{
	/// <summary>
	/// Signifies that the <see cref="T:Microsoft.AspNetCore.DataProtection.RegistryPolicyResolver" /> should bind this property from the registry.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
	internal sealed class ApplyPolicyAttribute : Attribute
	{
		public ApplyPolicyAttribute()
		{
			throw null;
		}
	}
}
