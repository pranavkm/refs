using Microsoft.AspNetCore.DataProtection;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.Authentication
{
	public class SecureDataFormat<TData> : ISecureDataFormat<TData>
	{
		public SecureDataFormat(IDataSerializer<TData> serializer, IDataProtector protector)
		{
			throw null;
		}

		public string Protect(TData data)
		{
			throw null;
		}

		public string Protect(TData data, string? purpose)
		{
			throw null;
		}

		[return: MaybeNull]
		public TData Unprotect(string protectedText)
		{
			throw null;
		}

		[return: MaybeNull]
		public TData Unprotect(string protectedText, string? purpose)
		{
			throw null;
		}
	}
}
