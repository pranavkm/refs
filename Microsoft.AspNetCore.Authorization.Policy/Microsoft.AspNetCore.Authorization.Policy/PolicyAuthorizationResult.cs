using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authorization.Policy
{
	public class PolicyAuthorizationResult
	{
		/// <summary>
		/// If true, means the callee should challenge and try again.
		/// </summary>
		public bool Challenged
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Authorization was forbidden.
		/// </summary>
		public bool Forbidden
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Authorization was successful.
		/// </summary>
		public bool Succeeded
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Contains information about why authorization failed.
		/// </summary>
		public AuthorizationFailure? AuthorizationFailure
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public static PolicyAuthorizationResult Challenge()
		{
			throw null;
		}

		public static PolicyAuthorizationResult Forbid()
		{
			throw null;
		}

		public static PolicyAuthorizationResult Forbid(AuthorizationFailure? authorizationFailure)
		{
			throw null;
		}

		public static PolicyAuthorizationResult Success()
		{
			throw null;
		}
	}
}
