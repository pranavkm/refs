using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Identity
{
	/// <summary>
	/// Contains options for the <see cref="T:Microsoft.AspNetCore.Identity.DataProtectorTokenProvider`1" />.
	/// </summary>
	public class DataProtectionTokenProviderOptions
	{
		/// <summary>
		/// Gets or sets the name of the <see cref="T:Microsoft.AspNetCore.Identity.DataProtectorTokenProvider`1" />. Defaults to DataProtectorTokenProvider.
		/// </summary>
		/// <value>
		/// The name of the <see cref="T:Microsoft.AspNetCore.Identity.DataProtectorTokenProvider`1" />.
		/// </value>
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

		/// <summary>
		/// Gets or sets the amount of time a generated token remains valid. Defaults to 1 day.
		/// </summary>
		/// <value>
		/// The amount of time a generated token remains valid.
		/// </value>
		public TimeSpan TokenLifespan
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

		public DataProtectionTokenProviderOptions()
		{
			throw null;
		}
	}
}
