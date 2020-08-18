using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Authorization
{
	public class CascadingAuthenticationState : ComponentBase, IDisposable
	{
		/// <summary>
		/// The content to which the authentication state should be provided.
		/// </summary>
		[Parameter]
		public RenderFragment ChildContent
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

		protected override void BuildRenderTree(RenderTreeBuilder __builder)
		{
			throw null;
		}

		protected override void OnInitialized()
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		public CascadingAuthenticationState()
		{
			throw null;
		}
	}
}
