using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Internal
{
	internal static class TypeNameHelper
	{
		private readonly struct DisplayNameOptions
		{
			public bool FullName
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public bool IncludeGenericParameters
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public bool IncludeGenericParameterNames
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public char NestedTypeDelimiter
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public DisplayNameOptions(bool fullName, bool includeGenericParameterNames, bool includeGenericParameters, char nestedTypeDelimiter)
			{
				throw null;
			}
		}

		public static string GetTypeDisplayName(object item, bool fullName = true)
		{
			throw null;
		}

		/// <summary>
		/// Pretty print a type name.
		/// </summary>
		/// <param name="type">The <see cref="T:System.Type" />.</param>
		/// <param name="fullName"><c>true</c> to print a fully qualified name.</param>
		/// <param name="includeGenericParameterNames"><c>true</c> to include generic parameter names.</param>
		/// <param name="includeGenericParameters"><c>true</c> to include generic parameters.</param>
		/// <param name="nestedTypeDelimiter">Character to use as a delimiter in nested type names</param>
		/// <returns>The pretty printed type name.</returns>
		public static string GetTypeDisplayName(Type type, bool fullName = true, bool includeGenericParameterNames = false, bool includeGenericParameters = true, char nestedTypeDelimiter = '+')
		{
			throw null;
		}
	}
}
