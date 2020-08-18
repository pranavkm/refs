using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authorization.Infrastructure
{
	/// <summary>
	/// A helper class to provide a useful <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationRequirement" /> which
	/// contains a name.
	/// </summary>
	public class OperationAuthorizationRequirement : IAuthorizationRequirement
	{
		/// <summary>
		/// The name of this instance of <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationRequirement" />.
		/// </summary>
		public string Name
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

		public override string ToString()
		{
			throw null;
		}

		public OperationAuthorizationRequirement()
		{
			throw null;
		}
	}
}
