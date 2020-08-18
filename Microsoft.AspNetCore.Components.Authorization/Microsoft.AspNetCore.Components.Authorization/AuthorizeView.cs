using Microsoft.AspNetCore.Authorization;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Authorization
{
	/// <summary>
	/// Displays differing content depending on the user's authorization status.
	/// </summary>
	public class AuthorizeView : AuthorizeViewCore
	{
		/// <summary>
		/// The policy name that determines whether the content can be displayed.
		/// </summary>
		[Parameter]
		public string Policy
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
		/// A comma delimited list of roles that are allowed to display the content.
		/// </summary>
		[Parameter]
		public string Roles
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
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.Authorization.AuthorizeView" />.
		/// </summary>
		public AuthorizeView()
		{
			throw null;
		}

		/// <summary>
		/// Gets the data used for authorization.
		/// </summary>
		protected override IAuthorizeData[] GetAuthorizeData()
		{
			throw null;
		}
	}
}
