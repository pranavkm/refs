using System.Collections.Generic;

namespace Microsoft.Extensions.Localization
{
	/// <summary>
	/// Provides strings for <typeparamref name="TResourceSource" />.
	/// </summary>
	/// <typeparam name="TResourceSource">The <see cref="T:System.Type" /> to provide strings for.</typeparam>
	public class StringLocalizer<TResourceSource> : IStringLocalizer<TResourceSource>, IStringLocalizer
	{
		/// <inheritdoc />
		public virtual LocalizedString this[string name]
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public virtual LocalizedString this[string name, params object[] arguments]
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Extensions.Localization.StringLocalizer`1" />.
		/// </summary>
		/// <param name="factory">The <see cref="T:Microsoft.Extensions.Localization.IStringLocalizerFactory" /> to use.</param>
		public StringLocalizer(IStringLocalizerFactory factory)
		{
			throw null;
		}

		/// <inheritdoc />
		public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
		{
			throw null;
		}
	}
}
