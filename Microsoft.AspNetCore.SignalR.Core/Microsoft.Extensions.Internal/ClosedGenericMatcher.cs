using System;

namespace Microsoft.Extensions.Internal
{
	/// <summary>
	/// Helper related to generic interface definitions and implementing classes.
	/// </summary>
	internal static class ClosedGenericMatcher
	{
		/// <summary>
		/// Determine whether <paramref name="queryType" /> is or implements a closed generic <see cref="T:System.Type" />
		/// created from <paramref name="interfaceType" />.
		/// </summary>
		/// <param name="queryType">The <see cref="T:System.Type" /> of interest.</param>
		/// <param name="interfaceType">The open generic <see cref="T:System.Type" /> to match. Usually an interface.</param>
		/// <returns>
		/// The closed generic <see cref="T:System.Type" /> created from <paramref name="interfaceType" /> that
		/// <paramref name="queryType" /> is or implements. <c>null</c> if the two <see cref="T:System.Type" />s have no such
		/// relationship.
		/// </returns>
		/// <remarks>
		/// This method will return <paramref name="queryType" /> if <paramref name="interfaceType" /> is
		/// <c>typeof(KeyValuePair{,})</c>, and <paramref name="queryType" /> is
		/// <c>typeof(KeyValuePair{string, object})</c>.
		/// </remarks>
		public static Type? ExtractGenericInterface(Type queryType, Type interfaceType)
		{
			throw null;
		}
	}
}
