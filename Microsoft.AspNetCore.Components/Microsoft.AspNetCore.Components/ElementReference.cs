using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Represents a reference to a rendered element.
	/// </summary>
	public readonly struct ElementReference
	{
		private static long _nextIdForWebAssemblyOnly;

		/// <summary>
		/// Gets a unique identifier for <see cref="T:Microsoft.AspNetCore.Components.ElementReference" />.
		/// </summary>
		/// <remarks>
		/// The Id is unique at least within the scope of a given user/circuit.
		/// This property is public to support Json serialization and should not be used by user code.
		/// </remarks>
		public string Id
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the <see cref="T:Microsoft.AspNetCore.Components.ElementReferenceContext" /> instance.
		/// </summary>
		public ElementReferenceContext? Context
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Instantiates a new <see cref="T:Microsoft.AspNetCore.Components.ElementReference" />.
		/// </summary>
		/// <param name="id">A unique identifier for this <see cref="T:Microsoft.AspNetCore.Components.ElementReference" />.</param>
		/// <param name="context">The nullable <see cref="T:Microsoft.AspNetCore.Components.ElementReferenceContext" /> instance.</param>
		public ElementReference(string id, ElementReferenceContext? context)
		{
			throw null;
		}

		/// <summary>
		/// Instantiates a new <see cref="T:Microsoft.AspNetCore.Components.ElementReference" />.
		/// </summary>
		/// <param name="id">A unique identifier for this <see cref="T:Microsoft.AspNetCore.Components.ElementReference" />.</param>
		public ElementReference(string id)
		{
			throw null;
		}

		internal static ElementReference CreateWithUniqueId(ElementReferenceContext? context)
		{
			throw null;
		}
	}
}
