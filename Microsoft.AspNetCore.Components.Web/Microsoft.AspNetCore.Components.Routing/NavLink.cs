using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Routing
{
	/// <summary>
	/// A component that renders an anchor tag, automatically toggling its 'active'
	/// class based on whether its 'href' matches the current URI.
	/// </summary>
	public class NavLink : ComponentBase, IDisposable
	{
		/// <summary>
		/// Gets or sets the CSS class name applied to the NavLink when the
		/// current route matches the NavLink href.
		/// </summary>
		[Parameter]
		public string? ActiveClass
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
		/// Gets or sets a collection of additional attributes that will be added to the generated
		/// <c>a</c> element.
		/// </summary>
		[Parameter(CaptureUnmatchedValues = true)]
		public IReadOnlyDictionary<string, object>? AdditionalAttributes
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
		/// Gets or sets the computed CSS class based on whether or not the link is active.
		/// </summary>
		protected string? CssClass
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
		/// Gets or sets the child content of the component.
		/// </summary>
		[Parameter]
		public RenderFragment? ChildContent
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
		/// Gets or sets a value representing the URL matching behavior.
		/// </summary>
		[Parameter]
		public NavLinkMatch Match
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
		protected override void OnInitialized()
		{
			throw null;
		}

		/// <inheritdoc />
		protected override void OnParametersSet()
		{
			throw null;
		}

		/// <inheritdoc />
		public void Dispose()
		{
			throw null;
		}

		protected override void BuildRenderTree(RenderTreeBuilder builder)
		{
			throw null;
		}

		public NavLink()
		{
			throw null;
		}
	}
}
