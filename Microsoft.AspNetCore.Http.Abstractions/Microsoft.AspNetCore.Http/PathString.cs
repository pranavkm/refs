using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Provides correct escaping for Path and PathBase values when needed to reconstruct a request or redirect URI string
	/// </summary>
	[TypeConverter(typeof(PathStringConverter))]
	public readonly struct PathString : IEquatable<PathString>
	{
		/// <summary>
		/// Represents the empty path. This field is read-only.
		/// </summary>
		public static readonly PathString Empty;

		private readonly string? _value;

		/// <summary>
		/// The unescaped path value
		/// </summary>
		public string? Value
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// True if the path is not empty
		/// </summary>
		public bool HasValue
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initialize the path string with a given value. This value must be in unescaped format. Use
		/// PathString.FromUriComponent(value) if you have a path value which is in an escaped format.
		/// </summary>
		/// <param name="value">The unescaped path to be assigned to the Value property.</param>
		[System.Runtime.CompilerServices.NullableContext(2)]
		public PathString(string? value)
		{
			throw null;
		}

		/// <summary>
		/// Provides the path string escaped in a way which is correct for combining into the URI representation.
		/// </summary>
		/// <returns>The escaped path value</returns>
		public override string ToString()
		{
			throw null;
		}

		/// <summary>
		/// Provides the path string escaped in a way which is correct for combining into the URI representation.
		/// </summary>
		/// <returns>The escaped path value</returns>
		public string ToUriComponent()
		{
			throw null;
		}

		/// <summary>
		/// Returns an PathString given the path as it is escaped in the URI format. The string MUST NOT contain any
		/// value that is not a path.
		/// </summary>
		/// <param name="uriComponent">The escaped path as it appears in the URI format.</param>
		/// <returns>The resulting PathString</returns>
		public static PathString FromUriComponent(string uriComponent)
		{
			throw null;
		}

		/// <summary>
		/// Returns an PathString given the path as from a Uri object. Relative Uri objects are not supported.
		/// </summary>
		/// <param name="uri">The Uri object</param>
		/// <returns>The resulting PathString</returns>
		public static PathString FromUriComponent(Uri uri)
		{
			throw null;
		}

		/// <summary>
		/// Determines whether the beginning of this <see cref="T:Microsoft.AspNetCore.Http.PathString" /> instance matches the specified <see cref="T:Microsoft.AspNetCore.Http.PathString" />.
		/// </summary>
		/// <param name="other">The <see cref="T:Microsoft.AspNetCore.Http.PathString" /> to compare.</param>
		/// <returns>true if value matches the beginning of this string; otherwise, false.</returns>
		public bool StartsWithSegments(PathString other)
		{
			throw null;
		}

		/// <summary>
		/// Determines whether the beginning of this <see cref="T:Microsoft.AspNetCore.Http.PathString" /> instance matches the specified <see cref="T:Microsoft.AspNetCore.Http.PathString" /> when compared
		/// using the specified comparison option.
		/// </summary>
		/// <param name="other">The <see cref="T:Microsoft.AspNetCore.Http.PathString" /> to compare.</param>
		/// <param name="comparisonType">One of the enumeration values that determines how this <see cref="T:Microsoft.AspNetCore.Http.PathString" /> and value are compared.</param>
		/// <returns>true if value matches the beginning of this string; otherwise, false.</returns>
		public bool StartsWithSegments(PathString other, StringComparison comparisonType)
		{
			throw null;
		}

		/// <summary>
		/// Determines whether the beginning of this <see cref="T:Microsoft.AspNetCore.Http.PathString" /> instance matches the specified <see cref="T:Microsoft.AspNetCore.Http.PathString" /> and returns
		/// the remaining segments.
		/// </summary>
		/// <param name="other">The <see cref="T:Microsoft.AspNetCore.Http.PathString" /> to compare.</param>
		/// <param name="remaining">The remaining segments after the match.</param>
		/// <returns>true if value matches the beginning of this string; otherwise, false.</returns>
		public bool StartsWithSegments(PathString other, out PathString remaining)
		{
			throw null;
		}

		/// <summary>
		/// Determines whether the beginning of this <see cref="T:Microsoft.AspNetCore.Http.PathString" /> instance matches the specified <see cref="T:Microsoft.AspNetCore.Http.PathString" /> when compared
		/// using the specified comparison option and returns the remaining segments.
		/// </summary>
		/// <param name="other">The <see cref="T:Microsoft.AspNetCore.Http.PathString" /> to compare.</param>
		/// <param name="comparisonType">One of the enumeration values that determines how this <see cref="T:Microsoft.AspNetCore.Http.PathString" /> and value are compared.</param>
		/// <param name="remaining">The remaining segments after the match.</param>
		/// <returns>true if value matches the beginning of this string; otherwise, false.</returns>
		public bool StartsWithSegments(PathString other, StringComparison comparisonType, out PathString remaining)
		{
			throw null;
		}

		/// <summary>
		/// Determines whether the beginning of this <see cref="T:Microsoft.AspNetCore.Http.PathString" /> instance matches the specified <see cref="T:Microsoft.AspNetCore.Http.PathString" /> and returns
		/// the matched and remaining segments.
		/// </summary>
		/// <param name="other">The <see cref="T:Microsoft.AspNetCore.Http.PathString" /> to compare.</param>
		/// <param name="matched">The matched segments with the original casing in the source value.</param>
		/// <param name="remaining">The remaining segments after the match.</param>
		/// <returns>true if value matches the beginning of this string; otherwise, false.</returns>
		public bool StartsWithSegments(PathString other, out PathString matched, out PathString remaining)
		{
			throw null;
		}

		/// <summary>
		/// Determines whether the beginning of this <see cref="T:Microsoft.AspNetCore.Http.PathString" /> instance matches the specified <see cref="T:Microsoft.AspNetCore.Http.PathString" /> when compared
		/// using the specified comparison option and returns the matched and remaining segments.
		/// </summary>
		/// <param name="other">The <see cref="T:Microsoft.AspNetCore.Http.PathString" /> to compare.</param>
		/// <param name="comparisonType">One of the enumeration values that determines how this <see cref="T:Microsoft.AspNetCore.Http.PathString" /> and value are compared.</param>
		/// <param name="matched">The matched segments with the original casing in the source value.</param>
		/// <param name="remaining">The remaining segments after the match.</param>
		/// <returns>true if value matches the beginning of this string; otherwise, false.</returns>
		public bool StartsWithSegments(PathString other, StringComparison comparisonType, out PathString matched, out PathString remaining)
		{
			throw null;
		}

		/// <summary>
		/// Adds two PathString instances into a combined PathString value.
		/// </summary>
		/// <returns>The combined PathString value</returns>
		public PathString Add(PathString other)
		{
			throw null;
		}

		/// <summary>
		/// Combines a PathString and QueryString into the joined URI formatted string value.
		/// </summary>
		/// <returns>The joined URI formatted string value</returns>
		public string Add(QueryString other)
		{
			throw null;
		}

		/// <summary>
		/// Compares this PathString value to another value. The default comparison is StringComparison.OrdinalIgnoreCase.
		/// </summary>
		/// <param name="other">The second PathString for comparison.</param>
		/// <returns>True if both PathString values are equal</returns>
		public bool Equals(PathString other)
		{
			throw null;
		}

		/// <summary>
		/// Compares this PathString value to another value using a specific StringComparison type
		/// </summary>
		/// <param name="other">The second PathString for comparison</param>
		/// <param name="comparisonType">The StringComparison type to use</param>
		/// <returns>True if both PathString values are equal</returns>
		public bool Equals(PathString other, StringComparison comparisonType)
		{
			throw null;
		}

		/// <summary>
		/// Compares this PathString value to another value. The default comparison is StringComparison.OrdinalIgnoreCase.
		/// </summary>
		/// <param name="obj">The second PathString for comparison.</param>
		/// <returns>True if both PathString values are equal</returns>
		public override bool Equals(object? obj)
		{
			throw null;
		}

		/// <summary>
		/// Returns the hash code for the PathString value. The hash code is provided by the OrdinalIgnoreCase implementation.
		/// </summary>
		/// <returns>The hash code</returns>
		public override int GetHashCode()
		{
			throw null;
		}

		/// <summary>
		/// Operator call through to Equals
		/// </summary>
		/// <param name="left">The left parameter</param>
		/// <param name="right">The right parameter</param>
		/// <returns>True if both PathString values are equal</returns>
		public static bool operator ==(PathString left, PathString right)
		{
			throw null;
		}

		/// <summary>
		/// Operator call through to Equals
		/// </summary>
		/// <param name="left">The left parameter</param>
		/// <param name="right">The right parameter</param>
		/// <returns>True if both PathString values are not equal</returns>
		public static bool operator !=(PathString left, PathString right)
		{
			throw null;
		}

		/// <summary>
		/// </summary>
		/// <param name="left">The left parameter</param>
		/// <param name="right">The right parameter</param>
		/// <returns>The ToString combination of both values</returns>
		public static string operator +(string left, PathString right)
		{
			throw null;
		}

		/// <summary>
		/// </summary>
		/// <param name="left">The left parameter</param>
		/// <param name="right">The right parameter</param>
		/// <returns>The ToString combination of both values</returns>
		public static string operator +(PathString left, string? right)
		{
			throw null;
		}

		/// <summary>
		/// Operator call through to Add
		/// </summary>
		/// <param name="left">The left parameter</param>
		/// <param name="right">The right parameter</param>
		/// <returns>The PathString combination of both values</returns>
		public static PathString operator +(PathString left, PathString right)
		{
			throw null;
		}

		/// <summary>
		/// Operator call through to Add
		/// </summary>
		/// <param name="left">The left parameter</param>
		/// <param name="right">The right parameter</param>
		/// <returns>The PathString combination of both values</returns>
		public static string operator +(PathString left, QueryString right)
		{
			throw null;
		}

		/// <summary>
		/// Implicitly creates a new PathString from the given string.
		/// </summary>
		/// <param name="s"></param>
		[System.Runtime.CompilerServices.NullableContext(2)]
		public static implicit operator PathString(string? s)
		{
			throw null;
		}

		/// <summary>
		/// Implicitly calls ToString().
		/// </summary>
		/// <param name="path"></param>
		public static implicit operator string(PathString path)
		{
			throw null;
		}

		internal static PathString ConvertFromString(string? s)
		{
			throw null;
		}
	}
}
