using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Localization
{
	/// <summary>
	/// A locale specific string.
	/// </summary>
	public class LocalizedString
	{
		/// <summary>
		/// The name of the string in the resource it was loaded from.
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
		/// The actual string.
		/// </summary>
		public string Value
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Whether the string was not found in a resource. If <c>true</c>, an alternate string value was used.
		/// </summary>
		public bool ResourceNotFound
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The location which was searched for a localization value.
		/// </summary>
		public string? SearchedLocation
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Extensions.Localization.LocalizedString" />.
		/// </summary>
		/// <param name="name">The name of the string in the resource it was loaded from.</param>
		/// <param name="value">The actual string.</param>
		public LocalizedString(string name, string value)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Extensions.Localization.LocalizedString" />.
		/// </summary>
		/// <param name="name">The name of the string in the resource it was loaded from.</param>
		/// <param name="value">The actual string.</param>
		/// <param name="resourceNotFound">Whether the string was not found in a resource. Set this to <c>true</c> to indicate an alternate string value was used.</param>
		public LocalizedString(string name, string value, bool resourceNotFound)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Extensions.Localization.LocalizedString" />.
		/// </summary>
		/// <param name="name">The name of the string in the resource it was loaded from.</param>
		/// <param name="value">The actual string.</param>
		/// <param name="resourceNotFound">Whether the string was not found in a resource. Set this to <c>true</c> to indicate an alternate string value was used.</param>
		/// <param name="searchedLocation">The location which was searched for a localization value.</param>
		public LocalizedString(string name, string value, bool resourceNotFound, string? searchedLocation)
		{
			throw null;
		}

		/// <summary>
		/// Implicitly converts the <see cref="T:Microsoft.Extensions.Localization.LocalizedString" /> to a <see cref="T:System.String" />.
		/// </summary>
		/// <param name="localizedString">The string to be implicitly converted.</param>
		public static implicit operator string?(LocalizedString localizedString)
		{
			throw null;
		}

		/// <summary>
		/// Returns the actual string.
		/// </summary>
		/// <returns>The actual string.</returns>
		public override string ToString()
		{
			throw null;
		}
	}
}
