using System;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Provides correct handling for FragmentString value when needed to generate a URI string
	/// </summary>
	public readonly struct FragmentString : IEquatable<FragmentString>
	{
		/// <summary>
		/// Represents the empty fragment string. This field is read-only.
		/// </summary>
		public static readonly FragmentString Empty;

		private readonly string _value;

		/// <summary>
		/// The escaped fragment string with the leading '#' character
		/// </summary>
		public string Value
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// True if the fragment string is not empty
		/// </summary>
		public bool HasValue
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initialize the fragment string with a given value. This value must be in escaped and delimited format with
		/// a leading '#' character.
		/// </summary>
		/// <param name="value">The fragment string to be assigned to the Value property.</param>
		public FragmentString(string value)
		{
			throw null;
		}

		/// <summary>
		/// Provides the fragment string escaped in a way which is correct for combining into the URI representation.
		/// A leading '#' character will be included unless the Value is null or empty. Characters which are potentially
		/// dangerous are escaped.
		/// </summary>
		/// <returns>The fragment string value</returns>
		public override string ToString()
		{
			throw null;
		}

		/// <summary>
		/// Provides the fragment string escaped in a way which is correct for combining into the URI representation.
		/// A leading '#' character will be included unless the Value is null or empty. Characters which are potentially
		/// dangerous are escaped.
		/// </summary>
		/// <returns>The fragment string value</returns>
		public string ToUriComponent()
		{
			throw null;
		}

		/// <summary>
		/// Returns an FragmentString given the fragment as it is escaped in the URI format. The string MUST NOT contain any
		/// value that is not a fragment.
		/// </summary>
		/// <param name="uriComponent">The escaped fragment as it appears in the URI format.</param>
		/// <returns>The resulting FragmentString</returns>
		public static FragmentString FromUriComponent(string uriComponent)
		{
			throw null;
		}

		/// <summary>
		/// Returns an FragmentString given the fragment as from a Uri object. Relative Uri objects are not supported.
		/// </summary>
		/// <param name="uri">The Uri object</param>
		/// <returns>The resulting FragmentString</returns>
		public static FragmentString FromUriComponent(Uri uri)
		{
			throw null;
		}

		public bool Equals(FragmentString other)
		{
			throw null;
		}

		public override bool Equals(object? obj)
		{
			throw null;
		}

		public override int GetHashCode()
		{
			throw null;
		}

		public static bool operator ==(FragmentString left, FragmentString right)
		{
			throw null;
		}

		public static bool operator !=(FragmentString left, FragmentString right)
		{
			throw null;
		}
	}
}
