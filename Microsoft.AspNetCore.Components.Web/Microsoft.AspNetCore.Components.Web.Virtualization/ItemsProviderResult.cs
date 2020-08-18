using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Web.Virtualization
{
	/// <summary>
	/// Represents the result of a <see cref="T:Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderDelegate`1" />.
	/// </summary>
	/// <typeparam name="TItem">The type of the context for each item in the list.</typeparam>
	public readonly struct ItemsProviderResult<TItem>
	{
		/// <summary>
		/// The items to provide.
		/// </summary>
		public IEnumerable<TItem> Items
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The total item count in the source generating the items provided.
		/// </summary>
		public int TotalItemCount
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Instantiates a new <see cref="T:Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderResult`1" /> instance.
		/// </summary>
		/// <param name="items">The items to provide.</param>
		/// <param name="totalItemCount">The total item count in the source generating the items provided.</param>
		public ItemsProviderResult(IEnumerable<TItem> items, int totalItemCount)
		{
			throw null;
		}
	}
}
