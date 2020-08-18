using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.Authentication
{
	public interface ISecureDataFormat<TData>
	{
		string Protect(TData data);

		string Protect(TData data, string? purpose);

		[return: MaybeNull]
		TData Unprotect(string protectedText);

		[return: MaybeNull]
		TData Unprotect(string protectedText, string? purpose);
	}
}
