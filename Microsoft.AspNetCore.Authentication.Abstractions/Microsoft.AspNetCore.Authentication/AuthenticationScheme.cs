using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// AuthenticationSchemes assign a name to a specific <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationHandler" />
	/// handlerType.
	/// </summary>
	public class AuthenticationScheme
	{
		/// <summary>
		/// The name of the authentication scheme.
		/// </summary>
		public string Name
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The display name for the scheme. Null is valid and used for non user facing schemes.
		/// </summary>
		public string? DisplayName
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationHandler" /> type that handles this scheme.
		/// </summary>
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]
		public Type HandlerType
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="name">The name for the authentication scheme.</param>
		/// <param name="displayName">The display name for the authentication scheme.</param>
		/// <param name="handlerType">The <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationHandler" /> type that handles this scheme.</param>
		public AuthenticationScheme(string name, string? displayName, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type handlerType)
		{
			throw null;
		}
	}
}
