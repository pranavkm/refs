using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Web.Virtualization
{
	/// <summary>
	/// A function that provides items to a virtualized source.
	/// </summary>
	/// <typeparam name="TItem">The type of the context for each item in the list.</typeparam>
	/// <param name="request">The <see cref="T:Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderRequest" /> defining the request details.</param>
	/// <returns>A <see cref="T:System.Threading.Tasks.ValueTask" /> whose result is a <see cref="T:Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderResult`1" /> upon successful completion.</returns>
	public delegate ValueTask<ItemsProviderResult<TItem>> ItemsProviderDelegate<TItem>(ItemsProviderRequest request);
}
