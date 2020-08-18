using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection.Internal
{
	/// <summary>
	/// Default implementation of <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder" />.
	/// </summary>
	internal class DataProtectionBuilder : IDataProtectionBuilder
	{
		/// <inheritdoc />
		public IServiceCollection Services
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new configuration object linked to a <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
		/// </summary>
		public DataProtectionBuilder(IServiceCollection services)
		{
			throw null;
		}
	}
}
