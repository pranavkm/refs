using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http.Features
{
	/// <summary>
	/// This type exists only for the purpose of unit testing where the user can directly set the
	/// <see cref="P:Microsoft.AspNetCore.Http.HttpContext.Session" /> property without the need for creating a <see cref="T:Microsoft.AspNetCore.Http.Features.ISessionFeature" />.
	/// </summary>
	public class DefaultSessionFeature : ISessionFeature
	{
		public ISession Session
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

		public DefaultSessionFeature()
		{
			throw null;
		}
	}
}
