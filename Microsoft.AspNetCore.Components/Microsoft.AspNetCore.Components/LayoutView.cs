using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Displays the specified content inside the specified layout and any further
	/// nested layouts.
	/// </summary>
	public class LayoutView : IComponent
	{
		/// <summary>
		/// Gets or sets the content to display.
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

		/// <summary>
		/// Gets or sets the type of the layout in which to display the content.
		/// The type must implement <see cref="T:Microsoft.AspNetCore.Components.IComponent" /> and accept a parameter named <see cref="P:Microsoft.AspNetCore.Components.LayoutComponentBase.Body" />.
		/// </summary>
		[Parameter]
		public Type Layout
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
		public void Attach(RenderHandle renderHandle)
		{
			throw null;
		}

		/// <inheritdoc />
		public Task SetParametersAsync(ParameterView parameters)
		{
			throw null;
		}

		public LayoutView()
		{
			throw null;
		}
	}
}
