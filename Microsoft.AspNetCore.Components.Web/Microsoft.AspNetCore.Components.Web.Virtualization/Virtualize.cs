using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Web.Virtualization
{
	/// <summary>
	/// Provides functionality for rendering a virtualized list of items.
	/// </summary>
	/// <typeparam name="TItem">The <c>context</c> type for the items being rendered.</typeparam>
	public sealed class Virtualize<TItem> : ComponentBase, IVirtualizeJsCallbacks, IAsyncDisposable
	{
		/// <summary>
		/// Gets or sets the item template for the list.
		/// </summary>
		[Parameter]
		public RenderFragment<TItem>? ChildContent
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the item template for the list.
		/// </summary>
		[Parameter]
		public RenderFragment<TItem>? ItemContent
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the template for items that have not yet been loaded in memory.
		/// </summary>
		[Parameter]
		public RenderFragment<PlaceholderContext>? Placeholder
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the size of each item in pixels.
		/// </summary>
		[Parameter]
		public float ItemSize
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the function providing items to the list.
		/// </summary>
		[Parameter]
		public ItemsProviderDelegate<TItem>? ItemsProvider
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the fixed item source.
		/// </summary>
		[Parameter]
		public ICollection<TItem>? Items
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <inheritdoc />
		protected override void OnParametersSet()
		{
			throw null;
		}

		/// <inheritdoc />
		[AsyncStateMachine(typeof(Virtualize<>._003COnAfterRenderAsync_003Ed__42))]
		[DebuggerStepThrough]
		protected override Task OnAfterRenderAsync(bool firstRender)
		{
			throw null;
		}

		/// <inheritdoc />
		protected override void BuildRenderTree(RenderTreeBuilder builder)
		{
			throw null;
		}

		void IVirtualizeJsCallbacks.OnBeforeSpacerVisible(float spacerSize, float containerSize)
		{
			throw null;
		}

		void IVirtualizeJsCallbacks.OnAfterSpacerVisible(float spacerSize, float containerSize)
		{
			throw null;
		}

		/// <inheritdoc />
		[AsyncStateMachine(typeof(Virtualize<>._003CDisposeAsync_003Ed__52))]
		[DebuggerStepThrough]
		public ValueTask DisposeAsync()
		{
			throw null;
		}

		public Virtualize()
		{
			throw null;
		}
	}
}
