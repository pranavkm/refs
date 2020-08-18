using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authorization
{
	/// <summary>
	/// Specifies that the class or method that this attribute is applied to requires the specified authorization.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
	public class AuthorizeAttribute : Attribute, IAuthorizeData
	{
		/// <summary>
		/// Gets or sets the policy name that determines access to the resource.
		/// </summary>
		public string? Policy
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
		/// Gets or sets a comma delimited list of roles that are allowed to access the resource.
		/// </summary>
		public string? Roles
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
		/// Gets or sets a comma delimited list of schemes from which user information is constructed.
		/// </summary>
		public string? AuthenticationSchemes
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
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizeAttribute" /> class. 
		/// </summary>
		public AuthorizeAttribute()
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizeAttribute" /> class with the specified policy. 
		/// </summary>
		/// <param name="policy">The name of the policy to require for authorization.</param>
		[System.Runtime.CompilerServices.NullableContext(1)]
		public AuthorizeAttribute(string policy)
		{
			throw null;
		}
	}
}
