namespace Microsoft.AspNetCore.DataProtection
{
	internal interface IRegistryPolicyResolver
	{
		RegistryPolicy ResolvePolicy();
	}
}
