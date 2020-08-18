using System;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	[Flags]
	public enum AuthenticationSchemes
	{
		None = 0x0,
		Basic = 0x1,
		NTLM = 0x4,
		Negotiate = 0x8,
		Kerberos = 0x10
	}
}
