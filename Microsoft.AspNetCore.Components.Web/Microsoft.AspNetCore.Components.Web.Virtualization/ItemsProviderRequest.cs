using System.Runtime.CompilerServices;
using System.Threading;

namespace Microsoft.AspNetCore.Components.Web.Virtualization
{
	/// <summary>
	/// Represents a request to an <see cref="T:Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderDelegate`1" />.
	/// </summary>
	public readonly struct ItemsProviderRequest
	{
		/// <summary>
		/// The start index of the data segment requested.
		/// </summary>
		public int StartIndex
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The requested number of items to be provided. The actual number of provided items does not need to match
		/// this value.
		/// </summary>
		public int Count
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The <see cref="T:System.Threading.CancellationToken" /> used to relay cancellation of the request.
		/// </summary>
		public CancellationToken CancellationToken
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructs a new <see cref="T:Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderRequest" /> instance.
		/// </summary>
		/// <param name="startIndex">The start index of the data segment requested.</param>
		/// <param name="count">The requested number of items to be provided.</param>
		/// <param name="cancellationToken">
		/// The <see cref="T:System.Threading.CancellationToken" /> used to relay cancellation of the request.
		/// </param>
		public ItemsProviderRequest(int startIndex, int count, CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
