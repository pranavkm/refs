using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Used to build <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationScheme" />s.
	/// </summary>
	public class AuthenticationSchemeBuilder
	{
		/// <summary>
		/// The name of the scheme being built.
		/// </summary>
		public string Name
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The display name for the scheme being built.
		/// </summary>
		public string? DisplayName
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationHandler" /> type responsible for this scheme.
		/// </summary>
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]
		public Type? HandlerType
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="name">The name of the scheme being built.</param>
		[System.Runtime.CompilerServices.NullableContext(1)]
		public AuthenticationSchemeBuilder(string name)
		{
			throw null;
		}

		/// <summary>
		/// Builds the <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationScheme" /> instance.
		/// </summary>
		/// <returns></returns>
		public AuthenticationScheme Build()
		{
			throw null;
		}
	}
}
